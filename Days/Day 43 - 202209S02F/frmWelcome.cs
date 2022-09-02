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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            DataSet ds = RegistrationService.GetUserDetail(LoginDetails.userName);
            Console.WriteLine(ds.Tables[0].Rows[0]["first_name"]);
            string firstName = (string)ds.Tables[0].Rows[0]["first_name"];
            string lastName = (string)ds.Tables[0].Rows[0]["last_name"];
            string password = (string)ds.Tables[0].Rows[0]["password"];

            lblWelcomeMessage.Text = $"Welcome {firstName} {lastName}({LoginDetails.userName})!!!!";
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            txtUserName.Text = LoginDetails.userName;
            txtPassword.Text = password;
        }

        private void btnGoToLogin_Click(object sender, EventArgs e)
        {
            LoginService.DoLogout(LoginDetails.userName);

            LoginDetails.userName = string.Empty;
            LoginDetails.isLoggdeIn = false;

            MyPages.registrationPage.Show();
            this.Hide();
        }
    }
}
