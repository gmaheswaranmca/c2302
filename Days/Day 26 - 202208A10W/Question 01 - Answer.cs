using System;

internal class Shape
{
	public int FindArea(int breadth , int height)
	{
		return breadth * height;
	}
	public float FindArea(int radius)
	{
		return 3.14f * radius * radius;
	}
	public int FindArea(int length,int width,int height)
	{
		return (2 * length * width) + (2 * width * height) + (2 * length * height);
	}
}

class Solution
{
static void Main(string[] args)
{
	Shape shape = new Shape();
	Console.WriteLine("Breadth of a triangle :");
	int Breadth = int.Parse(Console.ReadLine());
	Console.WriteLine("Height of the triangle :");
	int Height = int.Parse(Console.ReadLine());
	//shape.FindArea(Breadth, Height);
	Console.WriteLine($"Area of the Triangle :{shape.FindArea(Breadth,Height)}");
	Console.WriteLine("Radius of a circle : ");
	int radius=int.Parse(Console.ReadLine());
	//shape.FindArea(radius);
	Console.WriteLine($"Area of the circle :{shape.FindArea(radius)}");
	Console.WriteLine("Length of the box : ");
	int Length = int.Parse(Console.ReadLine());
	Console.WriteLine("width of the box : ");
	int Width=int.Parse(Console.ReadLine());
	Console.WriteLine("Height of the triangle");
	int height=int.Parse(Console.ReadLine());
	//shape.FindArea(Length,Width,height);
	Console.WriteLine($"Area of the box : {shape.FindArea(Length, Breadth, height)}");
	Console.Read();
}
}	