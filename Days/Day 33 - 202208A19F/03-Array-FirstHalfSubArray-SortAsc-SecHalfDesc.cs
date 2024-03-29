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

	static void SortArrayAsc(int[] dataList, int startIndex, int endIndex)
	{
		//bt startIndex and endIndex,salary = 10,20,28,30,15,sorted salary = 10,15,20,28,30
		for (int i = startIndex; i <= (endIndex - 1); i++)//select element
		{
			for (int j = i + 1; j <= endIndex; j++)//next elements
			{
				if (dataList[j] < dataList[i])// next element < selected element
				{
					//swap next element and selected element
					int temp = dataList[i];
					dataList[i] = dataList[j];
					dataList[j] = temp;
				}
			}
		}
	}

	static void SortArrayDesc(int[] dataList, int startIndex, int endIndex)
	{
		//bt startIndex and endIndex,salary = 10,20,28,30,15,sorted salary = 30,28,20,15,10
		for (int i = startIndex; i <= (endIndex - 1); i++)//select element
		{
			for (int j = i + 1; j <= endIndex; j++)//next elements
			{
				if (dataList[j] > dataList[i])// next element > selected element
				{
					//swap next element and selected element
					int temp = dataList[i];
					dataList[i] = dataList[j];
					dataList[j] = temp;
				}
			}
		}
	}
	static bool IsArraySortedAsc(int[] dataList, int StartIndex, int EndIndex)//each element<=nextElement --> true, otherwise false 
	{
		for (int i = StartIndex; i <= (EndIndex - 1); i++)
		{
			if (dataList[i] > dataList[i + 1])
			{
				return false;
			}
		}

		return true;
	}
	static void Main(string[] args)
	{
		//Given List:      30,20,50,10,40,90,60,15,45,78 size = 10
		//Expected List 1: 10,20,30,40,50,90,78,60,45,15 size = 10
		//                 --------------                   first five elements sorted asc
		//                                ---------------   next five elements sorted desc
		int[] numbers = { 30, 20, 50, 10, 40, 90, 60, 15, 45, 78 };
		
		int numberOfNumbers = 10;

		Console.WriteLine("Given array is ");
		PrintArray(numbers, 0, numberOfNumbers - 1);

		int firstHalfArrayStartIndex = 0;
		int firstHalfArrayEndIndex = numberOfNumbers/2;
		int secondHalfArrayStartIndex = firstHalfArrayEndIndex + 1;
		int secondHalfArrayEndIndex = numberOfNumbers-1;

		//first half array - sort asc
		SortArrayAsc(numbers, firstHalfArrayStartIndex, firstHalfArrayEndIndex);

		Console.WriteLine("After sort asc first half, the array is ");
		PrintArray(numbers, 0, numberOfNumbers - 1);

		//second half array - sort desc
		SortArrayDesc(numbers, secondHalfArrayStartIndex, secondHalfArrayEndIndex);

		Console.WriteLine("After sort desc second half, the array is ");
            PrintArray(numbers, 0, numberOfNumbers - 1);


            Console.Read();
        }
    }