using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuManageSys
{
    public partial class AddSchool : Form
    {
        public static School school;
        public AddSchool()
        {
            InitializeComponent();
            school = null;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    school = new School(textBox1.Text, textBox2.Text, textBox3.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("请填写完整信息");
                }
            }catch(Exception ce)
            {
                Console.WriteLine(ce.Message);
            }

        }


    }
}
