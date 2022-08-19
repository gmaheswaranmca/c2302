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
	
	static void SortArray(int[] dataList, int startIndex, int endIndex)
	{
		//bt startIndex and endIndex,salary = 10,20,28,30,15,sorted salary = 10,15,20,28,30
		for (int i = startIndex; i <= (endIndex-1); i++)//select element
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
	static bool IsArraySortedAsc(int[] dataList, int StartIndex, int EndIndex)//each element<=nextElement --> true, otherwise false 
	{  
		for (int i = StartIndex; i <= (EndIndex-1); i++)
		{
			if(dataList[i] > dataList[i+1])
			{
				return false;
			}
		}

		return true;
	}
		static void Main(string[] args)
	{   
		int[] A = { 10, 15, 20,  40, 30, 45, 50, 60, 78, 90 };
		int N = 10;
		int S = 0;
		int E = N - 1;

		/*
		Console.Write("The given array is ");
		PrintArray(A, N);
		
		SortArray(A, N);
		*/

		Console.Write("The given array is ");
		PrintArray(A, 0,N-1);

		if(IsArraySortedAsc(A,0,N-1))
		{
			Console.WriteLine($"The given array 0 to {N - 1} is sorted");
		}   
		else 
		{ 
			Console.WriteLine($"The given array 0 to {N-1} is not sorted");
		}

		if (IsArraySortedAsc(A, 2, 6))
		{
			Console.WriteLine($"The given array 2 to 6 is sorted");
		}
		else
		{
			Console.WriteLine($"The given array 2 to 6 is not sorted");
			
			Console.Write("The before sorted array 2 to 6 is ");
			PrintArray(A, 2, 6);

			SortArray(A, 2, 6);

			Console.Write("The after sorted array 2 to 6 is ");
			PrintArray(A, 2,6);
		}

		if (IsArraySortedAsc(A, 5, N - 1))
		{ 
			Console.WriteLine($"The given array 5 to {N - 1} is sorted");
		}
		else
		{ 
			Console.WriteLine($"The given array 5 to {N - 1} is not sorted");
		}

		Console.Read();
	}
}