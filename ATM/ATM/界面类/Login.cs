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
    public partial class Login : Form
    {        
        public Login()
        {
            InitializeComponent();
            txtAccount.Focus();     
        }

        Bank bank = new Bank();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAccount.Text == "" && txtPassword.Text == "") { }
                else
                {
                    Account account = new Account(txtAccount.Text, txtPassword.Text);
                    account = bank.Login(account);
                    if (account != null)
                    {
                        PersonalCentre personalCentre = new PersonalCentre(account) { Location = new Point(0, 0), TopLevel = false };
                        Panel panel = (Panel)this.Parent;
                        panel.Controls.Clear();
                        panel.Controls.Add(personalCentre);
                        personalCentre.Show();
                    }
                    else
                    {
                        MessageBox.Show("账户不存在或密码错误");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtAccount.Text = "";
                txtPassword.Text = "";
            }
        }

    }
}
