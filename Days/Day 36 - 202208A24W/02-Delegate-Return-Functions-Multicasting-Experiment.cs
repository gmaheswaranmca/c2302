//Delegate Multicasting to undestrand three return functions 
//By calling multicasted delegate object, 
//			the last function return value we will get
//			after all the functions called

class Multiplication
{
	private int offset = 100;
	public int FindProduct(int first, int second)
	{
		Console.WriteLine("FindProduct...");
		return (first * second) + this.offset;
	}
}

delegate int OperationDT(int first, int second);

class Solve
{
	static int FindSum(int first, int second)
	{
		Console.WriteLine("FindSum...");
		return first + second;
	}

	static int FindDiff(int first, int second)
	{
		Console.WriteLine("FindDiff...");
		return first - second;
	}

	static void Main()
	{
		Multiplication multiplication = new Multiplication();

		OperationDT op = FindSum;
		op += Solve.FindDiff;
		op += multiplication.FindProduct;

		Console.WriteLine("product of 2 and 3 is " + op(2, 3));

		op -= multiplication.FindProduct;
		Console.WriteLine("product of 2 and 3 is " + op(2, 3));
		

		Console.Read();
	}
}
