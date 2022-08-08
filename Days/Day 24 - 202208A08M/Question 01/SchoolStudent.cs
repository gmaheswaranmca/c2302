using System;

namespace AppDay06082022
{
    class SchoolStudent
    {
        protected int rollNumber;
        protected string studentName;
        protected int firstLanguageMark;
        protected int secondLanguageMark;
        protected int total;
        protected float average;

        protected static int nextRollNumber;

        public SchoolStudent(string p_studentName,
            int p_firstLanguageMark,
            int p_secondLanguageMark)
        {
            this.rollNumber = SchoolStudent.nextRollNumber;
            SchoolStudent.nextRollNumber++;

            this.studentName = p_studentName;
            this.firstLanguageMark = p_firstLanguageMark;
            this.secondLanguageMark = p_secondLanguageMark;
            this.total = 0;
            this.average = 0.0f;
        }
        public void Read()
        {
            Console.Write("Enter student name:");
            this.studentName = Console.ReadLine();
            Console.Write("Enter first language mark:");
            this.firstLanguageMark = int.Parse(Console.ReadLine());
            Console.Write("Enter second language mark:");
            this.secondLanguageMark = int.Parse(Console.ReadLine());
        }
        public void Calculate()
        {
            this.total = this.firstLanguageMark + this.secondLanguageMark;
            this.average = ((float)this.total / 3.0f);
        }
        public void Display()
        {
            Console.WriteLine($"Name: {this.studentName}");
            Console.WriteLine($"Roll Number: {this.rollNumber}");
            Console.WriteLine($"First Language Mark: {this.firstLanguageMark}");
            Console.WriteLine($"Second Language Mark: {this.secondLanguageMark}");
        }
        public void DisplayTotalAverage()
        {
            Console.WriteLine($"Total: {this.total}");
            Console.WriteLine($"Average: {this.average}");
        }
        public static void DisplayRollNumber()
        {
            Console.WriteLine($"Next Roll Number is {SchoolStudent.nextRollNumber}");
        }
        static SchoolStudent()
        {
            SchoolStudent.nextRollNumber = 1001;
        }
    }

}
