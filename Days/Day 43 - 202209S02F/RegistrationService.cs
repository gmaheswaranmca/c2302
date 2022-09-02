using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appFirst
{
    class LoginDetails
    {
        public static string userName = "";
        public static bool isLoggdeIn = false;
    }

    class MyConfig
    {
        public static string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=E:\work\jobs\C2302\apps\appFirst\EmployeeDb.mdf;
Integrated Security=True";
    }
    class RegistrationService
    {
        public static void DoRegister(string firstName, 
            string lastName,
            string userName,
            string password)
        {
            string sql = @"INSERT INTO 
registration(id,first_name,last_name,password)
VALUES(@id,@first_name,@last_name,@password)
";
            //ADO code for registration ::: INSERT -> registration
            SqlConnection con = new SqlConnection(MyConfig.conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id",userName);
            cmd.Parameters.AddWithValue("@first_name", firstName);
            cmd.Parameters.AddWithValue("@last_name", lastName);
            cmd.Parameters.AddWithValue("@password", password);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static bool IsValidUser(string userName, string password)
        {
            //ADO code for login authentication ::: SELECT -> registration

            string sql = @"SELECT COUNT(*) count_value
FROM registration
WHERE (id=@id) and (password=@password)
";
            DataSet ds = new DataSet();

            SqlConnection con = new SqlConnection(MyConfig.conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", userName);
            cmd.Parameters.AddWithValue("@password", password);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            con.Close();

            int count_value = (int)ds.Tables[0].Rows[0]["count_value"];
            return (count_value >= 1);//true or false 
        }

        public static DataSet GetUserDetail(string userName)
        {
            //ADO code for login authentication ::: SELECT -> registration

            string sql = @"SELECT first_name, last_name, id, password 
FROM registration
WHERE (id=@id)
";
            DataSet ds = new DataSet();

            SqlConnection con = new SqlConnection(MyConfig.conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", userName);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            con.Close(); // Tables[0].Rows[0]["first_name"] ... Tables[0].Rows[0]["last_name"]

            return ds;//true or false 
        }
    }

    class LoginService
    {
        public static void DoLogin(string userName)
        {
            //ADO code for login ::: INSERT -> login     login_id(identity(1,1)), username, loggedin_time NOT NULL, loggout_time [NULL]
            string sql = @"INSERT INTO 
login(username, loggedin_time)
VALUES(@id,getdate())
";
        }

        public static void DoLogout(string userName)
        {
            //ADO code for login ::: UPDATE -> login     
            string sql = @"UPDATE login
SET loggedout_time=getdate()
WHERE (id=@id)
";
        }
    }
}
