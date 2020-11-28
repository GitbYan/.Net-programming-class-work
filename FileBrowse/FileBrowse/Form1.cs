using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileBrowse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Text = "" + i++;
            flowLayoutPanel1.Controls.Add(button);
            flowLayoutPanel1.Controls.SetChildIndex(button, 0);
        }
    }
}
