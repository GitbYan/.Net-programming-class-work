using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuManageSys
{
    public class Student
    {
        public Student(string name)
        {
            Name = name;
        }

        public Student(string name,string sex,string year, string stuClass)
        {
            Name = name;
            Sex = sex;
            Year = year;
            StuClass = stuClass;
        }

        public string Name { get; set; }

        public string Sex { get; set; }
        
        public string StuClass { get; set; }

        public string Year { get; set; }

    }
}
