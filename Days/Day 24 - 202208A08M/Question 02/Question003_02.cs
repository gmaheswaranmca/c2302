using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDay06082022
{
    class Question003_02
    {
        static void MainQuestion003_02()
        {
            PrimarySchoolStudent firstChild = new PrimarySchoolStudent("", 0, 0, 0, 0); 
            HighSchoolStudent secondChild = new HighSchoolStudent("", 0,0, 0, 0, 0); 

            //Input
            Console.WriteLine("***************Enter Student Details:***************");
            firstChild.Read();
            secondChild.Read();
            //Process
            firstChild.Calculate();
            secondChild.Calculate();
            //Output
            Console.WriteLine();
            Console.WriteLine("Mark List:");
            Console.WriteLine("Student#1:");
            firstChild.Display();
            Console.WriteLine("Student#2:");
            secondChild.Display();
            SchoolStudent.DisplayRollNumber();    

            Console.WriteLine("Press any key to shutdown app!!!");
            Console.Read();
        }
    }
}
