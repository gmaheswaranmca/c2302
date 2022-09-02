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
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }
        
        private void btnGoToLogin_Click(object sender, EventArgs e)
        {
            MyPages.loginPage.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //validation 
            txtFirstName.Text = txtFirstName.Text.Trim();
            txtLastName.Text = txtLastName.Text.Trim();
            txtUserName.Text = txtUserName.Text.Trim();
            txtPassword.Text = txtPassword.Text.Trim();
            

            if (txtFirstName.Text == string.Empty)
            {
                MessageBox.Show("First Name should not be empty.");
                txtFirstName.Focus();
                return;
            }

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

            //confirmation
            if (MessageBox.Show("Are you sure to register?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            //CODE for registration
            RegistrationService.DoRegister(
                txtFirstName.Text,
                txtLastName.Text,
                txtUserName.Text,
                txtPassword.Text
                ); // try - catch

            //success message after registration 
            MessageBox.Show("You are registered successfully.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
