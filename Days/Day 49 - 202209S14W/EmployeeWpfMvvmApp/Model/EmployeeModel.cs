using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWpfMvvmApp.Model
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public double Salary { get; set; }

        public EmployeeModel():this(0,string.Empty,string.Empty,0)
        {

        }
        public EmployeeModel(int id, string name, string jobTitle, double salary)
        {
            this.Id = id;
            this.Name = name;
            this.JobTitle = jobTitle;
            this.Salary = salary;
        }
    }
}
