public delegate void OnTrainFullyReservedDT(); //1
public class TrainOutOfCapcity:Exception//A
{
	public override string ToString()
	{
		return "Train is out of capacity";
	}
}

public class Train
{
	private int trainNumber;
	private int capacity;
	private int bookings;
	public int TrainNumber { get { return trainNumber; } set { trainNumber = value; } }
	public int Capacity { get { return capacity; } set { capacity = value; } }
	public int Bookings { get { return bookings; } set { bookings = value; } }

	public event OnTrainFullyReservedDT OnTrainFullyReserved;//2

	public Train(int trainNumber, int capacity)
	{
		this.TrainNumber = trainNumber;
		this.Capacity = capacity;
		this.Bookings = 0;
	}

	public override string ToString()
	{
		return $"{TrainNumber}:Bookings={Bookings}/{Capacity}";
	}
	public void BookTickets(int qty)
	{
		//Validation
		if(qty <= 0)
		{
			Console.WriteLine("Tickets qty has to be postive number"); // Throw another user-defined exception
			return;                                                    // exception : InvalidTicketsQty
		}

		if((Bookings + qty) > Capacity) //qty>0
		{
			throw new TrainOutOfCapcity();//B 
		}


		// Task Code
		Bookings = Bookings + qty;
		if (Bookings == Capacity)
		{
			if (OnTrainFullyReserved != null)//3(a)
			{
				OnTrainFullyReserved();//3(b)
			}
		}
		
	}
}
public class Program
{
	public static void train_OnTrainFullyReserved()//4
	{
		Console.WriteLine("Train is fully reserved.");
	}

	public static void train2_OnTrainFullyReserved()//4
	{
		Console.WriteLine("The Train 2 is fully reserved.");
	}

	public static void Main()
	{

		Train train = new Train(1001, 10);
		train.OnTrainFullyReserved += train_OnTrainFullyReserved;//5

		Train train2 = new Train(1002, 10);
		train2.OnTrainFullyReserved += train2_OnTrainFullyReserved;//5

		Console.WriteLine("Before Bookings:" + train);
		try//C
		{ 
			train.BookTickets(6);
		}
		catch(TrainOutOfCapcity ex)//C
		{
			Console.WriteLine($"{ex}");
		}
		Console.WriteLine("After Bookings:" + train);

		Console.WriteLine("Before Bookings:" + train2);
		try//C
		{
			train2.BookTickets(7);
		}
		catch (TrainOutOfCapcity ex)//C
		{
			Console.WriteLine($"{ex}");
		}
		
		Console.WriteLine("After Bookings:" + train2);

		Console.WriteLine("Before Bookings:" + train);

		try//C
		{
			train.BookTickets(4);
		}
		catch (TrainOutOfCapcity ex)//C
		{
			Console.WriteLine($"{ex}");
		}
		Console.WriteLine("After Bookings:" + train);

		Console.WriteLine("Before Bookings:" + train2);
		try//C
		{
			train2.BookTickets(5);
		}
		catch (TrainOutOfCapcity ex)//C
		{
			Console.WriteLine($"{ex}");
		}
		Console.WriteLine("After Bookings:" + train2);


		Console.WriteLine("Before Bookings:" + train2);
		train2.BookTickets(0);
		Console.WriteLine("After Bookings:" + train2);


		Console.WriteLine("Before Bookings:" + train2);
		train2.BookTickets(-5);
		Console.WriteLine("After Bookings:" + train2);

		Console.Read();
	}
}