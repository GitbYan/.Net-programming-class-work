using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class PersonalCentre : Form
    {
        Bank bank = new Bank();

        private static Account account;

        public PersonalCentre(Account account)
        {            
            InitializeComponent();
            PersonalCentre.account = account;
            //注册事件
            this.BigMoneyFetchedEvent += new BigMoneyFetchedEventHandler(_BigMoneyFetchedEvent);
        }

        //定义事件
        public event BigMoneyFetchedEventHandler BigMoneyFetchedEvent;

        //定义发生事件
        public bool BigMoneyFetch(int amount, Account account)
        {
            if (amount >= 10000)
            {
                BigMoneyArgs b = new BigMoneyArgs(amount, account);
                BigMoneyFetchedEvent(this, b);
                return true;
            }
            return false;
        }

        //定义事件处理方法
        private void _BigMoneyFetchedEvent(object sender, BigMoneyArgs b)
        {
            Console.WriteLine("事件触发");
            MessageBox.Show("取款金额大于1w，请到人工窗口办理");
        }

        //取款
        private void btnFetched_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtNumberToFetch.Text) != 0)
                {
                    //触发BigMoneyFetch事件
                    if (BigMoneyFetch(int.Parse(txtNumberToFetch.Text), account)) { }
                    else
                    {
                        if (account.Fetch(int.Parse(txtNumberToFetch.Text)))
                        {
                            MessageBox.Show("成功取款" +
                                "\n账户余额：" +
                                account.GetBalance());
                        }
                        else
                        {
                            MessageBox.Show("余额不足，取款失败");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtNumberToFetch.Text = "";
            }
        }

        //存款
        private void btnDeposited_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtNumberToDeposit.Text) != 0)
                {
                    if (new Random().Next(0, 101) <= 30)
                    {
                        throw new BadCashException("发现损坏钞票");
                    }
                    else
                    {
                        account.Deposit(int.Parse(txtNumberToDeposit.Text));
                        MessageBox.Show("成功存款" +
                            "\n账户余额：" +
                            account.GetBalance());
                    }                   
                }
            }
            catch (BadCashException badCashException)
            {
                MessageBox.Show(badCashException.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtNumberToDeposit.Text = "";
            }
        }
        
        public void EnableBtn(bool enable)
        {
            btnBack.Visible = !enable;
            foreach(Object o in panelOperations.Controls)
            {
                Button button = (Button)o;
                button.Enabled = enable;
            }
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            panelFetch.Location = new Point(134, 124);
            panelFetch.Visible = true;
            EnableBtn(false);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            panelDeposit.Location = new Point(134, 124);
            panelDeposit.Visible = true;
            EnableBtn(false);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            panelTransfer.Location = new Point(97, 68);
            panelTransfer.Visible = true;
            EnableBtn(false);
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            panelRecord.Location = new Point(13, 11);
            getRecord();
            panelRecord.Visible = true;
            EnableBtn(false);
        }

        private void getRecord()
        {
            int num = account.GetRecords().Count();
            //Console.WriteLine(account.GetRecords()[0].accountID + ":" + account.GetRecords()[0].number);
            ReLabel[] reLabels = new ReLabel[num];
            for(int i = 0; i < num; i++)
            {
                Record record = account.GetRecords()[i];
                string format = "yyyy-MM-dd";
                string date = record.date.ToString(format);
                reLabels[i] = new ReLabel(record.number, date, record.action, record.accountID); ;
                reLabels[i].Name = "ReLabel" + i;
                reLabels[i].Location = new Point(3, 38 + 16 * i);
                panelRecord.Controls.Add(reLabels[i]);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            panelChangePassword.Location = new Point(134, 124);
            panelChangePassword.Visible = true;
            EnableBtn(false);
        }

        private void btnIDInfo_Click(object sender, EventArgs e)
        {
            labelRemainings.Refresh();
            labelName.Text += " " + account.GetName();
            labelRemainings.Text += " " + (0 + account.GetBalance());
            labelDate.Text += " " + account.GetRegisterDate();
            panelIDInfo.Location = new Point(134, 124);
            panelIDInfo.Visible = true;
            EnableBtn(false);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            foreach(Control control in panelOperate.Controls)
            {
                if(control is Panel)
                {
                    Panel panel = (Panel)control;
                    panel.Visible = false;
                }
            }
            EnableBtn(true);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConfirm.Text == "") { }
                else
                {
                    if (bank.FindAccountByAccountID(txtConfirm.Text))
                    {
                        MessageBox.Show("账户存在");
                    }
                    else
                    {
                        MessageBox.Show("账户不存在");
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTransfered_Click(object sender, EventArgs e)
        {
            /*TODO*/
        }

        //修改密码
        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != "" && txtPassword.Text == txtConfirm.Text)
                {
                    account.SetPassword(txtConfirm.Text);
                }
                else if (txtPassword.Text != "" || txtConfirm.Text != "")
                {
                    Console.WriteLine("两次密码输入不一样");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }

    public class ReLabel : Label
    {
        public ReLabel()
        {
        }

        public ReLabel(int number,string date,string action,string accountID)
        {
            this.AutoSize = true;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            string s = "   ";
            for (int i = 0; i < 6 - number.ToString().Length; i++)
            {
                s += " ";
            }
            s += number >= 0 ? "+" : " ";
            for (int i = 0; i < (8 - action.Length) / 2; i++)
            {
                action = " " + action + " ";
            }
            this.Text = "| " + date + " |" + s + number.ToString() + "| " + action + " | " + accountID + "|";
        }
    }
}
