using EmployeeWpfMvvmApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWpfMvvmApp.DataAccessObject
{
    static public class EmployeeDAO
    {
        public static void Create(EmployeeModel employee)
        {
            string insertString = @"INSERT INTO employee
(employee_id,employee_name,job_title,salary) 
VALUES(@employee_id,@employee_name,@job_title,@salary);";

            SqlConnection con = new SqlConnection(DbConfig.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(insertString, con);
            cmd.Parameters.AddWithValue("@employee_id", employee.Id);
            cmd.Parameters.AddWithValue("@employee_name", employee.Name);
            cmd.Parameters.AddWithValue("@job_title", employee.JobTitle);
            cmd.Parameters.AddWithValue("@salary", employee.Salary);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void Update(EmployeeModel employee)
        {
            string insertString = @"UPDATE employee SET 
employee_name=@employee_name,
job_title=@job_title,
salary=@salary 
WHERE employee_id=@employee_id;";

            SqlConnection con = new SqlConnection(DbConfig.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(insertString, con);
            cmd.Parameters.AddWithValue("@employee_id", employee.Id);
            cmd.Parameters.AddWithValue("@employee_name", employee.Name);
            cmd.Parameters.AddWithValue("@job_title", employee.JobTitle);
            cmd.Parameters.AddWithValue("@salary", employee.Salary);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void Delete(int employee_id)
        {
            string insertString = @"DELETE FROM employee 
WHERE employee_id=@employee_id;";

            SqlConnection con = new SqlConnection(DbConfig.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(insertString, con);
            cmd.Parameters.AddWithValue("@employee_id", employee_id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static ObservableCollection<EmployeeModel> ReadAll()
        {
            ObservableCollection<EmployeeModel> employees = new ObservableCollection<EmployeeModel>();

            string insertString = @"SELECT employee_id,
employee_name,job_title,salary 
FROM employee;";

            SqlConnection con = new SqlConnection(DbConfig.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(insertString, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                employees.Add(new EmployeeModel(
                    (int)reader["employee_id"],
                    (string)reader["employee_name"],
                    (string)reader["job_title"],
                    (double)reader["salary"]
                    ));
            }
            con.Close();

            return employees;
        }
    }
}
