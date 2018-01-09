namespace FileDivision
{
    partial class MianFrom
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFile = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.lblFileOutURL = new System.Windows.Forms.Label();
            this.txtFileOutURL = new System.Windows.Forms.TextBox();
            this.prgSchedule = new System.Windows.Forms.ProgressBar();
            this.tab = new System.Windows.Forms.TabControl();
            this.FileDivision = new System.Windows.Forms.TabPage();
            this.nudFileSize = new System.Windows.Forms.NumericUpDown();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnSelectOutULR = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblUnit = new System.Windows.Forms.Label();
            this.fileAdd = new System.Windows.Forms.TabPage();
            this.btnStopMerge = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.lblFolder = new System.Windows.Forms.Label();
            this.btnFileURL = new System.Windows.Forms.Button();
            this.btnHeadFile = new System.Windows.Forms.Button();
            this.txtFileURL = new System.Windows.Forms.TextBox();
            this.txtHeadFile = new System.Windows.Forms.TextBox();
            this.lblFileURL = new System.Windows.Forms.Label();
            this.lvwFileInfo = new System.Windows.Forms.ListView();
            this.FileInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab.SuspendLayout();
            this.FileDivision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFileSize)).BeginInit();
            this.fileAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFile.Location = new System.Drawing.Point(113, 28);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(73, 21);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "文件：";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(192, 24);
            this.txtFile.MaxLength = 100;
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(304, 28);
            this.txtFile.TabIndex = 1;
            // 
            // lblFileOutURL
            // 
            this.lblFileOutURL.AutoSize = true;
            this.lblFileOutURL.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFileOutURL.Location = new System.Drawing.Point(29, 127);
            this.lblFileOutURL.Name = "lblFileOutURL";
            this.lblFileOutURL.Size = new System.Drawing.Size(157, 21);
            this.lblFileOutURL.TabIndex = 4;
            this.lblFileOutURL.Text = "文件输出路径：";
            // 
            // txtFileOutURL
            // 
            this.txtFileOutURL.Location = new System.Drawing.Point(192, 123);
            this.txtFileOutURL.Name = "txtFileOutURL";
            this.txtFileOutURL.ReadOnly = true;
            this.txtFileOutURL.Size = new System.Drawing.Size(304, 28);
            this.txtFileOutURL.TabIndex = 5;
            // 
            // prgSchedule
            // 
            this.prgSchedule.Location = new System.Drawing.Point(12, 276);
            this.prgSchedule.Name = "prgSchedule";
            this.prgSchedule.Size = new System.Drawing.Size(609, 23);
            this.prgSchedule.TabIndex = 8;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.FileDivision);
            this.tab.Controls.Add(this.fileAdd);
            this.tab.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(633, 270);
            this.tab.TabIndex = 9;
            // 
            // FileDivision
            // 
            this.FileDivision.Controls.Add(this.nudFileSize);
            this.FileDivision.Controls.Add(this.cmbUnit);
            this.FileDivision.Controls.Add(this.btnSelectFile);
            this.FileDivision.Controls.Add(this.btnSelectOutULR);
            this.FileDivision.Controls.Add(this.btnStop);
            this.FileDivision.Controls.Add(this.btnStart);
            this.FileDivision.Controls.Add(this.lblFile);
            this.FileDivision.Controls.Add(this.txtFile);
            this.FileDivision.Controls.Add(this.lblUnit);
            this.FileDivision.Controls.Add(this.txtFileOutURL);
            this.FileDivision.Controls.Add(this.lblFileOutURL);
            this.FileDivision.Location = new System.Drawing.Point(4, 28);
            this.FileDivision.Name = "FileDivision";
            this.FileDivision.Padding = new System.Windows.Forms.Padding(3);
            this.FileDivision.Size = new System.Drawing.Size(625, 238);
            this.FileDivision.TabIndex = 0;
            this.FileDivision.Text = "文件分割";
            this.FileDivision.UseVisualStyleBackColor = true;
            // 
            // nudFileSize
            // 
            this.nudFileSize.Location = new System.Drawing.Point(192, 78);
            this.nudFileSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFileSize.Name = "nudFileSize";
            this.nudFileSize.Size = new System.Drawing.Size(251, 28);
            this.nudFileSize.TabIndex = 16;
            this.nudFileSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbUnit
            // 
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "MB",
            "GB"});
            this.cmbUnit.Location = new System.Drawing.Point(449, 79);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(149, 26);
            this.cmbUnit.TabIndex = 15;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(499, 22);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(99, 33);
            this.btnSelectFile.TabIndex = 14;
            this.btnSelectFile.Text = "选择文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // btnSelectOutULR
            // 
            this.btnSelectOutULR.Location = new System.Drawing.Point(499, 122);
            this.btnSelectOutULR.Name = "btnSelectOutULR";
            this.btnSelectOutULR.Size = new System.Drawing.Size(99, 31);
            this.btnSelectOutULR.TabIndex = 13;
            this.btnSelectOutULR.Text = "选择路径";
            this.btnSelectOutULR.UseVisualStyleBackColor = true;
            this.btnSelectOutULR.Click += new System.EventHandler(this.BtnSelectOutULR_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(337, 182);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(123, 33);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "终止分割";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(124, 182);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 33);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "开始分割";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUnit.Location = new System.Drawing.Point(29, 82);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(157, 21);
            this.lblUnit.TabIndex = 2;
            this.lblUnit.Text = "分割大小单位：";
            // 
            // fileAdd
            // 
            this.fileAdd.Controls.Add(this.btnStopMerge);
            this.fileAdd.Controls.Add(this.btnMerge);
            this.fileAdd.Controls.Add(this.lblFolder);
            this.fileAdd.Controls.Add(this.btnFileURL);
            this.fileAdd.Controls.Add(this.btnHeadFile);
            this.fileAdd.Controls.Add(this.txtFileURL);
            this.fileAdd.Controls.Add(this.txtHeadFile);
            this.fileAdd.Controls.Add(this.lblFileURL);
            this.fileAdd.Location = new System.Drawing.Point(4, 28);
            this.fileAdd.Name = "fileAdd";
            this.fileAdd.Padding = new System.Windows.Forms.Padding(3);
            this.fileAdd.Size = new System.Drawing.Size(625, 238);
            this.fileAdd.TabIndex = 1;
            this.fileAdd.Text = "文件合并";
            this.fileAdd.UseVisualStyleBackColor = true;
            // 
            // btnStopMerge
            // 
            this.btnStopMerge.Location = new System.Drawing.Point(334, 184);
            this.btnStopMerge.Name = "btnStopMerge";
            this.btnStopMerge.Size = new System.Drawing.Size(123, 33);
            this.btnStopMerge.TabIndex = 13;
            this.btnStopMerge.Text = "终止合并";
            this.btnStopMerge.UseVisualStyleBackColor = true;
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(121, 184);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(108, 33);
            this.btnMerge.TabIndex = 12;
            this.btnMerge.Text = "开始合并";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(93, 15);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(251, 18);
            this.lblFolder.TabIndex = 6;
            this.lblFolder.Text = "请选择以.head为后缀的头文件";
            // 
            // btnFileURL
            // 
            this.btnFileURL.Location = new System.Drawing.Point(363, 132);
            this.btnFileURL.Name = "btnFileURL";
            this.btnFileURL.Size = new System.Drawing.Size(112, 33);
            this.btnFileURL.TabIndex = 5;
            this.btnFileURL.Text = "选则文件夹";
            this.btnFileURL.UseVisualStyleBackColor = true;
            this.btnFileURL.Click += new System.EventHandler(this.btnFileURL_Click);
            // 
            // btnHeadFile
            // 
            this.btnHeadFile.Location = new System.Drawing.Point(363, 47);
            this.btnHeadFile.Name = "btnHeadFile";
            this.btnHeadFile.Size = new System.Drawing.Size(112, 34);
            this.btnHeadFile.TabIndex = 4;
            this.btnHeadFile.Text = "选择头文件";
            this.btnHeadFile.UseVisualStyleBackColor = true;
            this.btnHeadFile.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // txtFileURL
            // 
            this.txtFileURL.Location = new System.Drawing.Point(96, 136);
            this.txtFileURL.Name = "txtFileURL";
            this.txtFileURL.ReadOnly = true;
            this.txtFileURL.Size = new System.Drawing.Size(244, 28);
            this.txtFileURL.TabIndex = 3;
            // 
            // txtHeadFile
            // 
            this.txtHeadFile.Location = new System.Drawing.Point(96, 52);
            this.txtHeadFile.Name = "txtHeadFile";
            this.txtHeadFile.ReadOnly = true;
            this.txtHeadFile.Size = new System.Drawing.Size(244, 28);
            this.txtHeadFile.TabIndex = 2;
            // 
            // lblFileURL
            // 
            this.lblFileURL.AutoSize = true;
            this.lblFileURL.Location = new System.Drawing.Point(93, 99);
            this.lblFileURL.Name = "lblFileURL";
            this.lblFileURL.Size = new System.Drawing.Size(242, 18);
            this.lblFileURL.TabIndex = 1;
            this.lblFileURL.Text = "请选择文件合并后存放的位置";
            // 
            // lvwFileInfo
            // 
            this.lvwFileInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvwFileInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileInfo});
            this.lvwFileInfo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvwFileInfo.FullRowSelect = true;
            this.lvwFileInfo.GridLines = true;
            this.lvwFileInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvwFileInfo.Location = new System.Drawing.Point(12, 305);
            this.lvwFileInfo.Name = "lvwFileInfo";
            this.lvwFileInfo.Size = new System.Drawing.Size(609, 283);
            this.lvwFileInfo.TabIndex = 9;
            this.lvwFileInfo.UseCompatibleStateImageBehavior = false;
            this.lvwFileInfo.View = System.Windows.Forms.View.Details;
            // 
            // FileInfo
            // 
            this.FileInfo.Text = "详细信息";
            this.FileInfo.Width = 517;
            // 
            // MianFrom
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 600);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.lvwFileInfo);
            this.Controls.Add(this.prgSchedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MianFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileDivsion";
            this.Load += new System.EventHandler(this.MianFrom_Load);
            this.tab.ResumeLayout(false);
            this.FileDivision.ResumeLayout(false);
            this.FileDivision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFileSize)).EndInit();
            this.fileAdd.ResumeLayout(false);
            this.fileAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label lblFileOutURL;
        private System.Windows.Forms.TextBox txtFileOutURL;
        private System.Windows.Forms.ProgressBar prgSchedule;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage FileDivision;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListView lvwFileInfo;
        private System.Windows.Forms.TabPage fileAdd;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnSelectOutULR;
        private System.Windows.Forms.NumericUpDown nudFileSize;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ColumnHeader FileInfo;
        private System.Windows.Forms.Button btnFileURL;
        private System.Windows.Forms.Button btnHeadFile;
        private System.Windows.Forms.TextBox txtFileURL;
        private System.Windows.Forms.TextBox txtHeadFile;
        private System.Windows.Forms.Label lblFileURL;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Button btnStopMerge;
        private System.Windows.Forms.Button btnMerge;
    }
}

