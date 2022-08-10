 abstract class Account
    {
        protected int AccountNumber;
        protected string Name;
        public Account()
        {
            this.AccountNumber = 0;
            this.Name = " ";
        }
        abstract public void Read();

        abstract public float Calculate();
    }
    class SimpeInterest : Account
    {
        protected int principal;
        protected int duration;
        protected float rate;
        override public void Read()
        {
            Console.WriteLine("I am in SimpeInterest Read().");

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
            float p = this.principal, n = this.duration, r = this.rate, interst;
            interst = (p * n * r) / 100;
            return interst;


        }

    }
    class CompoundInterest : Account
    {

        protected int principal;
        protected int duration;
        protected float rate;
        protected int times;

        override public void Read()
        {
            Console.WriteLine("I am in CompoundInterest Read().");

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
            float p = this.principal, t = this.duration, r = (this.rate / 100), n = this.times, interst;
            interst = (p * (float)Math.Pow((1 + r / n), (n * t))) - p;
            return interst;


        }
    }

    class Day220810
    {
        static void Main()
        {
            float si, ci;

            Account acc = null;

            acc = new SimpeInterest();
            Console.WriteLine("Enter details for the SI");
            Console.WriteLine("*****************Parent*************");
            acc.Read();
            Console.WriteLine("*****************Child*************");
            ((SimpeInterest)acc).Read();

            float si1 = ((SimpeInterest)acc).Calculate();
            si = acc.Calculate();

            Console.WriteLine($"Si={si}");
            Console.WriteLine($"Si1={si1}");

            acc = new CompoundInterest();
            Console.WriteLine("Enter details for the Ci");

            Console.WriteLine("*****************Parent*************");
            acc.Read();
            Console.WriteLine("*****************Child*************");
            ((CompoundInterest)acc).Read();

            float ci1 = ((CompoundInterest)acc).Calculate();
            ci = acc.Calculate();

            Console.WriteLine($"ci={ci}");
            Console.WriteLine($"ci1={ci1}");
            Console.Read();
        }
    }