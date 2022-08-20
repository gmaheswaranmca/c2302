//For array=30, 20, 50, 10, 40, 90, 60, 15, 45, 78 of size=10, search the given number

class Program
{

	static void PrintArray(int[] dataList, int startIndex, int endIndex)
	{
		//Print numbers
		for (int i = startIndex; i <= endIndex; i++)
		{
			Console.Write(dataList[i] + " ");
		}
		Console.WriteLine("\n");
	}

	static int FindIndexByLinearSearch(int[] dataList, int startIndex, int endIndex, int searchData)
	{
		//Find Index
		int searchIndex = -1;
		for (int i = startIndex; i <= endIndex; i++)
		{
			if(dataList[i] == searchData)//check each element equals the searchData 
			{
				searchIndex = i;
				break;
			}
		}
		return searchIndex;
	}

   


	static void Main(string[] args)
	{
		//For array=30, 20, 50, 10, 40, 90, 60, 15, 45, 78 of size=10, search the given number
		int[] numbers = { 30, 20, 50, 10, 40, 90, 60, 15, 45, 78 };
		int size = 10;


		Console.WriteLine("The given array is");
		PrintArray(numbers, 0, size - 1);

		Console.WriteLine("Enter number to search");
		int searchNumber = int.Parse(Console.ReadLine());

		int searchIndex = FindIndexByLinearSearch(numbers, 0, size - 1, searchNumber);
		if(searchIndex != -1)
		{ 
			Console.WriteLine($"{searchNumber} is at index {searchIndex}");
		}
		else
		{
			Console.WriteLine($"{searchNumber} is not found");
		}
		Console.Read();
	}
}