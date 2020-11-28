using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    //声明事件参数类
    public class BigMoneyArgs
    {
        public int amount;
        public Account account;
        public BigMoneyArgs() { }
        public BigMoneyArgs(int amount, Account account)
        {
            this.amount = amount;
            this.account = account;
        }
    }

    //声明委托
    public delegate void BigMoneyFetchedEventHandler(object sender, BigMoneyArgs b);


}
