using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDay06082022
{
    class Question02_02
    {
        static void MainQuestion02_02(string[] args)
        {

            Student firstStudent = null;
            int N = 0;
            Console.Write("Enter number of students:");
            N = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter {N} students student name, mark 1, mark 2, mark 3 One By One:");
            string printOut = "";
            for (int I = 1; I <= N; I++)//XXXX+
            {
                //Input

                firstStudent = new Student();//XXXX
                Console.WriteLine($"Enter Details for Student#{I}");//XXXX+
                firstStudent.Read();

                //Processing ie Calcultion
                firstStudent.Calculate();

                //Ouput
                printOut += "\n";
                printOut += "\n" + $"Student#{I}";
                printOut += "\n" + firstStudent.DisplayString();
                printOut += "\n";

                //Console.WriteLine($"Student#{I}");
                //Console.WriteLine();//XXXX+
                //firstStudent.Display();
                //Console.WriteLine();//XXXX
            }
            Console.WriteLine("Mark List");
            Console.WriteLine(printOut);
            Student.DisplayRollNumber();
            Console.Read();
        }
    }
}
