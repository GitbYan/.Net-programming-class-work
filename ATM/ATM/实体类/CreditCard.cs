using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class CreditCard: Account
    {
        private int _credit;//信用额度

        public int Credit
        {
            get
            {
                return _credit;
            }
            set
            {
                _credit = value;
            }
        }
        //方法的覆盖
        public override bool Fetch(int money)
        {
            try
            {
                this.Credit -= money;
                Console.WriteLine("信用卡支取成功");
                return true;
            }
            catch
            {
                Console.WriteLine("信用卡支取失败");
                return false;
            }
        }
        public override bool Deposit(int money)
        {
            try
            {
                this.Credit += money;
                Console.WriteLine("信用卡还贷成功");
                return true;
            }
            catch
            {
                Console.WriteLine("信用卡还贷失败");
                return false;
            }
        }
    }
}
