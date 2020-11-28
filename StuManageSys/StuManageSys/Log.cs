using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuManageSys
{
    public class Log
    {
        public Log(string operation)
        {
            Operation = operation;
            datatime = DateTime.Now;
        }        

        public DateTime datatime;

        public string Operation { get; set; }
    }
}
