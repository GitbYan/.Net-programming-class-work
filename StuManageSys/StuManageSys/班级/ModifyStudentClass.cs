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
    public partial class ModifyStudentClass : Form
    {
        public static StudentClass studentClass;

        public bool flag = false;

        public ModifyStudentClass()
        {
            InitializeComponent();
            comboBox2.DataSource = StuManageSys.myDataBase.SearchSchool();
            if (comboBox2.DataSource == null)
            {
                MessageBox.Show("暂无学校信息");
                flag = true;
            }
            studentClass = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag)
                {
                    this.Close();
                }
                else if (comboBox2.SelectedIndex != -1 && textBox2.Text != "" && textBox3.Text != "" && comboBox1.SelectedIndex != -1)
                {
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                            studentClass = new StudentClass(comboBox2.Text, textBox2.Text, "英语");

                            break;
                        case 1:
                            studentClass = new StudentClass(comboBox2.Text, textBox2.Text, "数学");

                            break;
                        case 2:
                            studentClass = new StudentClass(comboBox2.Text, textBox2.Text, "物理");

                            break;
                    }
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
