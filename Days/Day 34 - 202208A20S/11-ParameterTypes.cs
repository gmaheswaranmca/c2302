class Program
{
	//IN     INOUT      OUT 
	static void SwapDatav1(int first, int second)//IN params
	{
		int temp = first;
		first = second;
		second = temp;
	}
	static void SwapDatav2(ref int first, ref int second)//INOUT
	{
		int temp = first;
		first = second;
		second = temp;
	}

	static void SwapDatav3(out int first, out int second)//OUT
	{
		//int temp = first;//ERR
		//first = second;//ERR
		//second = temp;
		first = 1234;
		second = 2345;
	}


	static void Main(string[] args)
	{
		int x = 10;
		int y = 20;

		/*
		Console.WriteLine($"Before Swap x={x} y={y}");//10 20
		SwapDatav1(x, y);
		Console.WriteLine($"Before Swap x={x} y={y}");//10 20
		*/

		/*
		Console.WriteLine($"Before Swap x={x} y={y}");//10 20
		SwapDatav2(ref x, ref y);
		Console.WriteLine($"Before Swap x={x} y={y}");//10 20
		*/

		Console.WriteLine($"Before Swap x={x} y={y}");//10 20
		SwapDatav3(out x,out  y);
		Console.WriteLine($"Before Swap x={x} y={y}");//10 20


		Console.Read();
	}
}