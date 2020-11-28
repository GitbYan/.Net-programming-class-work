using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuManageSys
{
    public class School
    {
        public School(string name)
        {
            Name = name;
        }

        public School(string name,string year,string address)
        {
            Name = name;
            Year = year;
            Address = address;
        }

        public string Name { get; set; }

        public string Year { get; set; }

        public string Address { get; set; }

        public override string ToString()
        {
            return "学校名称：" + Name + "  学校建校年：" + Year + "  学校地址：" + Address;
        }
    }
}
