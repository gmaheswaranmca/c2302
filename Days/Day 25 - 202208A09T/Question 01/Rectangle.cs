using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDay06082022
{
    class Rectangle
    {
        protected int length;
        protected int width;

        public Rectangle()
        {
            //Console.WriteLine("I am in Rectangle constructor");
            this.length = 0;
            this.width = 0;
        }
        public void ReadRectangle()
        {
            Console.Write("Enter length:");
            this.length = int.Parse(Console.ReadLine());

            Console.Write("Enter width:");
            this.width = int.Parse(Console.ReadLine());
        }
        public void PrintRectangle()
        {
            Console.WriteLine($"Length:{this.length}");
            Console.WriteLine($"Width:{this.width}");
        }
        public int FindArea()
        {
            return this.length * this.width;
        }

        public int FindCircumference()
        {
            return 2 * (this.length + this.width);
        }

    }
}
