using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDay06082022
{
    class Question02
    {
        static void Main(string[] args)
        {   

            Student firstStudent = null;
            int N = 0;
            Console.Write("Enter number of students:");
            N = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter {N} students student name, mark 1, mark 2, mark 3 One By One:");
            for (int I = 1; I <= N; I++)//XXXX+
            {
                //Input
                
                firstStudent = new Student();//XXXX
                Console.WriteLine($"Enter Details for Student#{I}");//XXXX+
                firstStudent.Read();
         
                //Processing ie Calcultion
                firstStudent.Calculate();

                //Ouput
                Console.WriteLine();//XXXX+
                Console.WriteLine("Mark List");
                Console.WriteLine($"Student#{I}");//XXXX
                firstStudent.Display();
            }
            Student.DisplayRollNumber();
            Console.Read();
        }
    }
}
