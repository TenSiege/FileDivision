using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// 头文件类
/// </summary>
namespace FileDivision
{
    [Serializable]
    class HeadFile
    {
        private Info[] fileInfoList;//每个文件的序列化顺序信息
        private int index = 0;
        private String format;          //文件恢复后的格式    
        /// <summary>
        /// 有参的构造方法
        /// </summary>
        /// <param name="fileCount">文件信息的个数</param>
        public HeadFile(int fileCount)
        {
            fileInfoList = new Info[fileCount];
        }

        public string Format { get => format; set => format = value; }
        /// <summary>
        /// 添加一条数据信息到头文件中
        /// </summary>
        /// <param name="fileInfo">数据信息</param>
        public void AddFileInfo(Info fileInfo)
        {
            fileInfoList[index++] = fileInfo;
        }
        /// <summary>
        /// 取得全部数据信息
        /// </summary>
        /// <returns>数据信息数组</returns>
        public Info[] GetFileInfo()
        {
            return fileInfoList;
        }
    }
}
