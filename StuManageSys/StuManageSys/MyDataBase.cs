using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Text.RegularExpressions;

namespace StuManageSys
{
    public class MyDataBase
    {

        SQLiteConnection mdb_SQLiteConnection;

        public MyDataBase()
        {
            CreateDatabase();
            try
            {
                mdb_SQLiteConnection = new SQLiteConnection("Data Source = MyDataBase.sqlite;version=3");
                CreateTable_School();
                CreateTable_Student();
                CreateTable_StudentClass();
                CreateTable_Log();
            }
            catch(Exception e)
            {
                Console.WriteLine("连接数据库失败：" + e.Message);
            }
        }

        public void CreateDatabase()
        {
            try
            {                
                SQLiteConnection.CreateFile("MyDataBase.sqlite");
            }catch(Exception e)
            {
                Console.WriteLine("建库失败:" + e.Message);
            }
        }
        
        public void CreateTable_School()
        {
            try
            {
                mdb_SQLiteConnection.Open();
                string sql = "create table if not exists school (name varchar(20) primary key, year varchar(20), address varchar(20))";
                SQLiteCommand command = new SQLiteCommand(sql, mdb_SQLiteConnection);
                command.ExecuteNonQuery();
                mdb_SQLiteConnection.Close();
            }catch(Exception e)
            {
                Console.WriteLine("创建表失败：" + e.Message);
            }
        }

        public void CreateTable_Student()
        {
            try
            {
                mdb_SQLiteConnection.Open();
                string sql = "create table if not exists student (name varchar(20) primary key, sex varchar(4), year varchar(20), stuclass varchar(20))";
                SQLiteCommand command = new SQLiteCommand(sql, mdb_SQLiteConnection);
                command.ExecuteNonQuery();
                mdb_SQLiteConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("创建表失败：" + e.Message);
            }
        }

        public void CreateTable_StudentClass()
        {
            try
            {
                mdb_SQLiteConnection.Open();
                string sql = "create table if not exists studentclass (name varchar(20) primary key, year varchar(20), major varchar(20), schoolname varchar(20))";
                SQLiteCommand command = new SQLiteCommand(sql, mdb_SQLiteConnection);
                command.ExecuteNonQuery();
                mdb_SQLiteConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("创建表失败：" + e.Message);
            }
        }

        public void CreateTable_Log()
        {
            try
            {
                mdb_SQLiteConnection.Open();
                string sql = "create table if not exists log (datetime varchar(20), operation varchar(200))";
                SQLiteCommand command = new SQLiteCommand(sql, mdb_SQLiteConnection);
                command.ExecuteNonQuery();
                mdb_SQLiteConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("创建表失败：" + e.Message);
            }
        }

        public bool Add(School school)
        {
            try
            {
                mdb_SQLiteConnection.Open();
                string sql = "insert into school (name, year, address) values ('"+school.Name+"', '"+school.Year+"', '"+school.Address+"')";
                SQLiteCommand command = new SQLiteCommand(sql, mdb_SQLiteConnection);
                command.ExecuteNonQuery();
                mdb_SQLiteConnection.Close();
                Console.WriteLine("添加数据成功");

                Log log = new Log("添加学校信息");
                Add(log);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine("添加数据失败" + e.Message);
                return false;
            }
        }

        public void Delete(School school)
        {
            try
            {
                mdb_SQLiteConnection.Open();
                string sql = "delete from school where name='"+school.Name+"'";
                SQLiteCommand command = new SQLiteCommand(sql, mdb_SQLiteConnection);
                command.ExecuteNonQuery();
                mdb_SQLiteConnection.Close();
                Console.WriteLine("删除数据成功");

                Log log = new Log("删除学校信息");
                Add(log);
            }
            catch (Exception e)
            {
                Console.WriteLine("删除数据失败" + e.Message);
            }

        }

        public void Modify(School school)
        {
            try
            {
                mdb_SQLiteConnection.Open();
                string sql = "replace into school (name,year,address) values ('" + school.Name + "', '" + school.Year + "', '" + school.Address + "')";
                SQLiteCommand command = new SQLiteCommand(sql, mdb_SQLiteConnection);
                command.ExecuteNonQuery();
                mdb_SQLiteConnection.Close();
                Console.WriteLine("更新数据成功");

                Log log = new Log("更新学校信息");
                Add(log);
            }
            catch (Exception e)
            {
                Console.WriteLine("更新数据失败" + e.Message);
            }

        }

        public School Search(School school)
        {
            try
            {
                mdb_SQLiteConnection.Open();
                string sql = "select * from school where name='" + school.Name + "'";
                SQLiteCommand command = new SQLiteCommand(sql, mdb_SQLiteConnection);
                SQLiteDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0) + reader.GetString(1) + reader.GetString(2));
                        school = new School(school.Name, reader["year"].ToString(), reader["address"].ToString());
                        Console.WriteLine("查询数据成功");
                    }
                }
                else
                {
                    Console.WriteLine("没有找到学校");
                    school = null;
                }
                reader.Close();
                mdb_SQLiteConnection.Close();

                Log log = new Log("查询学校信息");
                Add(log);
                return school;
            }
            catch (Exception e)
            {
                Console.WriteLine("查询数据失败" + e.Message);
                return null;
            }
        }

        public bool Add(Student student)
        {
            try
            {
                mdb_SQLiteConnection.Open();
                string sql = "insert into student (name, sex, year, stuclass) values ('" + student.Name + "', '" + student.Sex + "', '" + student.Year + "', '" + student.StuClass + "')";
                SQLiteCommand command = new SQLiteCommand(sql, mdb_SQLiteConnection);
                command.ExecuteNonQuery();
                mdb_SQLiteConnection.Close();
                Console.WriteLine("添加数据成功");

                Log log = new Log("添加学生信息");
                Add(log);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("添加数据失败" + e.Message);
                return false;
            }
        }

        public void Delete(Student student)
        {
            try
            {
                mdb_SQLiteConnection.Open();
                string sql = "delete from student where name='" + student.Name + "'";
                SQLiteCommand command = new SQLiteCommand(sql, mdb_SQLiteConnection);
                command.ExecuteNonQuery();
                mdb_SQLiteConnection.Close();
                Console.WriteLine("删除数据成功");

                Log log = new Log("删除学生信息");
                Add(log);
            }
            catch (Exception e)
            {
                Console.WriteLine("删除数据失败" + e.Message);
            }
        }

        public void Modify(Student student)
        {
            try
            {
                mdb_SQLiteConnection.Open();
                string sql = "replace into student (name,sex,year,stuclass) values ('" + student.Name + "', '" + student.Sex + "', '" + student.Year + "', '" + student.StuClass + "')";
                SQLiteCommand command = new SQLiteCommand(sql, mdb_SQLiteConnection);
                command.ExecuteNonQuery();
                mdb_SQLiteConnection.Close();
                Console.WriteLine("更新数据成功");

                Log log = new Log("更新学生信息");
                Add(log);
            }
            catch (Exception e)
            {
                Console.WriteLine("更新数据失败" + e.Message);
            }
        }

        public Student Search(Student student)
        {
            try
            {
                mdb_SQLiteConnection.Open();
                string sql = "select * from student where name='" + student.Name + "'";
                SQLiteCommand command = new SQLiteCommand(sql, mdb_SQLiteConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0) + reader.GetString(1) + reader.GetString(2));
                        student = new Student(student.Name, reader["sex"].ToString(), reader["year"].ToString(), reader["stuclass"].ToString());
                        Console.WriteLine("查询数据成功");
                    }
                }
                else
                {
                    Console.WriteLine("没有找到学生");
                    student = null;
                }
                reader.Close();
                mdb_SQLiteConnection.Close();

                Log log = new Log("查询学生信息");
                Add(log);
                return student;
            }
            catch (Exception e)
            {
                Console.WriteLine("查询数据失败" + e.Message);
                return null;
            }
        }

        public bool Add(StudentClass studentclass)
        {
            try
            {
                mdb_SQLiteConnection.Open();
                string sql = "insert into studentclass  (name, year , major, schoolname) values ('" + studentclass.Name + "', '" + studentclass.Year + "', '" + studentclass.Major  +"', '"+ studentclass.SchoolName + "')";
                SQLiteCommand command = new SQLiteCommand(sql, mdb_SQLiteConnection);
                command.ExecuteNonQuery();
                mdb_SQLiteConnection.Close();
                Console.WriteLine("添加数据成功");

                Log log = new Log("添加班级信息");
                Add(log);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("添加数据失败" + e.Message);
                return false;
            }
        }

        public void Delete(StudentClass studentclass)
        {
            try
            {
                mdb_SQLiteConnection.Open();
                string sql = "delete from studentclass where name='" + studentclass.Name + "'";
                SQLiteCommand command = new SQLiteCommand(sql, mdb_SQLiteConnection);
                command.ExecuteNonQuery();
                mdb_SQLiteConnection.Close();
                Console.WriteLine("删除数据成功");
            
                Log log = new Log("添加班级信息");
                Add(log);
            }
            catch (Exception e)
            {
                Console.WriteLine("删除数据失败" + e.Message);
            }
        }

        public void Modify(StudentClass studentclass)
        {
            try
            {
                mdb_SQLiteConnection.Open();
                string sql = "update studentclass set name = '"+ (studentclass.Year + "级" + studentclass.Major + "班") + " ', year = '"+studentclass.Year + "',major='" +studentclass.Major+ "',schoolname='"+studentclass.SchoolName + "' where name = '"+studentclass.Name+"'";
                SQLiteCommand command = new SQLiteCommand(sql, mdb_SQLiteConnection);
                command.ExecuteNonQuery();
                mdb_SQLiteConnection.Close();
                Console.WriteLine("更新数据成功");

                Log log = new Log("添加班级信息");
                Add(log);
            }
            catch (Exception e)
            {
                Console.WriteLine("更新数据失败" + e.Message);
            }
        }

        public StudentClass Search(StudentClass studentclass)
        {
            try
            {
                mdb_SQLiteConnection.Open();
                string sql = "select * from studentclass where name='" + studentclass.Name + "'";
                SQLiteCommand command = new SQLiteCommand(sql, mdb_SQLiteConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0) + reader.GetString(1) + reader.GetString(2));
                        studentclass = new StudentClass(reader["schoolname"].ToString(), reader["year"].ToString(), reader["major"].ToString());
                        Console.WriteLine("查询数据成功");
                    }
                }
                else
                {
                    Console.WriteLine("没有找到班级");
                    studentclass = null;
                }
                reader.Close();
                mdb_SQLiteConnection.Close();

                Log log = new Log("查询班级信息");
                Add(log);
                return studentclass;
            }
            catch (Exception e)
            {
                Console.WriteLine("查询数据失败" + e.Message);
                return null;
            }
        }

        public bool Operationflag = true;
        public bool Add(Log log)
        {
            try
            {
                if (Operationflag)
                {
                    mdb_SQLiteConnection.Open();
                    string sql = "insert into log (datetime, operation) values ('" + log.datatime + "', '" + log.Operation + "')";
                    SQLiteCommand command = new SQLiteCommand(sql, mdb_SQLiteConnection);
                    command.ExecuteNonQuery();
                    mdb_SQLiteConnection.Close();
                    Console.WriteLine("添加记录成功");
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("添加记录失败" + e.Message);
                return false;
            }
        }

    
        public string[] Search(Log log)
        {
            string[] ss;
            try
            {
                mdb_SQLiteConnection.Open();
                string sql = "select * from log";
                SQLiteCommand command = new SQLiteCommand(sql, mdb_SQLiteConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                Regex regex = new Regex(log.Operation);
                if (reader.HasRows)
                {
                    ss = new string[reader.FieldCount];
                    int i = 0;
                    while (reader.Read())
                    {
                        if (regex.IsMatch(reader["operation"].ToString()))
                        {
                            string s = reader["datetime"].ToString() + "  " + reader["operation"].ToString();
                            ss[i] = s;
                            i++;
                        }
                        else if (regex.IsMatch(reader["datetime"].ToString()))
                        {
                            string s = reader["datetime"].ToString() + "  " + reader["operation"].ToString();
                            ss[i] = s;
                            i++;
                        }
                        Console.WriteLine("查询数据成功");
                    }
                }
                else
                {
                    Console.WriteLine("没有找到记录");
                    ss = null;
                }
                reader.Close();
                mdb_SQLiteConnection.Close();
                return ss;
            }
            catch (Exception e)
            {
                Console.WriteLine("查询数据失败" + e.Message);
                return null;
            }
        }

        public string[] SearchLog()
        {
            string[] ss;
            try
            {
                mdb_SQLiteConnection.Open();
                string sql = "select * from log";
                SQLiteCommand command = new SQLiteCommand(sql, mdb_SQLiteConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    ss = new string[reader.FieldCount];
                    int i = 0;
                    while (reader.Read())
                    {
                        string s = reader["datetime"].ToString() + "  " + reader["operation"].ToString();
                        ss[i] = s;
                        i++;
                        Console.WriteLine("查询数据成功");
                    }
                }
                else
                {
                    Console.WriteLine("没有找到记录");
                    ss = null;
                }
                reader.Close();
                mdb_SQLiteConnection.Close();
                return ss;
            }
            catch (Exception e)
            {
                Console.WriteLine("查询数据失败" + e.Message);
                return null;
            }
        }

        public string[] SearchSchool()
        {
            string[] ss;
            try
            {
                mdb_SQLiteConnection.Open();
                string sql = "select * from school";
                SQLiteCommand command = new SQLiteCommand(sql, mdb_SQLiteConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    ss = new string[reader.FieldCount];
                    int i = 0;
                    while (reader.Read())
                    {
                        string s = reader["name"].ToString();
                        ss[i] = s;
                        i++;
                        Console.WriteLine("查询数据成功");
                    }
                }
                else
                {
                    Console.WriteLine("没有找到记录");
                    ss = null;
                }
                reader.Close();
                mdb_SQLiteConnection.Close();
                return ss;
            }
            catch (Exception e)
            {
                Console.WriteLine("查询数据失败" + e.Message);
                return null;
            }

        }
        public string[] SearchStudentClass()
        {
            string[] ss;
            try
            {
                mdb_SQLiteConnection.Open();
                string sql = "select * from studentclass";
                SQLiteCommand command = new SQLiteCommand(sql, mdb_SQLiteConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    ss = new string[reader.FieldCount];
                    int i = 0;
                    while (reader.Read())
                    {
                        string s = reader["name"].ToString();
                        ss[i] = s;
                        i++;
                        Console.WriteLine("查询数据成功");
                    }
                }
                else
                {
                    Console.WriteLine("没有找到记录");
                    ss = null;
                }
                reader.Close();
                mdb_SQLiteConnection.Close();
                return ss;
            }
            catch (Exception e)
            {
                Console.WriteLine("查询数据失败" + e.Message);
                return null;
            }

        }
    }
}
