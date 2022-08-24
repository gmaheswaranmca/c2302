//By just assigning the function name, delegate object is created

class Multiplication
{
	private int offset = 100;
	public int FindProduct(int first, int second)
	{
		return (first * second) + this.offset;
	}
}

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
		Multiplication multiplication = new Multiplication();

		Console.WriteLine("sum of 2 and 3 is " + FindSum(2, 3));

		OperationDT op = FindSum;//Assigning the function name to the delegate, auto delegate object is created
		Console.WriteLine("sum of 2 and 3 is " + op(2, 3));

		op = new OperationDT(Solve.FindDiff);//delegate objects construction using function as arg
		Console.WriteLine("diff of 2 and 3 is " + op(2, 3));

		op = multiplication.FindProduct;//delegate auto object by assiging function 
		Console.WriteLine("product of 2 and 3 is " + op(2, 3));

		Console.Read();
	}
}