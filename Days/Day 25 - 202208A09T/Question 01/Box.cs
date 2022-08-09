using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDay06082022
{
    class Box:Rectangle
    {
        protected int height;
        public Box()//:base()
        {
            //Console.WriteLine("I am in Box constructor");
            this.height = 0;
        }
        public void ReadBox()
        {
            /*
            Console.Write("Enter length:");
            base.length = int.Parse(Console.ReadLine());

            Console.Write("Enter width:");
            base.width = int.Parse(Console.ReadLine());            
            */

            base.ReadRectangle();
            Console.Write("Enter height:");
            this.height = int.Parse(Console.ReadLine());
        }

        public void PrintBox()
        {
            /*
            Console.WriteLine($"Length:{this.length}");
            Console.WriteLine($"Width:{this.width}");            
            */

            base.PrintRectangle();
            Console.WriteLine($"height:{this.height}");
        }

        public int FindVolume()
        {
            return base.length * base.width * this.height;
        }
    }
}
