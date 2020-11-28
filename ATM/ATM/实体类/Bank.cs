using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Bank
    {    
        public Bank() { }

        private static List<Account> Accounts = new List<Account>();

        public static int GetNumber()
        {
            return Accounts.Count();
        }

        private Account GetAccountByAccountID(string accountID)
        {
            Account account = (Account)Accounts.Where(a => a.GetAccountID() == accountID);
            if (account.GetAccountID() != "")
            {
                Console.WriteLine("找到账户");
            }
            return account;
        }

        public bool FindAccountByAccountID(string accountID)
        {
            Account account = (Account)Accounts.Where(a => a.GetAccountID() == accountID);
            if (account.GetAccountID() != "")
            {
                Console.WriteLine("找到账户");
                return true;
            }
            return false;
        }

        public Account Login(Account account)
        {
            foreach(Object o in Bank.Accounts)
            {
                Account a = (Account)o;
                if (a!=null && a.Login(account)!=null)
                {
                    Console.WriteLine("账号：" + a.GetAccountID() + " 登陆成功");
                    return a;
                }
            }
            Console.WriteLine("登陆失败,账号不存在或密码错误");
            return null;
        }

        public bool Register(Account account)
        {
            try
            {
                Bank.Accounts.Add(account);
                Console.WriteLine("账号："+account.GetAccountID()+" 注册成功");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
