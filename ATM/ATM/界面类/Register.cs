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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            txtName.Focus();
        }

        Bank bank = new Bank();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtPassword.Text!="" && txtPassword.Text == txtConfirm.Text)
                {
                    Account account = new Account(txtName.Text, txtID.Text, txtPassword.Text);
                    if (bank.Register(account))
                    {
                        Registered registered = new Registered(account.GetAccountID());
                        registered.ShowDialog();
                        if (registered.DialogResult == DialogResult.Yes)
                        {
                            account = bank.Login(account);
                            PersonalCentre personalCentre = new PersonalCentre(account) { Location = new Point(0, 0), TopLevel = false };
                            this.Parent.Controls.Add(personalCentre);
                            this.Close();
                            personalCentre.Show();
                        }
                        else
                        {
                            foreach(Control c in this.Controls)
                            {
                                if(c is TextBox)
                                {
                                    TextBox t = (TextBox)c;
                                    t.Text = "";
                                }
                            }                            
                        }
                    }
                }
                else
                {
                    MessageBox.Show("两次密码不相同");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
