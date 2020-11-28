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
    public partial class Registered : Form
    {
        public bool login = false;

        public Registered(string AccountID)
        {            
            InitializeComponent();
            btnLogin.Focus();
            labelAccountID.Text += " " + AccountID;
            this.FormClosing += Registered_FormClosing;
        }

        private void Registered_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!login)
            {
                this.DialogResult = DialogResult.No;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login = true;
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }        
    }
}
