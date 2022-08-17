static void Main(string[] args)
{
	//Number of Salaries
	int size = 5;
	double[] salary = new double[size];
	double temp;
	
	
	//Read Salaries 
	for (int k = 0; k< size ; k++)
	{
		Console.WriteLine("enter the salaries at"+k+":");
		salary[k] = double.Parse(Console.ReadLine());
		
	}
	//Sort salaries ascending order 
	//size = 5,salary = 10,20,28,30,15,sorted salary = 10,15,20,28,30
	for (int i = 0; i < (size-1); i++)//select element
	{
		for (int j = i + 1; j < size; j++)//next elements
		{
			if (salary[j] < salary[i])// next element < selected element
			{
				//swap next element and selected element
				temp = salary[i];
				salary[i] = salary[j];
				salary[j] = temp;
			}
		}
	}
	//Print salaries 
	foreach (double value in salary)
	{
		Console.WriteLine(value + " ");
	}
	//Print largest salary and second largest salary 
	Console.WriteLine("largest:" + salary[size-1]);
	Console.WriteLine("second largest :"+salary[size - 2]);
	Console.Read();
}	