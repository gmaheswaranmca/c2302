using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWpfMvvmApp.DataAccessObject
{
    static public class DbConfig
    {
        public static string ConnectionString
        {
            get
            {
                String str = EmployeeWpfMvvmApp.Properties.Resources.ConnectionString;
                return str;
            }
        }
    }
}
