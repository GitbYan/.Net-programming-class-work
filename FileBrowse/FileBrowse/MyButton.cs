using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace FileBrowse
{
    public enum MyFormat { BIG, DETAIL };
    public class MyButton:Button
    {
        public FileInfo fileInfo;
        public DirectoryInfo directoryInfo;
        

        public MyButton(FileInfo fileInfo, MyFormat myFormat)
        {
            this.fileInfo = fileInfo;
            classic(fileInfo.Name);
            BackColor = System.Drawing.Color.Red;
            this.Click += new EventHandler(FileInfo_Click);
        }

        public MyButton(DirectoryInfo directoryInfo, MyFormat myFormat)
        {
            this.directoryInfo = directoryInfo;
            classic(directoryInfo.Name);
            BackColor = System.Drawing.Color.Yellow;
            this.Click += new EventHandler(DirectoryInfo_Click);
        }

        public void classic(string name)
        {
            Size = new System.Drawing.Size(88, 78);
            Text = name;
            TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            UseVisualStyleBackColor = false;            
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }

        private void FileInfo_Click(object sender, EventArgs e)
        {
            try
            {
                switch (fileInfo.Extension)
                {
                    case ".txt":
                        Process.Start("notepad.exe", fileInfo.FullName);
                        break;
                    case ".exe":
                        Console.WriteLine("3");
                        Process MyProcess = new Process();
                        MyProcess.StartInfo.FileName = fileInfo.FullName;//外部程序路径
                        MyProcess.StartInfo.Verb = "Open";
                        MyProcess.StartInfo.CreateNoWindow = true;
                        MyProcess.Start();
                        break;
                }
            }
            catch(Exception ce)
            {
                Console.WriteLine("无法打开文件，错误：" + ce.Message);
            }
        }

        private void DirectoryInfo_Click(object sender, EventArgs e)
        {
            try
            {
                FileBrowse.lastDirPath = FileBrowse.DirPath;
                FileBrowse.DirPath = directoryInfo.FullName;
                FileBrowse.fileBrowse.show(MyFormat.BIG);
            }
            catch (Exception ce)
            {
                Console.WriteLine("无法打开文件夹，错误：" + ce.Message);
            }
        }
    }
}
