using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppDay06082022
{
    
    class Question003_01
    {
        static void MainQuestion003_01()
        {
            PrimarySchoolStudent firstChild = new PrimarySchoolStudent("",0,0,0,0); //I
            //SchoolStudent firstChild = new PrimarySchoolStudent("", 0, 0, 0, 0); //II // Do Switch I and II
            //Input
            Console.WriteLine("***************Enter Student Details:***************");
            firstChild.Read();
            //Process
            firstChild.Calculate();
            //Output
            Console.WriteLine();
            Console.WriteLine("Mark List:");
            Console.WriteLine("Student#1:");
            firstChild.Display();
            SchoolStudent.DisplayRollNumber();    //III
            //PrimarySchoolStudent.DisplayRollNumber();//IV   //Do Switch III and IV

            Console.WriteLine("Press any key to shutdown app!!!");
            Console.Read();
        }
    }
}
