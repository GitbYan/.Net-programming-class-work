using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public struct Record//操作信息
    {
        public int number;//金额
        public DateTime date;//日期
        public string action;//操作
        public string accountID;//目标
        public Record(int num, string action, string accountID)
        {
            this.number = num;
            this.date = DateTime.Now;
            this.action = action;
            this.accountID = accountID;
        }
    }

    public class Account
    {
        public Account() { }

        public Account(string Name, string ID, string Password)
        {
            this.RegisterDate = DateTime.Now;
            this.Name = Name;
            this.ID = ID;
            this.Password = Password;
            this.Balance = 0;
            int index = (Bank.GetNumber()+1).ToString().Length;
            string s = "";
            for (int i = 0; i < 15 - index; i++)
            {
                s += "0";
            }
            this.AccountID = "681"+ s + (Bank.GetNumber() + 1);
        }

        public Account(string AccountID, string Password)
        {
            this.AccountID = AccountID;
            this.Password = Password;
        }
        
        private DateTime RegisterDate;//注册日期
        private string AccountID;//账号
        private string Name;//姓名
        private string ID;//身份证
        private string Password;//密码
        private long Balance;//余额                
        private List<Record> Records = new List<Record>();//操作记录
        
        //获取账号
        public string GetAccountID()
        {
            return this.AccountID;
        }
        
        //获取注册时间
        public string GetRegisterDate()
        {
            string format = "yyyy-MM-dd";
            return RegisterDate.ToString(format);            
        }

        //获取持卡人姓名
        public string GetName()
        {
            return this.Name;
        }

        //获取余额
        public long GetBalance()
        {
            return this.Balance;
        }

        //获取记录
        public List<Record> GetRecords()
        {
            return this.Records;
        }

        //登陆
        public Account Login(Account account)
        {
            if(this.AccountID == account.AccountID && this.Password == account.Password)
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        //设置密码
        public bool SetPassword(string newPassword)
        {
            try
            {
                Console.WriteLine("密码修改成功");
                return true;
            }
            catch
            {
                Console.WriteLine("密码修改失败");
                return false;
            }
        }

        //找回密码
        public void FindPassword()
        {
            /*
             * TODO
             */
        }

        //取钱
        virtual public bool Fetch(int money)
        {
            try
            {
                if (this.Balance >= money)
                {
                    this.Balance -= money;
                    Recorded(new Record(-money, "取款", this.AccountID));
                    Console.WriteLine("取钱成功");
                    return true;
                }
                else
                {
                    Console.WriteLine("余额不足，取钱失败");
                    return false;
                }
            }
            catch
            {
                Console.WriteLine("取钱异常");
                return false;
            }
        }

        //存钱
        virtual public bool Deposit(int money)
        {
            try
            {
                this.Balance += money;
                Recorded(new Record(+money, "存款", this.AccountID));
                Console.WriteLine("存钱成功");
                return true;
            }
            catch
            {
                Console.WriteLine("存钱失败");
                return false;
            }
        }
               
        //跨行转账
        public bool Transfer(int money, string accountID)
        {
            return false;
            /*
            if (Bank.FindAccountByAccountID(accountID))
            {
                this.Balance -= money;
                this.Recorded(new Record(-money, "跨行转账", accountID));
                //account.Balance += money;
                //account.Recorded(new Record(+money, "跨行转账", this.AccountID));
                return true;
            }
            else
            {
                return false;
            }
            */
        }

        //记录
        public void Recorded(Record record)
        {
            this.Records.Add(record);
        }
    }
}
