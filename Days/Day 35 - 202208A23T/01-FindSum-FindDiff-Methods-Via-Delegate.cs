delegate int OperationDT(int first, int second);

class Solve
{
	static int FindSum(int first, int second)
	{
		return first + second;
	}

	static int FindDiff(int first, int second)
	{
		return first - second;
	}

	static void Main()
	{
		Console.WriteLine("sum of 2 and 3 is " + FindSum(2, 3));

		OperationDT op = new OperationDT(FindSum);//sum refers the method FindSum !!! FindSum and type of sum signature are same
		Console.WriteLine("sum of 2 and 3 is " + op(2, 3));

		op = new OperationDT(FindDiff);
		Console.WriteLine("diff of 2 and 3 is " + op(2, 3));

		Console.Read();
	}
}