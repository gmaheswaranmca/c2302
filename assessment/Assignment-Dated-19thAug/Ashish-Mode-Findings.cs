public static void mode(int[] dataList, int startIndex, int endIndex, int[] freqList)
{
	
	SortAgeByFreqDesc(dataList, startIndex, endIndex, freqList);
	if (freqList[0] > freqList[1])
	{
		Console.WriteLine($"Mode is: {dataList[0]} and Occurence is {freqList[0]} ");
	}
	else 
	{
		int maxFreq = freqList[0];
		for(int i = startIndex; i<=endIndex;i++)
		{
			if (freqList[i] > maxFreq)
			{
				maxFreq = dataList[i];
			}
		}
		Console.WriteLine("No of Modes present: ");
		for (int i = startIndex; i <= endIndex; i++)
		{
			if (freqList[i] == maxFreq)
			{
				Console.WriteLine($"{dataList[i]} , Freq:{freqList[i]}");
			}
		}
	}
}
	
public static void DoTask_8(int[] ages, int size)
{
	int[] freq = new int[size];
	MyArray.FindAgeFreq(ages, 0, size - 1, freq);
	Console.WriteLine("Bofore Descending Order by freq:");
	Console.WriteLine("The list of age and frequency:");
	MyArray.PrintAgeFreq(ages, 0, size - 1, freq);
	MyArray.mode(ages, 0, size - 1, freq);
}
	
	