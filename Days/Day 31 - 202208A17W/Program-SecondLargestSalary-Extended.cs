static void Main(string[] args)
{
	//Number of Salaries
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

	Console.WriteLine("Option(user:programmer-based-sorting,lib:using library function):");
	if(Console.ReadLine() == "user")
	{ 
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
	}
	else
	{
		Array.Sort(salaries);
	}
	//Print salaries
	Console.WriteLine("\nSalaries after sorting:");
	bool isFirstElement = true;
	foreach (double value in salaries)
	{
		if (!isFirstElement)
		{
			Console.Write(",");
		}
		Console.Write(value);
		isFirstElement = false;
	}
	Console.WriteLine("\n");


	Console.WriteLine("\nSalaries after sorting:");
	for (int k = 0; k < numberOfSalaries; k++)
	{
		Console.Write(salaries[k]);
		if (k != (numberOfSalaries - 1))
		{
			Console.Write(",");
		}
	}
	Console.WriteLine("\n");


	Console.WriteLine("Salaries after sorting:" + string.Join(",",salaries));


	//Print largest salary and second largest salary 
	Console.WriteLine("largest:" + salaries[numberOfSalaries - 1]);
	Console.WriteLine("second largest :" + salaries[numberOfSalaries - 2]);
	Console.Read();

}