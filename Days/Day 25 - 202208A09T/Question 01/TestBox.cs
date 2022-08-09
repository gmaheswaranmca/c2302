using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDay06082022
{
    class TestBox
    {
        static void MainTestBox()
        {
            /*
            Rectangle rect = new Rectangle();
            //Input
            Console.WriteLine("Enter the rectangle details");
            rect.ReadRectangle();
            //Process
            int area = rect.FindArea();
            int circumfernce = rect.FindCircumference();
            //Output
            Console.WriteLine("The details of the rectangle is");
            rect.PrintRectangle();
            Console.WriteLine($"Area:{area}");
            Console.WriteLine($"Circumference:{circumfernce}");
            */

            Box box = new Box();
            //Input
            Console.WriteLine("Enter the box details");
            box.ReadBox();
            //Process
            int area = box.FindArea();
            int circumfernce = box.FindCircumference();
            int volume = box.FindVolume();
            //Output
            Console.WriteLine("The details of the box is");
            box.PrintBox();
            Console.WriteLine($"Area of bottom face:{area}");
            Console.WriteLine($"Circumference of bottom face:{circumfernce}");
            Console.WriteLine($"Volume:{volume}");


            /*
            Rectangle rect = box;
            rect.PrintRectangle();//Valid call
            rect.PrintBox();//Syntax Error 
            */

            Console.Read();
        }
    }
}
