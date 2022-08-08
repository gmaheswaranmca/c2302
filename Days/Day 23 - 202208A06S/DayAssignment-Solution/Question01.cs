static void Main(string[] args)
{
	int n;
	n = Convert.ToInt32(Console.ReadLine());
	int num = 10;
	int i = 1;
	while (i <= n)
	{
		int k = 1;
		 while(k <= n - i)
		{
			char ch = ' ';
			Console.Write($"{ch,3} ");
			k++;
		}
		int j = 1;
		int temp=0;
		while (j <= i)
		{
			temp = num;
			Console.Write($"{num,3} ");
			num = num + 10;
			j++;
		}
		temp = temp - 10;
		j = 1;
		while (j <= i-1)
		{
			Console.Write($"{temp,3} ");
			temp = temp - 10;
			j++;
		}
		Console.WriteLine();
		i++;
	}
	Console.ReadLine();

}	