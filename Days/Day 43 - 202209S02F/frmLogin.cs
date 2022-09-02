using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFirst
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //validation
            txtUserName.Text = txtUserName.Text.Trim();
            txtPassword.Text = txtPassword.Text.Trim();
           
            if (txtUserName.Text == string.Empty)
            {
                MessageBox.Show("User Name should not be empty.");
                txtUserName.Focus();
                return;
            }

            if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Password should not be empty.");
                txtPassword.Focus();
                return;
            }

            //check is valid user and password //CODE
            if(!RegistrationService.IsValidUser(txtUserName.Text,txtPassword.Text))
            {
                MessageBox.Show("The user name or password you typed is incorrect.");
            }

            LoginDetails.userName = txtUserName.Text;
            LoginDetails.isLoggdeIn = true;

            LoginService.DoLogin(LoginDetails.userName);

            MyPages.welcomePage.Show();
            this.Hide();
        }
    }
}
