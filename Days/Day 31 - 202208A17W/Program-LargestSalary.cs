int numOfSalaries;
//size of array
Console.WriteLine("Enter the Number of Salaries:");
numOfSalaries = int.Parse(Console.ReadLine());
double[] salaries = new double[numOfSalaries];
//read salaries
for(int i=0;i<numOfSalaries;i++)
{
	Console.WriteLine($"Enter the salaray {i+1}:");
	salaries[i] = double.Parse(Console.ReadLine());
 
}
//Find Maximum salaries
double maxSalary = 0;
for (int i=0;i<numOfSalaries;i++)
{
	if(salaries[i]>maxSalary)
	{
		maxSalary = salaries[i];
	}
}
//print Maximum salaries
Console.WriteLine($"Maximum Salary is:{maxSalary}");
Console.Read();