using System;
//Class1:(Parent)

  class Account
    {
        protected int AccountNumber;
        protected string Name;
    public Account()
        {
            this.AccountNumber = 0;
            this.Name = " ";
        }
       virtual public void Read()
        {
            
        }
       virtual public float Calculate()
        {
            return 0;
        }
	}
//Class2:

    class SimpeInterest:Account
    {
        protected int principal;
        protected int duration;
        protected float rate;
      override  public void Read()
        {
            Console.WriteLine("Enter Account Number:");
            this.AccountNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Account Holder Name:");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter Principal Amount:");
            this.principal = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number of Years:");
            this.duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter rate of interst:");
            this.rate = float.Parse(Console.ReadLine());
        }
       override public float Calculate()
        {
            float p=this.principal, n=this.duration, r=this.rate, interst;
            interst = (p * n * r) / 100;
            return interst;


        }

    }

//class3:

    class CompoundInterest:Account
    {

        protected int principal;
        protected int duration;
        protected float rate;
        protected int times;
        
       override public void Read()
        {
            Console.WriteLine("Enter Account Number:");
            this.AccountNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Account Holder Name:");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter Principal Amount:");
            this.principal = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number of Years:");
            this.duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter rate of interst:");
            this.rate = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter increses number of times:");
            this.times = int.Parse(Console.ReadLine());

        }
       override public float Calculate()
        {
            float p = this.principal, t = this.duration, r = (this.rate/100),n=this.times, interst;
            interst = (p * (float)Math.Pow((1 + r / n), (n * t))) - p;
            return interst;


        }
    }

//Main Program:

    class Program
    {
        static void Main(string[] args)
        {
            float si, ci;
            Account acc = null;
            acc = new SimpeInterest();
            Console.WriteLine("Enter details for the SI");
            acc.Read();
            si = acc.Calculate();
            Console.WriteLine($"Si={si}");
            acc = new CompoundInterest();
            Console.WriteLine("Enter details for the Ci");
            acc.Read();
            ci = acc.Calculate();
            Console.WriteLine($"ci={ci}");
            Console.Read();



        }
    }


