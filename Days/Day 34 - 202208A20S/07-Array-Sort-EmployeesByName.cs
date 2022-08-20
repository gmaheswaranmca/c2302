class Employee//empId,name,deptName,jobTitle,salary //auto properties
{
	public int EmpId { get; set; }
	public string Name { get; set; }
	public string DeptName { get; set; }
	public string JobTitle { get; set; }
	public double Salary { get; set; }

	public Employee(int p_empId, string p_name, string p_deptName, string p_jobTitle, double p_salary)
	{
		this.EmpId = p_empId;
		this.Name = p_name;
		this.DeptName = p_deptName;
		this.JobTitle = p_jobTitle;
		this.Salary = p_salary;
	}

	public override string ToString()
	{
		return $"EmpId={this.EmpId},Name={this.Name},DeptName={this.DeptName},JobTitle={this.JobTitle},Salary={this.Salary}";
	}
}

class Program
{


	static void PrintArray(Employee[] dataList, int startIndex, int endIndex)
	{
		//Print numbers
		for (int i = startIndex; i <= endIndex; i++)
		{
			Console.WriteLine(dataList[i]);
		}
		Console.WriteLine();
	}

	static void SortArrayAscByName(Employee[] dataList, int startIndex, int endIndex)
	{   
		for (int i = startIndex; i <= (endIndex - 1); i++)//select element
		{
			for (int j = i + 1; j <= endIndex; j++)//next elements
			{
				if (string.Compare(dataList[j].Name,dataList[i].Name)<0)// next element < selected element
				{
					//swap next element and selected element
					Employee temp = dataList[i];
					dataList[i] = dataList[j];
					dataList[j] = temp;
				}
			}
		}
	}

	static void Main(string[] args)
	{
		Employee[] employees = {
			new Employee(1001,"gokul","Communications","Communication Engineer",3000),
			new Employee(1002,"susheela","Computer Science","Software Architech",2000),
			new Employee(1003,"logesh","Communications","Software Designer",5000),
			new Employee(1004,"chitraa","Computer Science","Programmer",1000),
			new Employee(1005,"lalasa","Computer Applications","Software Engineer",4000),
			new Employee(1006,"delisa","Information Science","IT Specialist",2500)
		};
		int size = employees.Length;


		Console.WriteLine("The given employees are");
		PrintArray(employees, 0, size - 1);

		SortArrayAscByName(employees, 0, size - 1);

		Console.WriteLine("The sorted employees are");
		PrintArray(employees, 0, size - 1);

		Console.Read();
	}
}