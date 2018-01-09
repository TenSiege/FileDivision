using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 文件的属性
/// </summary>
namespace FileDivision
{
    [Serializable]
    class Info
    {
        private String fileName;    //文件名字
        private long fileSize;      //文件的大小

        public Info(string fileName, long fileSize)
        {
            FileName = fileName;
            FileSize = fileSize;
        }

        public Info(){}
        public string FileName { get => fileName; set => fileName = value; }
        public long FileSize { get => fileSize; set => fileSize = value; }
    }
}
