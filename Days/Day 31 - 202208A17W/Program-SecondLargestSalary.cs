static void Main(string[] args)
{
	//Read Number of Salaries
	Console.Write("Enter number of salaries:");
	int numberOfSalaries = int.Parse(Console.ReadLine()) ;//5
	double[] salaries = new double[numberOfSalaries];
	double temp;


	//Read Salaries 
	for (int k = 0; k < numberOfSalaries; k++)
	{
		Console.Write("Enter the salaries at " + k + ":");
		salaries[k] = double.Parse(Console.ReadLine());
	}
	//Sort salaries ascending order 
	//size = 5,salary = 10,20,28,30,15,sorted salary = 10,15,20,28,30
	for (int i = 0; i < (numberOfSalaries - 1); i++)//select element
	{
		for (int j = i + 1; j < numberOfSalaries; j++)//next elements
		{
			if (salaries[j] < salaries[i])// next element < selected element
			{
				//swap next element and selected element
				temp = salaries[i];
				salaries[i] = salaries[j];
				salaries[j] = temp;
			}
		}
	}
	//Print salaries
	Console.WriteLine("\nSalaries after sorting:");
	foreach (double value in salaries)
	{
		Console.Write(value + " ");
	}
	Console.WriteLine("\n");
	//Print largest salary and second largest salary 
	Console.WriteLine("largest:" + salaries[numberOfSalaries - 1]);
	Console.WriteLine("second largest :" + salaries[numberOfSalaries - 2]);
	Console.Read();

}