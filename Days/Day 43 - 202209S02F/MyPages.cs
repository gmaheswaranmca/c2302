using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appFirst
{
    class MyPages
    {
        public static frmLogin loginPage;
        public static frmRegistration registrationPage;
        public static frmWelcome welcomePage;

        public static void CreatePages()
        {
            loginPage = new frmLogin();
            registrationPage = new frmRegistration();
            welcomePage = new frmWelcome();
        }
    }
}
