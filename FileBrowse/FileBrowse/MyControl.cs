using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace FileBrowse
{
    public class MyControl
    {
        public FlowLayoutPanel flp_branch = new FlowLayoutPanel();

        public DirectoryInfo directoryInfo;

        public int levelIndex;
        public string head = "";

        public bool[] clicked = new bool[] { false };

        public MyControl(DirectoryInfo directoryInfo, int levelIndex)
        {
            this.levelIndex = levelIndex + 2;
            for(int i = 0; i < this.levelIndex; i++)
            {
                head += "  ";
            }
            this.directoryInfo = directoryInfo;
            Console.WriteLine(directoryInfo);
            classic();
        }

        public void classic()
        {
            flp_branch.AutoScroll = false;
            flp_branch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            flp_branch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            flp_branch.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            
            int newindex = 0;
            foreach(DirectoryInfo _directoryInfo in directoryInfo.GetDirectories())
            {
                if ((_directoryInfo.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                    continue;
                }
                bool spreadAble = false;
                foreach (DirectoryInfo __directoryInfo in _directoryInfo.GetDirectories())
                {
                    if ((__directoryInfo.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                    {
                        continue;
                    }
                    else
                    {
                        spreadAble = true;
                    }
                }
                Button button = new Button();
                button.TabIndex = newindex;
                button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
                button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                button.Cursor = System.Windows.Forms.Cursors.Hand;
                button.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
                button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                button.Location = new System.Drawing.Point(0, 0);
                button.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
                button.Size = new System.Drawing.Size(180, 29);
                button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                button.UseVisualStyleBackColor = false;
                button.Click += new System.EventHandler(button_Click);
                button.Name = _directoryInfo.Name;
                if (spreadAble)
                {
                    button.Text = head + ">" + _directoryInfo.Name;
                }
                else
                {
                    button.Text = head + "  " + _directoryInfo.Name;
                }
                flp_branch.Controls.Add(button);
                flp_branch.Controls.SetChildIndex(button, newindex);
                newindex++;
                clicked = new bool[newindex];
                for(int i = 0; i < newindex; i++)
                {
                    clicked[i] = false;
                }
            }
            flp_branch.Size = new System.Drawing.Size(180, newindex * 29);
        }
        
        private void button_Click(object sender,EventArgs e)
        {
            try
            {
                Button button = (Button)sender;
                DirectoryInfo _directoryInfo = new DirectoryInfo(directoryInfo + "/" + button.Name);
                ControlCollection controls = button.Parent.Controls;
                if(button.Text == head + "  " + button.Name) { }               
                else if (!clicked[button.TabIndex])
                {
                    foreach (Control control in controls)
                    {
                        if (control is FlowLayoutPanel)
                        {
                            button.Parent.Controls.Remove(control);
                        }
                    }
                    button.Text = head + "<" + button.Name;
                    clicked[button.TabIndex] = !clicked[button.TabIndex];
                    FlowLayoutPanel flowLayoutPanel = spread(_directoryInfo, button);
                    button.Parent.Controls.Add(flowLayoutPanel);
                    button.Parent.Controls.SetChildIndex(flowLayoutPanel, button.Parent.Controls.IndexOf(button) + 1);
                    addHeight(button.Parent, flowLayoutPanel.Height);
                }
                else if (clicked[button.TabIndex])
                {
                    button.Text = head + ">" + button.Name;
                    clicked[button.TabIndex] = !clicked[button.TabIndex];
                    foreach(Control control in controls)
                    {
                        if(control is FlowLayoutPanel)
                        {
                            button.Parent.Controls.Remove(control);
                            cutHeight(button.Parent, control.Height);
                        }
                    }
                }
                FileBrowse.lastDirPath = FileBrowse.DirPath;
                FileBrowse.DirPath = directoryInfo + "/" + button.Name;
                FileBrowse.fileBrowse.show(MyFormat.BIG);
            }
            catch(Exception ce)
            {
                Console.WriteLine(ce.Message);
            }
        }

        public void addHeight(Control control, int height)
        {
            if(control is FlowLayoutPanel)
            {
                FlowLayoutPanel flowLayoutPanel = (FlowLayoutPanel)control;
                if(flowLayoutPanel.Name != "flp_Tree")
                {
                    addHeight(flowLayoutPanel.Parent, height);
                    flowLayoutPanel.Height += height;
                }
            }
        }

        public void cutHeight(Control control, int height)
        {
            if (control is FlowLayoutPanel)
            {
                FlowLayoutPanel flowLayoutPanel = (FlowLayoutPanel)control;
                if (flowLayoutPanel.Name != "flp_Tree")
                {
                    addHeight(flowLayoutPanel.Parent, height);
                    flowLayoutPanel.Height -= height;
                }
            }
        }

        private FlowLayoutPanel spread(DirectoryInfo _directoryInfo, object sender)
        {
            try
            {
                MyControl myControl = new MyControl(_directoryInfo,levelIndex);
                return (myControl.flp_branch);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
