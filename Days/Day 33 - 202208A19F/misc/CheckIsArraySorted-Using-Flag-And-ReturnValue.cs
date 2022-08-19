static bool IsArraySortedAsc(int[] dataList, int size)//each element<=nextElement --> true, otherwise false 
{
	int StartIndex = 0;
	int EndIndex = size - 1;
	bool isSorted = true;
	for (int i = StartIndex; i <= (EndIndex-1); i++)
	{
		if(dataList[i] > dataList[i+1])
		{
			isSorted = false;
			break;
		}
	}

	return isSorted;
}

static bool IsArraySortedAsc(int[] dataList, int size)//each element<=nextElement --> true, otherwise false 
{
	int StartIndex = 0;
	int EndIndex = size - 1;
   
	for (int i = StartIndex; i <= (EndIndex-1); i++)
	{
		if(dataList[i] > dataList[i+1])
		{
			return false;
		}
	}

	return true;
}









