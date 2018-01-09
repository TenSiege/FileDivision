using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDivision
{
    public partial class MianFrom : Form
    {
        /*-----------------------------------------全局属性声明区-----------------------------------------------------*/
        private String fileURL = "";               //用户所选文件的绝对路径
        private long MB = (long)Math.Pow(1024, 2); //MB单位所占的字节数
        private long GB = (long)Math.Pow(1024, 3); //GB单位所占的字节数
        private long fileLenght = 0;               //每个分割文件的大小
        private long lastFileLenght = 0;           //最后一个分割文件的大小
        private FileStream fileStream;             //文件读取流
        private BinaryReader binaryReader;         //二进制文件读取流 
        private HeadFile headFile;                 //头文件对象
        private Thread fileDivisionWord;           //进行分割文件工作的线程
        private volatile bool isStop;              //是否终止线程的标记
        public MianFrom()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MianFrom_Load(object sender, EventArgs e)
        {
            cmbUnit.SelectedIndex = 0;
            CheckForIllegalCrossThreadCalls = false;
            btnStop.Enabled = false; //开始时禁用终止分割按钮
        }
        /// <summary>
        /// 非空验证
        /// </summary>
        /// <returns>true = 通过验证  ||  false = 未通过验证</returns>
        private Boolean CheckNull(String type)
        {
            Boolean check = true;
            switch (type)
            {
                case "division":
                    if (txtFile.Text.Equals(""))
                    {
                        MessageBox.Show("请选择需要分割的文件");
                        check = false;
                    }
                    else if (txtFileOutURL.Text.Equals(""))
                    {
                        MessageBox.Show("请选择文件输出路径");
                        check = false;
                    }
                    break;
                case "merge":
                    if (txtHeadFile.Text.Equals(""))
                    {
                        MessageBox.Show("请选择头文件");
                        check = false;
                    }
                    else if (txtFileURL.Text.Equals(""))
                    {
                        MessageBox.Show("请选择文件输出路径");
                        check = false;
                    }
                    break;
            }
            return check;
        }
        /// <summary>
        /// 开始分割按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.Text)
            {
                case "开始分割":
                    if (!CheckNull("division"))
                    {
                        return;
                    }
                    isStop = false;
                    //开始分割文件，这里用一个新的线程，以便分割文件的同时可以执行其他操作
                    //1.实例化线程对象
                    fileDivisionWord = new Thread(new ThreadStart(StartDivision));
                    //2.启动线程
                    fileDivisionWord.Start();
                    btnStop.Enabled = true;
                    break;
                case "终止分割":
                    btnStop.Enabled = false;
                    isStop = true;
                    break;
            }

        }
        /// <summary>
        /// 选择文件按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            txtFile.Text = file.SafeFileName;
            fileURL = file.FileName;
        }
        /// <summary>
        /// 选择文件输出路径的按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelectOutULR_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            txtFileOutURL.Text = path.SelectedPath;
        }
        /// <summary>
        /// 计算文件分割数量
        /// </summary>
        /// <param name="unit">单位</param>
        /// <param name="mianfile">被分割文件的大小</param>
        /// <param name="fileSize">分割后的单个文件大小参数</param>
        /// <return>需要分成多少份</return>
        private int ComputingFileSize(String unit, long mainFile, int fileSize)
        {
            int fileCount = 0;
            if (unit == "MB")
            {
                fileLenght = fileSize * MB;
                fileCount = (int)((mainFile % fileLenght == 0) ? (mainFile / fileLenght) : (mainFile / fileLenght + 1));
            }
            else
            {
                fileLenght = fileSize * GB;
                fileCount = Convert.ToInt32(mainFile % fileLenght == 0 ? mainFile / fileLenght : mainFile / fileLenght + 1);
            }
            lastFileLenght = mainFile % fileLenght;
            prgSchedule.Maximum = fileCount;
            return fileCount;
        }
        /// <summary>
        /// 添加一条信息到ListView
        /// </summary>
        /// <param name="message">信息字符串</param>
        private void AddInfo(String message)
        {
            if (isStop) { return; }
            ListViewItem listViewItem = new ListViewItem()
            {
                Text = message
            };
            lvwFileInfo.Items.Add(listViewItem);
        }
        /// <summary>
        /// 分割文件的方法
        /// </summary>
        /// <param name="mainFile">被分割文件的路径</param>
        /// <param name="outURL">分割后文件的路径</param>
        /// <param name="count">分割数量</param>
        private void StartDivision()
        {
            //清空ListView
            lvwFileInfo.Items.Clear();
            //创建指向用户选择文件的读取流
            fileStream = new FileStream(fileURL, FileMode.Open);
            //计算分割文件的数量并输出在ListView中
            AddInfo("正在计算分割后文件的数量……");
            int count = ComputingFileSize(cmbUnit.Text, fileStream.Length, (int)nudFileSize.Value);
            AddInfo("分割后文件的数量为:" + count);
            String outURL = txtFileOutURL.Text;
            String fileName = txtFile.Text;
            //创建头文件对象           
            headFile = new HeadFile(count);
            headFile.Format = txtFile.Text;
            //创建指向用户选择文件的读取流
            binaryReader = new BinaryReader(fileStream);
            for (int i = 1; i <= count; i++)
            {
                if (isStop)//安全退出该方法和线程
                {
                    AddInfo("已终止操作  - - - - - - - - >");
                    fileStream.Close();
                    binaryReader.Close();
                    return;
                }
                long fileSize = i == count ? lastFileLenght : fileLenght;
                //分割后文件的全称
                String fileURL = outURL + "\\" + fileName.Substring(0, fileName.LastIndexOf('.')) + i + ".binary";
                //加入信息到ListView中
                AddInfo("创建文件:" + fileURL);
                //二进制数据写入对象
                using (BinaryWriter binaryWriter = new BinaryWriter(new FileStream(fileURL, FileMode.OpenOrCreate, FileAccess.ReadWrite)))
                {
                    for (int rate = 0; !(rate == fileSize);)
                    {
                        byte[] bytes = FillCache(binaryReader);
                        //进行迭代计算
                        rate += bytes.Length;
                        //将缓存区的数据写入文件
                        binaryWriter.Write(bytes);
                        //添加信息进ListView中
                        //AddInfo("以写入数据：" + rate + " BB");
                    }
                }
                //添加信息到头文件中
                headFile.AddFileInfo(new Info(fileName.Substring(0, fileName.LastIndexOf('.')) + i + ".binary", fileSize));
                //进度条前进
                prgSchedule.Value++;
            }
            //序列化头文件对象
            String headFileURL = outURL + "\\" + fileName.Substring(0, fileName.LastIndexOf('.')) + ".head";
            Stream fStream = new FileStream(headFileURL, FileMode.Create, FileAccess.ReadWrite);
            BinaryFormatter binFormat = new BinaryFormatter();//创建二进制序列化器
            binFormat.Serialize(fStream, headFile);           
            AddInfo("创建头文件" + headFileURL);
            AddInfo("本次文件分解完毕……");
            //释放资源
            btnStop.Enabled = false;           
            fStream.Close();
            fileStream.Close();
            binaryReader.Close();    
        }
        /// <summary>
        /// 选择头文件按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "HEAD文件|*.head|全部文件|*.*";
            file.ShowDialog();
            txtHeadFile.Text = file.FileName;
        }
        /// <summary>
        /// 选择合并后的文件存放路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFileURL_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            txtFileURL.Text = path.SelectedPath;
        }
        /// <summary>
        /// 开始合并按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMerge_Click(object sender, EventArgs e)
        {
            //非空验证
            if (!CheckNull("merge")) { return; }
            Thread fileMergeWord = new Thread(new ThreadStart(StartMerge));
            fileMergeWord.Start();
        }
        /// <summary>
        /// 合并文件的方法
        /// </summary>
        private void StartMerge()
        {
            //清空ListView
            lvwFileInfo.Items.Clear();
            //清空进度条
            prgSchedule.Value = 0;
            //反序列化头文件对象
            FileStream fs = new FileStream(txtHeadFile.Text, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            HeadFile headFile = bf.Deserialize(fs) as HeadFile;
            prgSchedule.Maximum = headFile.GetFileInfo().Length;
            //获得所有文件片段的路径信息
            Dictionary<String, String> dictionary = new Dictionary<String, String>();
            String[] urls = Directory.GetFiles(txtHeadFile.Text.Substring(0, txtHeadFile.Text.LastIndexOf('\\') + 1), "*.binary");
            foreach (Info fileInfo in headFile.GetFileInfo())
            {
                foreach (String url in urls)
                {
                    if (fileInfo.FileName.Equals(url.Substring(url.LastIndexOf('\\')+1)))
                    {
                        //建立文件名和路径的映射
                        dictionary.Add(fileInfo.FileName, url);
                        break;
                    }
                }
            }
            //校检文件完整性
            if (CheckFile(headFile, dictionary))
            {
                AddInfo("文件校检成功，开始合并文件 - - - - - >");
                //创建文件写入流
                FileStream fileStream = new FileStream(txtFileURL.Text+"\\"+headFile.Format, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                //创建二进制写入流
                BinaryWriter binaryWriter = new BinaryWriter(fileStream);
                foreach (Info info in headFile.GetFileInfo())
                {
                    String url = dictionary[info.FileName];
                    FileStream fragmentFile = new FileStream(url, FileMode.Open, FileAccess.Read);
                    //创建二进制读取流
                    BinaryReader binaryReader = new BinaryReader(fragmentFile);
                    for (int rate = 0; rate < fragmentFile.Length;)
                    {
                        byte[] bytes = FillCache(binaryReader);
                        rate += bytes.Length;
                        binaryWriter.Write(bytes);
                    }
                    AddInfo("已合并文件："+url);
                    prgSchedule.Value++;
                }
                AddInfo("文件合并完毕 - - - - - - >");
            }
            else
            {
                MessageBox.Show("文件校检失败：\n1.请检查-文件片段是否完整且都在同一文件夹下。\n2.检查-是否对文件片段有过重命名。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 文件完整性校检
        /// </summary>
        /// <param name="headFile">头文件对象</param>
        /// <param name="hashtable">文件路径映射集合</param>
        /// <returns>{true : 校检成功 , false : 校检失败}</returns>
        private bool CheckFile(HeadFile headFile, Dictionary<String, String> dictionary)
        {
            bool check = true;
            foreach (Info fileInfo in headFile.GetFileInfo())
            {
                String url = dictionary[fileInfo.FileName];
                if (fileInfo.FileSize == new FileInfo(url).Length)
                {
                    AddInfo("校检 " + url + " 成功");
                }
                else
                {
                    AddInfo("校检 " + url + " 失败,大小不匹配");
                    check = false;
                    return check;
                }
            }
            return check;
        }
        /// <summary>
        /// 填充缓存区
        /// </summary>
        /// <param name="binaryReader">读取流对象</param>
        /// <returns>缓存数据</returns>
        private byte[] FillCache(BinaryReader binaryReader)
        {
            //1M的主缓存区
            byte[] cache = new byte[MB];
            //不足1M的副缓存区，在读不满1MB的字节时使用此缓存区
            byte[] cache_secondary = null;
            //每次循环读取出1M的数据到缓存区
            for (int k = 0; k < MB; k++)
            {
                try
                {
                    cache[k] = binaryReader.ReadByte();
                }
                catch (EndOfStreamException)//当出现此异常时，说明以到达流的结尾
                {
                    //转移主缓存区的数据到副缓存区
                    cache_secondary = new byte[k];
                    for (int j = 0; j < k; j++)
                    {
                        cache_secondary[j] = cache[j];
                    }
                    break;
                }
            }
            //进行迭代计算
            //rate += cache_secondary == null ? cache.Length : cache_secondary.Length;
            if (cache_secondary == null)
            {
                return cache;
            }
            else
            {
                return cache_secondary;
            }
        }
    }
}
