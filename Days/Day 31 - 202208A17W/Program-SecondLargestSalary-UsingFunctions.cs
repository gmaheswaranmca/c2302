class Program
{
	static void ReadArray(double[] dataList,int size)
	{
		//Read Salaries 
		for (int k = 0; k < size; k++)
		{
			Console.Write("Enter the salaries at " + k + ":");
			dataList[k] = double.Parse(Console.ReadLine());
		}
	}
	static void PrintArray(double[] dataList, int size)
	{
		//Print salaries
		foreach (double value in dataList)
		{
			Console.Write(value + " ");
		}
		Console.WriteLine("\n");
	}

	static void SortArray(double[] dataList, int size)
	{
		//Sort salaries ascending order 
		//size = 5,salary = 10,20,28,30,15,sorted salary = 10,15,20,28,30
		for (int i = 0; i < (size - 1); i++)//select element
		{
			for (int j = i + 1; j < size; j++)//next elements
			{
				if (dataList[j] < dataList[i])// next element < selected element
				{
					//swap next element and selected element
					double temp = dataList[i];
					dataList[i] = dataList[j];
					dataList[j] = temp;
				}
			}
		}
	}

	static void Main(string[] args)
	{

		//Read Number of Salaries
		Console.Write("Enter number of salaries:");
		int numberOfSalaries = int.Parse(Console.ReadLine());//5
		double[] salaries = new double[numberOfSalaries];
		double temp;

	   
		ReadArray(salaries, numberOfSalaries);

		Console.WriteLine("\nSalaries before sorting:");
		PrintArray(salaries, numberOfSalaries);

		SortArray(salaries, numberOfSalaries);           

		Console.WriteLine("\nSalaries after sorting:");
		PrintArray(salaries, numberOfSalaries);


		//Print largest salary and second largest salary 
		Console.WriteLine("largest:" + salaries[numberOfSalaries - 1]);
		Console.WriteLine("second largest :" + salaries[numberOfSalaries - 2]);
		Console.Read();
	}
}