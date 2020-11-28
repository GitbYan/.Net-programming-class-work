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
    public partial class ModifyStudent : Form
    {
        public static Student student;

        public bool flag = false;
        public ModifyStudent()
        {
            InitializeComponent();
            student = null;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.DataSource = StuManageSys.myDataBase.SearchSchool();
            if (comboBox1.DataSource == null)
            {
                MessageBox.Show("暂无班级信息，无法添加学生");
                flag = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag)
                {
                    this.Close();
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.SelectedIndex != -1)
                {
                    student = new Student(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("请填写完整信息");
                }
            }
            catch (Exception ce)
            {
                Console.WriteLine(ce.Message);
            }
        }
    }
}
