enum SearchTechnique
{ 
	LinearSearch,
	BinarySearch
}

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

	static int FindIndexByNameBinarySearch(Employee[] dataList, int startIndex, int endIndex, string searchData)
	{
		//Find Index for the sorted data using binary search
		int searchIndex = -1;
		while (startIndex <= endIndex)//Rule 4
		{
			int mid = (startIndex + endIndex) / 2;
			if (dataList[mid].Name == searchData)//Rule 1//string.Compare(searchData,dataList[mid].Name) == 0
			{
				searchIndex = mid;
				break;
			}
			else if (string.Compare(searchData,dataList[mid].Name) < 0)//Rule 2 //searchData.CompareTo(dataList[mid].Name) < 0
			{
				endIndex = mid - 1;
			}
			else if (string.Compare(searchData, dataList[mid].Name) > 0)//Rule 3 //searchData.CompareTo(dataList[mid].Name) > 0
			{
				startIndex = mid + 1;
			}
		}
		return searchIndex;
	}

	static int FindIndexByNameByLinearSearch(Employee[] dataList, int startIndex, int endIndex, string searchData)
	{
		//Find Index
		int searchIndex = -1;
		for (int i = startIndex; i <= endIndex; i++)
		{
			if (dataList[i].Name == searchData)//check each element's Name property equals the searchData 
			{
				searchIndex = i;
				break;
			}
		}
		return searchIndex;
	}
	static void MainLinearSearch()
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
		if (searchIndex != -1)
		{
			Console.WriteLine($"{searchName} is at index {searchIndex}");
		}
		else
		{
			Console.WriteLine($"{searchName} is not found");
		}
		Console.Read();
	}

	static void MainBinarySearch()
	{   
		Employee[] employees = {
			new Employee(1004,"chitraa","Computer Science","Programmer",1000),
			new Employee(1006,"delisa","Information Science","IT Specialist",2500),
			new Employee(1001,"gokul","Communications","Communication Engineer",3000),
			new Employee(1005,"lalasa","Computer Applications","Software Engineer",4000),
			new Employee(1003,"logesh","Communications","Software Designer",5000),
			new Employee(1002,"susheela","Computer Science","Software Architech",2000)
		};
		int size = employees.Length;


		Console.WriteLine("The given array is");
		PrintArray(employees, 0, size - 1);

		Console.WriteLine("Enter Employee Name to search");
		string searchName = Console.ReadLine();

		int searchIndex = FindIndexByNameBinarySearch(employees, 0, size - 1, searchName);
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
	static void MainChoice(SearchTechnique technique)
	{
		switch(technique)
		{
			case SearchTechnique.LinearSearch:
				MainLinearSearch();
				break;
			case SearchTechnique.BinarySearch:
				MainBinarySearch();
				break;
		}
	}
	static void Main()
	{
		Console.WriteLine("Choice for Search Employees(1-Linear 2-Binary):");
		int choice = int.Parse(Console.ReadLine());

		if(choice == 1)
		{
			MainChoice(SearchTechnique.LinearSearch);
		}
		else if(choice == 2)
		{
			MainChoice(SearchTechnique.BinarySearch);
		}
	}
}