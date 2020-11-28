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
    public partial class StuManageSys : Form
    {
        public static MyDataBase myDataBase;
        public StuManageSys()
        {
            InitializeComponent();
            myDataBase = new MyDataBase();
        }
        

        private void Btn_addSchool_Click(object sender, EventArgs e)
        {
            AddSchool addSchool = new AddSchool();
            addSchool.ShowDialog();
            if (AddSchool.school != null)
            {
                if (myDataBase.Add(AddSchool.school))
                {
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
        }

        private void Btn_deleteSchool_Click(object sender, EventArgs e)
        {
            DeleteSchool deleteSchool = new DeleteSchool();
            deleteSchool.ShowDialog();
            if (DeleteSchool.school != null)
            {
                myDataBase.Operationflag = false;
                if (myDataBase.Search(DeleteSchool.school) != null)
                {
                    myDataBase.Operationflag = true;

                    myDataBase.Delete(DeleteSchool.school);
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("学校不存在");
                }
            }
        }

        private void Btn_modifySchool_Click(object sender, EventArgs e)
        {
            ModifySchool modifySchool = new ModifySchool();
            modifySchool.ShowDialog();
            if (ModifySchool.school != null)
            {
                myDataBase.Operationflag = false;
                if (myDataBase.Search(ModifySchool.school) != null)
                {
                    myDataBase.Operationflag = true;

                    myDataBase.Modify(ModifySchool.school);
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("学校不存在");
                }
            }
        }

        private void Btn_searchSchool_Click(object sender, EventArgs e)
        {
            SearchSchool searchSchool = new SearchSchool();
            searchSchool.ShowDialog();
            if (SearchSchool.school != null)
            {
                School school = myDataBase.Search(SearchSchool.school);
                if (school == null)
                {
                    MessageBox.Show("没有查到相关学校");
                }
                else
                {
                    MessageBox.Show("学校名称：" + school.Name + "  学校建校年：" + school.Year + "  学校地址：" + school.Address);
                }
            }
        }

        private void Btn_addClass_Click(object sender, EventArgs e)
        {
            AddStudentClass addStudentClass = new AddStudentClass();
            addStudentClass.ShowDialog();
            if (AddStudentClass.studentClass != null)
            {
                if (myDataBase.Add(AddStudentClass.studentClass))
                {
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
        }

        private void Btn_deleteClass_Click(object sender, EventArgs e)
        {
            DeleteStudentClass deleteStudentClass = new DeleteStudentClass();
            deleteStudentClass.ShowDialog();
            if (DeleteStudentClass.studentClass != null)
            {
                myDataBase.Operationflag = false;
                if (myDataBase.Search(DeleteStudentClass.studentClass) != null)
                {
                    myDataBase.Operationflag = true;

                    myDataBase.Delete(DeleteStudentClass.studentClass);
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("班级不存在");
                }
            }
        }

        private void Btn_modifyClass_Click(object sender, EventArgs e)
        {
            ModifyStudentClass modifyStudentClass = new ModifyStudentClass();
            modifyStudentClass.ShowDialog();
            if (ModifyStudentClass.studentClass != null)
            {
                myDataBase.Operationflag = false;
                if (myDataBase.Search(ModifyStudentClass.studentClass) != null)
                {
                    myDataBase.Operationflag = true;

                    myDataBase.Modify(ModifyStudentClass.studentClass);
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("班级不存在");
                }
            }
        }

        private void Btn_searchClass_Click(object sender, EventArgs e)
        {
            SearchStudentClass searchStudentClass = new SearchStudentClass();
            searchStudentClass.ShowDialog();
            if (SearchStudentClass.studentClass != null)
            {
                StudentClass studentClass = myDataBase.Search(SearchStudentClass.studentClass);
                if (studentClass == null)
                {
                    MessageBox.Show("没有查到相关班级");
                }
                else
                {
                    MessageBox.Show("班级名称：" + studentClass.Name + "  班级年级：" + studentClass.Year + "  班级专业：" + studentClass.Major);
                }
            }
        }

        private void Btn_addStudent_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
            if (AddStudent.student != null)
            {
                if (myDataBase.Add(AddStudent.student))
                {
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
        }

        private void Btn_deleteStudent_Click(object sender, EventArgs e)
        {
            DeleteStudent deleteStudent = new DeleteStudent();
            deleteStudent.ShowDialog();
            if (DeleteStudent.student != null)
            {
                myDataBase.Operationflag = false;
                if (myDataBase.Search(DeleteStudent.student) != null)
                {
                    myDataBase.Operationflag = true;

                    myDataBase.Delete(DeleteStudent.student);
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("学生不存在");
                }
            }
        }

        private void Btn_modifyStudent_Click(object sender, EventArgs e)
        {
            ModifyStudent modifyStudent = new ModifyStudent();
            modifyStudent.ShowDialog();
            if (ModifyStudent.student != null)
            {
                myDataBase.Operationflag = false;
                if (myDataBase.Search(ModifyStudent.student) != null)
                {
                    myDataBase.Operationflag = true;

                    myDataBase.Modify(ModifyStudent.student);
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("学生不存在");
                }
            }
        }

        private void Btn_searchStudent_Click(object sender, EventArgs e)
        {
            SearchStudent searchStudent = new SearchStudent();
            searchStudent.ShowDialog();
            if (SearchStudent.student != null)
            {
                Student student = myDataBase.Search(SearchStudent.student);
                if (student == null)
                {
                    MessageBox.Show("没有查到学生");
                }
                else
                {
                    MessageBox.Show("学生姓名：" + student.Name + "  年级：" + student.Year + "        班级：" + student.StuClass);
                }
            }
        }

        private void Btn_searchLog_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                Log log = new Log(textBox.Text);
                listBox.Items.Clear();
                if (myDataBase.Search(log) != null)
                {
                    foreach (string str in myDataBase.Search(log))
                    {
                        listBox.BeginUpdate();
                        if (!string.IsNullOrEmpty(str))
                        {
                            listBox.Items.Add(str);
                        }
                        listBox.EndUpdate();
                        listBox.SelectedIndex = listBox.Items.Count - 1;
                    }
                }
            }

        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            if (myDataBase.SearchLog() != null)
            {
                listBox.Items.Clear();
                foreach (string str in myDataBase.SearchLog())
                {
                    listBox.BeginUpdate();
                    if (!string.IsNullOrEmpty(str))
                    {
                        listBox.Items.Add(str);
                    }
                    listBox.EndUpdate();
                    listBox.SelectedIndex = listBox.Items.Count - 1;
                }
            }
        }
    }
}
