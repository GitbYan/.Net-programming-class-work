using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuManageSys
{

    public class StudentClass
    {
        public StudentClass(string name)
        {
            Name = name;
        }

        public StudentClass(string schoolName,string year,string major)
        {
            SchoolName = schoolName;
            Year = year;
            Major = major;
            Name = Year + "级" + major + "班";
        }

        public string SchoolName { get; set; }

        public string Name { get; set; }

        public string Year { get; set; }

        public string Major { get; set; }
        

    }
}
