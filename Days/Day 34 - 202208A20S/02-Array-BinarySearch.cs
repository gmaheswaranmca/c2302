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

	static int FindIndexByBinarySearch(int[] dataList, int startIndex, int endIndex, int searchData)
	{
		//Find Index for the sorted data using binary search
		int searchIndex = -1;
		while(startIndex <= endIndex)//Rule 4
		{
			int mid = (startIndex + endIndex) / 2;
			if(dataList[mid] == searchData)//Rule 1
			{
				searchIndex = mid;
				break;
			}
			else if(searchData < dataList[mid])//Rule 2
			{
				endIndex = mid - 1;
			}
			else if (searchData > dataList[mid])//Rule 3
			{
				startIndex = mid + 1;
			}
		}
		return searchIndex;
	}


	static void Main(string[] args)
	{
		//For array=10,15,20,30,40,45,50,60,78,90 of size=10, search the given number
		int[] numbers = { 10, 15, 20, 30, 40, 45, 50, 60, 78, 90 };
		int size = 10;


		Console.WriteLine("The given array is");
		PrintArray(numbers, 0, size - 1);

		Console.WriteLine("Enter number to search");
		int searchNumber = int.Parse(Console.ReadLine());

		int searchIndex = FindIndexByBinarySearch(numbers, 0, size - 1, searchNumber);
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