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
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            btnLogin.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            panelCenter.Controls.Clear();
            Login login = new Login() { Location = new Point(0, 0), TopLevel = false };
            panelCenter.Controls.Add(login);
            login.Show();
            btnBack.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            panelCenter.Controls.Clear();
            Register register = new Register() { Location = new Point(0, 0), TopLevel = false };
            panelCenter.Controls.Add(register);
            register.Show();
            btnBack.Show();
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(btnLogin);
            panelCenter.Controls.Add(btnRegister);
            btnBack.Hide();
        }
    }

}
