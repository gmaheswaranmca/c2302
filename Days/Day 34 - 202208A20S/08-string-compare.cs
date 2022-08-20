static void Main(string[] args)
{
	Console.WriteLine("apple apple=" + string.Compare("apple", "apple"));
	Console.WriteLine("apple banana=" + string.Compare("apple", "banana"));
	Console.WriteLine("banana apple=" + string.Compare("banana", "apple"));
	Console.WriteLine("apple zeebra=" + string.Compare("apple", "zeebra"));
	Console.WriteLine("zeebra apple=" + string.Compare("zeebra", "apple"));
	Console.WriteLine("APPLE apple=" + string.Compare("APPLE", "apple"));
	Console.WriteLine("APPLE apple=" + string.Compare("APPLE", "apple",true));//ignore case

	Console.WriteLine("appleIsRed apple=" + string.Compare("appleIsRed", "apple"));
	Console.Read();
}