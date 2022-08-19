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

	static int NumberOfSubArrays(int[] dataList, int size, int SizeOfSubArray)//size=10,sub array size=3,returns 4
	{
		int subArraysCount = 0;
		subArraysCount = size / SizeOfSubArray;// 10/3 = 4
		if ((size % SizeOfSubArray) != 0)
		{
			subArraysCount++;
		}
		return subArraysCount;
	}
	static void Main(string[] args)
	{
		int[] numbers = { 30, 20, 50, 10, 40, 90, 60, 15, 45, 78 };
		//Sort each k-sized sub array
		//Given List:      30,20,50,10,40,90,60,15,45,78 size = 10, sub array size=3
		//                 --------                   first 3 element index(s)=0-2                                  
		//                          --------          next 3 element index(s)=3-5
		//                                  --------  next 3 element index(s)=6-8
		//                                             --- last 1 element index(s)=9-9
		//Expected List 2: 20,30,50,10,40,90,15,45,60,78 size = 10

		int numberOfNumbers = 10;

		Console.WriteLine("Given array is ");
		PrintArray(numbers, 0, numberOfNumbers - 1);

		//Print k-sized sub arrays
		//Read size of the sub array
		Console.WriteLine("Enter size of each sub array:");
		int k = int.Parse(Console.ReadLine());

		//number Of Sub Arrays for given array
		int subArraysCount = NumberOfSubArrays(numbers, numberOfNumbers,k);
		//Console.WriteLine($"Number Of Sub Arrays for sub array size {k} is {subArraysCount}");//DEBUG

		int arrayEndIndex = (numberOfNumbers - 1); //9
		int subArrayStartIndex = 0;     //0
		int subArrayEndIndex = k - 1;   //3
		for(int subArrI=1; subArrI<= subArraysCount; subArrI++)//0-3,4-7,{8-11=>8-9}
		{   
			if (subArrayEndIndex > arrayEndIndex)
			{
				subArrayEndIndex = arrayEndIndex;
			}
			SortArrayAsc(numbers, subArrayStartIndex, subArrayEndIndex);
			subArrayStartIndex += k;    // 4 8
			subArrayEndIndex += k;      // 7 11
		}

		Console.WriteLine("Expected result array is ");
		PrintArray(numbers, 0, numberOfNumbers - 1);
		Console.Read();
	}
}