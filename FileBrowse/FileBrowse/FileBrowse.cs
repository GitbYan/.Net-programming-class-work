using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace FileBrowse
{
    public partial class FileBrowse : Form
    {

        /// <summary>
        /// 无边框窗体边界阴影效果
        /// </summary>
        /// <param name="nLeftRect"></param>
        /// <param name="nTopRect"></param>
        /// <param name="nRightRect"></param>
        /// <param name="nBottomRect"></param>
        /// <param name="nWidthEllipse"></param>
        /// <param name="nHeightEllipse"></param>
        /// <returns></returns>
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        private bool m_aeroEnabled;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;
        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION_Shadow = 0x2;
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {

                case WM_NCPAINT:                        // box shadow
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
                m.Result = (IntPtr)HTCAPTION_Shadow;
        }

        /// <summary>
        /// 无边框窗体拖动事件
        /// </summary>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION_Move = 0x0002;
        private void FormMenuStrip_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION_Move, 0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// 


        public static FileBrowse fileBrowse;
        public static string DirPath = @"C:/";
        public static string lastDirPath = @"C:/";
        public MyFormat myFormat = MyFormat.BIG;

        public FileBrowse()
        {
            InitializeComponent();
            fileBrowse = this;

            //Console.WriteLine(directoryInfo.CreationTime);
            //Console.WriteLine(directoryInfo.LastAccessTime);
            //Console.WriteLine(directoryInfo.Parent);
            //Console.WriteLine(directoryInfo.Root);
            show(myFormat);



        }

        public void show(MyFormat myFormat)
        {            
            地址导航ToolStripMenuItem.Text = DirPath;
            flp_List.Controls.Clear();
            DirectoryInfo directoryInfo = new DirectoryInfo(DirPath);
            foreach (object o in directoryInfo.GetFileSystemInfos())
            {
                
                if (o is DirectoryInfo)
                {
                    DirectoryInfo _directoryInfo = (DirectoryInfo)o;
                    if ((_directoryInfo.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                    {
                        continue;
                    }
                    MyButton myButton = new MyButton(_directoryInfo, myFormat);
                    flp_List.Controls.Add(myButton);
                }
                else if(o is FileInfo)
                {
                    FileInfo _fileInfo = (FileInfo)o;
                    if ((_fileInfo.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                    {
                        continue;
                    }
                    MyButton myButton = new MyButton(_fileInfo, myFormat);
                    flp_List.Controls.Add(myButton);
                }
            }
            flp_List.Show();
            lbl_TotalItems.Text = flp_List.Controls.Count + "个项目";
        }



        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 图标ToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 最大化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width,
        Screen.PrimaryScreen.WorkingArea.Height);
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
            this.Refresh();
        }

        private void 最小化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menuTree_Click(object sender, EventArgs e)
        {
            foreach(object o in flp_Tree.Controls)
            {
                if(o is Button)
                {
                    Button bo = (Button)o;
                    bo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                }
            }
            Button b = (Button)sender;
            b.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        }

        private bool mycomputer_spread = false;
        private void btn_myComputer_Click(object sender, EventArgs e)
        {
            if (!mycomputer_spread)
            {
                btn_myComputer.Text = "<此电脑";
                string mycomputer = @"C:/";
                DirectoryInfo directoryInfo = new DirectoryInfo(mycomputer);
                MyControl myControl = new MyControl(directoryInfo, 0);
                flp_Tree.Controls.Add(myControl.flp_branch);
                mycomputer_spread = !mycomputer_spread;
            }
            else
            {
                btn_myComputer.Text = ">此电脑";
                flp_Tree.Controls.Clear();
                flp_Tree.Controls.Add(btn_quickAccess);
                flp_Tree.Controls.Add(btn_myComputer);
                mycomputer_spread = !mycomputer_spread;
            }

        }



        private void 向上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lastDirPath = DirPath;
                DirectoryInfo directoryInfo = new DirectoryInfo(DirPath);
                if (directoryInfo.Parent != null)
                {
                    DirPath = new DirectoryInfo(DirPath).Parent.FullName;
                    show(myFormat);
                }
            }
            catch (Exception ce)
            {
                Console.WriteLine(ce.Message);
            }
        }

        private void 后退ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = lastDirPath;
            lastDirPath = DirPath;
            DirPath = path;
            show(myFormat);
        }

        private void 大图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show(MyFormat.BIG);
        }

        private void 详细信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show(MyFormat.DETAIL);
        }
    }
}
