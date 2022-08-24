    delegate void OnAreaChangeDT(int sno, int length, int width, int area);//event delegate type
    class Piece
    {
        public event OnAreaChangeDT OnAreaChange;//declare event
        int sno;
        int length;
        int width;
        int area;

        public int Sno { get { return this.sno; } set { this.sno = value; } }
        public int Length { get { return this.length; } set {  this.length = value; this.Calculate(); } }
        public int Width { get { return this.width; } set {  this.width = value; this.Calculate(); } }
        public int Area { get { return this.area; }  }

        public Piece(int sno, int length, int width)
        {
            this.Sno = sno;
            this.Length = length;
            this.Width = width;
        }

        public void Calculate()
        {
            this.area = this.Length * this.Width;
            if(OnAreaChange != null)
            {
                OnAreaChange(this.Sno, this.Length, this.Width, this.Area);//raise event
            }
        }

        override public string ToString()
        {
            return $"[({Sno},{Length}\",{Width}\").area={Area}sq\"]";
        }
    }
    class InterierDesign
    {
        string historyOfPieces;

        Piece firstPiece;
        Piece secondPiece;

        public InterierDesign()
        {
            historyOfPieces = "";
            firstPiece = new Piece(1, 40, 20);
            firstPiece.OnAreaChange += firstPiece_OnAreaChange;
            secondPiece = new Piece(2, 60, 40);
            secondPiece.OnAreaChange += secondPiece_OnAreaChange;

            historyOfPieces += "\n\t" + firstPiece;
            historyOfPieces += "\n\t" + secondPiece;
        }

        public void SeePieceDetails()
        {
            Console.WriteLine($"Details of the pieces:");
            Console.WriteLine($"\t{firstPiece}");
            Console.WriteLine($"\t{secondPiece}");
        }

        void firstPiece_OnAreaChange(int sno, int length, int width, int area)
        {
            historyOfPieces += "\n" + $"\t[({sno},{length}\",{width}\")={area}sq\"]";
        }

        void secondPiece_OnAreaChange(int sno, int length, int width, int area)
        {
            historyOfPieces += "\n" + $"\t[({sno},{length}\",{width}\")={area}sq\"]";
        }

        public void ShowHistory()
        {
            Console.WriteLine("History of changes in the pieces from construction:");
            Console.WriteLine(historyOfPieces);
        }

        public void DoChangeInPieces()
        {
            int choice;
            Console.WriteLine("Choice(1-Piece#1 Length, 2-Piece#1 Width, 3-Piece#2 Length, 4-Piece#2 Width):");
            choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter length of piece#1:");
                    firstPiece.Length = int.Parse(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Enter width of piece#1:");
                    firstPiece.Width = int.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Enter length of piece#2:");
                    secondPiece.Length = int.Parse(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("Enter width of piece#2:");
                    secondPiece.Width = int.Parse(Console.ReadLine());
                    break;

            }
        }
    }
    
    class Solve
    {        
        static void Main()
        {
            InterierDesign design = new InterierDesign();
            design.SeePieceDetails();

            design.ShowHistory();

            do
            {
                Console.WriteLine("Are you sure to do changes in the pieces(yes/no)?");
                if(Console.ReadLine().ToLower() != "yes")
                {
                    break;
                }
                design.DoChangeInPieces();
                design.SeePieceDetails();
                design.ShowHistory();
            } while (true);

            Console.Read();
        }
    }