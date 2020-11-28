using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        enum Action { fetch, deposit }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello,world");
            Action action = Action.fetch;
            System.Console.WriteLine(action.ToString());
            return;
        }      
        
    }
}
