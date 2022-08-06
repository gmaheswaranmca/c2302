using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDay06082022
{
    class Student
    {
        private int rollNumber;
        private string studentName;
        private int mark1;
        private int mark2;
        private int mark3;
        private int total;
        private float average;

        private static int nextRollNumber;

        public Student()
        {
            this.rollNumber = Student.nextRollNumber;
            Student.nextRollNumber++;

            this.studentName = "";
            this.mark1 = 0;
            this.mark2 = 0;
            this.mark3 = 0;
            this.total = 0;
            this.average = 0.0f;
        }
        public void Read()
        {
            this.studentName = Console.ReadLine();
            this.mark1 = int.Parse(Console.ReadLine());
            this.mark2 = int.Parse(Console.ReadLine());
            this.mark3 = int.Parse(Console.ReadLine());
        }
        public void Calculate()
        {
            this.total = this.mark1 + this.mark2 + this.mark3;
            this.average = ((float)this.total / 3.0f);
        }
        public void Display()
        {
            Console.WriteLine($"Name: {this.studentName}");
            Console.WriteLine($"Roll Number: {this.rollNumber}");
            Console.WriteLine($"Mark 1: {this.mark1}");
            Console.WriteLine($"Mark 2: {this.mark2}");
            Console.WriteLine($"Mark 3: {this.mark3}");
            Console.WriteLine($"Total: {this.total}");
            Console.WriteLine($"Average: {this.average}");
        }
        public static void DisplayRollNumber()
        {
            Console.WriteLine($"Next Roll Number is {Student.nextRollNumber}");
        }
        static Student()
        {
            Student.nextRollNumber = 1001;
        }
    }
}
