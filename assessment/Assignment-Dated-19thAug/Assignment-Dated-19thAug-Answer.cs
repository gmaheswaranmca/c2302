using System;
class MyArray
{
	public static void Read(int[] dataList, int startIndex, int endIndex)
	{
		for (int i = startIndex; i <= endIndex; i++)
		{
			Console.Write($"Enter age at {i} :");
			dataList[i] = int.Parse(Console.ReadLine());
		}
	}
	public static void Print(int[] dataList, int startIndex, int endIndex)
	{
		for (int i = startIndex; i <= endIndex; i++)
		{
			Console.Write(dataList[i] + " ");
		}
		Console.WriteLine("\n");
	}

	public static int FindMax(int[] dataList, int startIndex, int endIndex)
	{
		int max = dataList[0];
		for (int i = startIndex; i <= endIndex; i++)
		{
			if (dataList[i] > max)
			{
				max = dataList[i];
			}
		}
		return max;
	}

	public static int FindMin(int[] dataList, int startIndex, int endIndex)
	{
		int min = dataList[0];
		for (int i = startIndex; i <= endIndex; i++)
		{
			if (dataList[i] < min)
			{
				min = dataList[i];
			}
		}
		return min;
	}

	public static int FindDiff(int first, int second)
	{
		return first - second;
	}

	public static bool IsDivisibleBy7(int first)
	{
		return first % 7 == 0;
	}

	public static void FindMaxMinDiffIs7Divisible(int[] dataList, int startIndex, int endIndex,
		out int min, out int max, out int diff, out bool isDivisibleBy5)
	{
		min = dataList[0];
		max = dataList[0];
		for (int i = startIndex; i <= endIndex; i++)
		{
			if (dataList[i] < min)
			{
				min = dataList[i];
			}
			//
			if (dataList[i] > max)
			{
				max = dataList[i];
			}
		}
		diff = max - min;
		isDivisibleBy5 = diff % 7 == 0;
	}
	public static void Swap(ref int first, ref int second)
	{
		int temp = first;
		first = second;
		second = temp;
	}
	public static void SortAsc(int[] dataList, int startIndex, int endIndex)
	{
		for (int i = startIndex; i <= (endIndex - 1); i++)
		{
			for (int j = i + 1; j <= endIndex; j++)
			{
				if (dataList[j] < dataList[i])
				{
					Swap(ref dataList[j], ref dataList[i]);
				}
			}
		}
	}
	public static void SortDesc(int[] dataList, int startIndex, int endIndex)
	{
		for (int i = startIndex; i <= (endIndex - 1); i++)
		{
			for (int j = i + 1; j <= endIndex; j++)
			{
				if (dataList[j] > dataList[i])
				{
					Swap(ref dataList[j], ref dataList[i]);
				}
			}
		}
	}

	public static int CountEven(int[] dataList, int startIndex, int endIndex)
	{
		int countEven = 0;

		for (int i = 0; i <= endIndex; i++)
		{
			if (dataList[i] % 2 == 0)
			{
				countEven++;
			}
		}
		return countEven;
	}
	public static int CountOdd(int[] dataList, int startIndex, int endIndex)
	{
		int countOdd = 0;

		for (int i = 0; i <= endIndex; i++)
		{
			if (dataList[i] % 2 == 1)
			{
				countOdd++;
			}
		}
		return countOdd;
	}

	public static void CountEvenOdd(int[] dataList, int startIndex, int endIndex,
		out int countEven, out int countOdd)
	{
		countOdd = 0;
		countEven = 0;
		for (int i = 0; i <= endIndex; i++)
		{
			if (dataList[i] % 2 == 0)
			{
				countEven++;
			}
			if (dataList[i] % 2 == 1)
			{
				countOdd++;
			}
		}
	}

	public static void DistinctAge(int[] dataList, int startIndex, int endIndex, int[] resultList, out int resultListCount)
	{
		resultListCount = 0;
		for (int i = startIndex; i <= endIndex; i++)
		{
			int eCount = 0;//element count
			for (int j = 0; j <= i - 1; j++)
			{
				if (dataList[i] == dataList[j])
				{
					eCount++;
				}
			}
			if (eCount == 0)
			{
				resultList[resultListCount] = dataList[i];
				resultListCount++;
			}
		}
	}

	public static void FindAgeFreq(int[] dataList, int startIndex, int endIndex, int[] freqList)
	{
		for (int i = startIndex; i <= endIndex; i++)
		{
			int eCount = 0;//element count
			for (int j = startIndex; j <= endIndex; j++)
			{
				if (dataList[i] == dataList[j])
				{
					eCount++;
				}
			}

			freqList[i] = eCount;
		}
	}
	public static void PrintAgeFreq(int[] dataList, int startIndex, int endIndex, int[] freqList)
	{
		for (int i = startIndex; i <= endIndex; i++)
		{
			Console.WriteLine(dataList[i] + " occurs " + freqList[i] + " times.");
		}
		Console.WriteLine("\n");
	}
	public static void SortAgeByFreqDesc(int[] dataList, int startIndex, int endIndex, int[] freqList)
	{
		for (int i = startIndex; i <= (endIndex - 1); i++)
		{
			for (int j = i + 1; j <= endIndex; j++)
			{
				if (freqList[j] > freqList[i])
				{
					Swap(ref dataList[j], ref dataList[i]); //15 10 13 10  ==> 10 15  13 10
					Swap(ref freqList[j], ref freqList[i]); // 1  2  1  2  ==> 2   1  1  2
				}
			}
		}
	}
}

class Coworker
{
	public static void DoTask_0(int[] ages, int size)
	{
		Console.WriteLine("Enter ages one by one:");
		MyArray.Read(ages, 0, size - 1);
		Console.WriteLine("The given ages are");
		MyArray.Print(ages, 0, size - 1);
	}
	public static void DoTask_1_v1(int[] ages, int size)//5Divisibility(Diff((Max and Min)))
	{
		int min = MyArray.FindMax(ages, 0, size - 1);
		int max = MyArray.FindMax(ages, 0, size - 1);
		int diff = MyArray.FindDiff(max, min);
		bool isDivisible = MyArray.IsDivisibleBy7(diff);
		Console.WriteLine("the min age is " + min);
		Console.WriteLine("the max age is " + max);
		Console.WriteLine("the diff of min and max age is " + diff);
		if (isDivisible)
			Console.WriteLine("the diff is divisible by 7");
		else
			Console.WriteLine("the diff is not divisible by 7");
	}
	public static void DoTask_1_v2(int[] ages, int size)//5Divisibility(Diff((Max and Min)))
	{
		int min = 0;
		int max = 0;
		int diff = 0;
		bool isDivisible = false;
		MyArray.FindMaxMinDiffIs7Divisible(ages, 0, size - 1,
			out min, out max, out diff, out isDivisible);
		Console.WriteLine("the min age is " + min);
		Console.WriteLine("the max age is " + max);
		Console.WriteLine("the diff of min and max age is " + diff);
		if (isDivisible)
			Console.WriteLine("the diff is divisible by 7");
		else
			Console.WriteLine("the diff is not divisible by 7");
	}

	public static void DoTask_2(int[] ages, int size)
	{
		int[] agesDistinct = new int[size];
		int count = 0;
		MyArray.DistinctAge(ages, 0, size - 1, agesDistinct, out count);
		Console.WriteLine("The distinct ages are");
		MyArray.Print(agesDistinct, 0, count - 1);
	}

	public static void DoTask_3(int[] ages, int size)
	{
		int[] freq = new int[size];

		MyArray.FindAgeFreq(ages, 0, size - 1, freq);
		Console.WriteLine("The list of age and frequency:");
		MyArray.PrintAgeFreq(ages, 0, size - 1, freq);
	}

	public static void DoTask_4(int[] ages, int size)
	{
		Console.WriteLine("Bofore Ascending Order, Ages:");
		MyArray.Print(ages, 0, size - 1);

		MyArray.SortAsc(ages, 0, size - 1);

		Console.WriteLine("After Ascending Order, Ages:");
		MyArray.Print(ages, 0, size - 1);
	}

	public static void DoTask_5(int[] ages, int size)
	{
		Console.WriteLine("Bofore Descending Order, Ages:");
		MyArray.Print(ages, 0, size - 1);

		MyArray.SortDesc(ages, 0, size - 1);

		Console.WriteLine("After Descending Order, Ages:");
		MyArray.Print(ages, 0, size - 1);
	}
	public static void DoTask_6(int[] ages, int size)
	{
		int[] freq = new int[size];

		MyArray.FindAgeFreq(ages, 0, size - 1, freq);
		Console.WriteLine("Bofore Descending Order by freq:");
		Console.WriteLine("The list of age and frequency:");
		MyArray.PrintAgeFreq(ages, 0, size - 1, freq);

		MyArray.SortAgeByFreqDesc(ages, 0, size - 1, freq);

		Console.WriteLine("After Descending Order by freq:");
		Console.WriteLine("The list of age and frequency:");
		MyArray.PrintAgeFreq(ages, 0, size - 1, freq);
	}

	public static void DoTask_7_v1(int[] ages, int size)//Count Even Odd
	{
		int eCount = 0;
		int oCount = 0;

		eCount = MyArray.CountEven(ages, 0, size - 1);
		oCount = MyArray.CountOdd(ages, 0, size - 1);

		Console.WriteLine($"The number of even ages:{eCount}");
		Console.WriteLine($"The number of odd ages:{oCount}");
	}
	public static void DoTask_7_v2(int[] ages, int size)//Count Even Odd
	{
		int eCount = 0;
		int oCount = 0;

		MyArray.CountEvenOdd(ages, 0, size - 1, out eCount, out oCount);

		Console.WriteLine($"The number of even ages:{eCount}");
		Console.WriteLine($"The number of odd ages:{oCount}");
	}
}

class Solve
{
	static void Main_v1()
	{
		Console.WriteLine("****Base Task:****");
		int size = 10;
		Console.WriteLine("Enter number of ages:");
		size = int.Parse(Console.ReadLine());
		int[] ages = new int[size];

		Coworker.DoTask_0(ages, size);

		Console.WriteLine("****Task 1:****"); Coworker.DoTask_1_v1(ages, size);
		Console.WriteLine("****Task 2:****"); Coworker.DoTask_2(ages, size);
		Console.WriteLine("****Task 3:****"); Coworker.DoTask_3(ages, size);
		Console.WriteLine("****Task 4:****"); Coworker.DoTask_4(ages, size);
		Console.WriteLine("****Task 5:****"); Coworker.DoTask_5(ages, size);
		Console.WriteLine("****Task 6:****"); Coworker.DoTask_6(ages, size);
		Console.WriteLine("****Task 7:****"); Coworker.DoTask_7_v1(ages, size);
		Console.WriteLine("****End!!!");
		Console.Read();
	}
	static void Main_v2()
	{
		Console.WriteLine("****Base Task:****");
		int size = 10;
		Console.WriteLine("Enter number of ages:");
		size = int.Parse(Console.ReadLine());
		int[] ages = new int[size];

		Coworker.DoTask_0(ages, size);

		Console.WriteLine("****Task 1:****"); Coworker.DoTask_1_v2(ages, size);
		Console.WriteLine("****Task 2:****"); Coworker.DoTask_2(ages, size);
		Console.WriteLine("****Task 3:****"); Coworker.DoTask_3(ages, size);
		Console.WriteLine("****Task 4:****"); Coworker.DoTask_4(ages, size);
		Console.WriteLine("****Task 5:****"); Coworker.DoTask_5(ages, size);
		Console.WriteLine("****Task 6:****"); Coworker.DoTask_6(ages, size);
		Console.WriteLine("****Task 7:****"); Coworker.DoTask_7_v2(ages, size);
		Console.WriteLine("****End!!!");
		Console.Read();
	}

	static void Main()
	{
		//Main_v1();
		Main_v2();
	}
}