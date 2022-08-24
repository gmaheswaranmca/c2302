delegate void OnAreaChangeDT();
class Rectangle
{
	public event OnAreaChangeDT OnAreaChange;

	public void Calculate()
	{
		//raise the event -- publish the event 
		Console.WriteLine("Here we are going to calculate the area");
		if(OnAreaChange != null) { 
			OnAreaChange();
		}
	}
}
delegate void OnTotalMarkChangeDT();
class Student
{
	public event OnTotalMarkChangeDT OnTotalMarkChange;
	public void ProcessMarks()
	{
		Console.WriteLine("Here we are going to process the mark list");
		if (OnTotalMarkChange != null)
		{
			OnTotalMarkChange();
		}
	}
}

class Consumer
{
	Rectangle display;
	Student gokul;

	public Consumer()
	{
		display = new Rectangle();
		display.OnAreaChange += display_OnAreaChange; 

		gokul = new Student();
		gokul.OnTotalMarkChange += gokul_OnTotalMarkChange;
	}

	public void DoSomethoning()
	{
		display.Calculate();
		gokul.ProcessMarks();
	}

	void display_OnAreaChange()
	{
		Console.WriteLine("display::OnAreaChange is hanlded");
	}
	void gokul_OnTotalMarkChange()
	{
		Console.WriteLine("gokul::OnTotalMarkChange is hanlded");
	}
}
class Solve
{
   

	static void Main()
	{
		Consumer stutee = new Consumer();
		stutee.DoSomethoning();

		Console.Read();
	}
}