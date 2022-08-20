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

	static int FindIndexByNameByLinearSearch(Employee[] dataList, int startIndex, int endIndex, string searchData)
	{
		//Find Index
		int searchIndex = -1;
		for (int i = startIndex; i <= endIndex; i++)
		{
			if(dataList[i].Name == searchData)//check each element's Name property equals the searchData 
			{
				searchIndex = i;
				break;
			}
		}
		return searchIndex;
	}



	static void Main(string[] args)
	{
		//employees's 
		Employee[] employees = {
			new Employee(1001,"gokul","Communications","Communication Engineer",3000),
			new Employee(1002,"susheela","Computer Science","Software Architech",2000),
			new Employee(1003,"logesh","Communications","Software Designer",5000),
			new Employee(1004,"chitraa","Computer Science","Programmer",1000),
			new Employee(1005,"lalasa","Computer Applications","Software Engineer",4000),
			new Employee(1006,"delisa","Information Science","IT Specialist",2500),
		};
		int size = employees.Length;


		Console.WriteLine("The given array is");
		PrintArray(employees, 0, size - 1);

		Console.WriteLine("Enter Employee Name to search");
		string searchName = Console.ReadLine();

		int searchIndex = FindIndexByNameByLinearSearch(employees, 0, size - 1, searchName);
		if(searchIndex != -1)
		{ 
			Console.WriteLine($"{searchName} is at index {searchIndex}");
		}
		else
		{
			Console.WriteLine($"{searchName} is not found");
		}
		Console.Read();
	}
}