using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class BadCashException : Exception
    {
        public BadCashException(string message) : base(message) { }
    }

}
