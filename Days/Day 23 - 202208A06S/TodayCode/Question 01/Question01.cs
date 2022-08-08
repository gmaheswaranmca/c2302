using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDay06082022
{
    class Question01
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student();
            Student secondStudent = new Student();
            //Input
            Console.WriteLine("Enter 2 students student name, mark 1, mark 2, mark 3 in each line:");
            firstStudent.Read();
            secondStudent.Read();
            //Processing ie Calcultion
            firstStudent.Calculate();
            secondStudent.Calculate();
            //Ouput
            Console.WriteLine("Mark List");
            Console.WriteLine("Student#1");
            firstStudent.Display();
            Console.WriteLine("Student#2");
            secondStudent.Display();
            Student.DisplayRollNumber();
            Console.Read();
        }
    }
}
