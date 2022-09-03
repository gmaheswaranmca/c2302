using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFirst
{
    


    public partial class frmEmployee : Form
    {
        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string JobTitle { get; set; }
            public double Salary { get; set; }

            public Employee(int id, string name, string jobTitle, double salary)
            {
                this.Id = id;
                this.Name = name;
                this.JobTitle = jobTitle;
                this.Salary = salary;
            }
        }

        bool isNew = true;
        public bool IsNew
        {
            get { return isNew; }
            set
            {
                isNew = value;
                LblFormStatus.Text = isNew ? "New Employee" : "Edit Employee";
                TxtID.ReadOnly = !isNew;
            }
        }

        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\work\jobs\C2302\apps\appFirst\EmployeeDb.mdf;Integrated Security=True";
        public frmEmployee()
        {
            InitializeComponent();
        }
        

        

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string query; 
            if(IsNew)
            {
                /*query = $@"INSERT INTO employee
(employee_id,employee_name,job_title,salary) 
VALUES(@employee_id,@employee_name,@job_title,@salary);";*/
                query = $@"employee_add";
            }
            else
            {
                query = @"UPDATE employee SET 
employee_name=@employee_name,
job_title=@job_title,
salary=@salary 
WHERE employee_id=@employee_id;";
            }

            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            if (IsNew) 
            {
                cmd.CommandType = CommandType.StoredProcedure; // required for stored proc

                TxtName.Text = TxtName.Text + " [SP]";
            }
            else
            {
                cmd.CommandType = CommandType.Text; // by default 
            }
            cmd.Parameters.AddWithValue("@employee_id", int.Parse(TxtID.Text));
            cmd.Parameters.AddWithValue("@employee_name", TxtName.Text);
            cmd.Parameters.AddWithValue("@job_title", TxtJobTitle.Text);
            cmd.Parameters.AddWithValue("@salary", Double.Parse(TxtSalary.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Employee is saved");
            lblStatus.Text = "Employee is saved";

            BtnNew_Click(null,null);
            BtnLoad_Click(null, null);
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            TxtID.Text = string.Empty;
            TxtName.Text = string.Empty;
            TxtJobTitle.Text = string.Empty;
            TxtSalary.Text = string.Empty;

            IsNew = true;
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            List<Employee> employees = new List<Employee>();

            string query = "SELECT employee_id,employee_name,job_title,salary FROM employee;";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                employees.Add(new Employee(
                    (int)reader["employee_id"],
                    (string)reader["employee_name"],
                    (string)reader["job_title"],
                    (double)reader["salary"]
                    ));
            }
            con.Close();

            GrdEmployees.DataSource = employees;
        }
        
        private void BtnEdit_Click(object sender, EventArgs e)
        {   Employee emp = (Employee)GrdEmployees.SelectedRows[0].DataBoundItem;
            TxtID.Text = emp.Id.ToString();
            TxtName.Text = emp.Name;
            TxtJobTitle.Text = emp.JobTitle;
            TxtSalary.Text = emp.Salary.ToString();

            IsNew = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}

/*
CREATE TABLE employee
(employee_id INT, 
employee_name VARCHAR(256) NOT NULL DEFAULT '', 
job_title VARCHAR(50) NOT NULL DEFAULT '', 
salary float NOT NULL DEFAULT 0,
PRIMARY KEY(employee_id)
);


 CREATE PROCEDURE employee_add
	@employee_id int,
	@employee_name varchar(256),
	@job_title  varchar(256),
	@salary float
AS
BEGIN
	INSERT INTO employee
	(employee_id,employee_name,job_title,salary) 
	VALUES(@employee_id,@employee_name,@job_title,@salary);
END
     
*/
