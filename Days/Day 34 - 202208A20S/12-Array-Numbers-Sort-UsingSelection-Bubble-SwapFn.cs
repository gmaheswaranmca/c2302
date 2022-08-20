class Program
{


	static void PrintArray(int[] dataList, int startIndex, int endIndex)
	{
		//Print numbers
		for (int i = startIndex; i <= endIndex; i++)
		{
			Console.WriteLine(dataList[i]);
		}
		Console.WriteLine();
	}
	static void SwapData(ref int first, ref int second) 
	{
		int temp = first;
		first = second;
		second = temp;
	}
	static void SortSelectionArrayAsc(int[] dataList, int startIndex, int endIndex)
	{
		for (int i = startIndex; i <= (endIndex - 1); i++)//select element
		{
			int minIndex = i;
			for (int j = i + 1; j <= endIndex; j++)//next elements
			{
				// next element < selected element
				if (dataList[j] < dataList[minIndex])
				{
					minIndex = j;
				}
			}
			if (minIndex != i)
			{
				/*int temp = dataList[i];
				dataList[i] = dataList[minIndex];
				dataList[minIndex] = temp;
				*/
				SwapData(ref dataList[i], ref dataList[minIndex]);
			}
		}
	}

	static void SortBubbleArrayAsc(int[] dataList, int startIndex, int endIndex)
	{
		bool isSwapped;
		do
		{
			isSwapped = false;
			//for each element
			//  compare element and next element ie if next element < element do swap | mark isSwapped as true
			for (int J = startIndex; J <= (endIndex - 1); J++)
			{
				if (dataList[J + 1] < dataList[J])
				{
					//do swap
					/*int temp = dataList[J];
					dataList[J] = dataList[J + 1];
					dataList[J + 1] = temp;*/

					SwapData(ref dataList[J], ref dataList[J+1]);
					//mark it as swapped
					isSwapped = true;
				}
			}
			//as last element will get its position ie sorted ie it is maximum in the processed list
			//'new processable list' = "'process list' minus 'last element of the processed list'"
			endIndex = endIndex - 1;
		} while (isSwapped);
	}

	static void Main(string[] args)
	{
		int[] numbers = { 30, 20, 10, 15, 25 };
		int size = numbers.Length;


		Console.WriteLine("The given numbers are");
		PrintArray(numbers, 0, size - 1);

		//SortSelectionArrayAsc(numbers, 0, size - 1);
		SortBubbleArrayAsc(numbers, 0, size - 1);

		Console.WriteLine("The sorted numbers are");
		PrintArray(numbers, 0, size - 1);

		Console.Read();
	}
}