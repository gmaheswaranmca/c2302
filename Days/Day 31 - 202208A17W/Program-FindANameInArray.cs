using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App17082022
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("enter array size");
            size = Convert.ToInt32(Console.ReadLine());//5

            String[] r = new String[size];//gokul ramesh stutee chitra rahul 

            //to write the values
            for (int i = 0; i < r.Length; i++)
            {
                Console.WriteLine("enter array element");
                r[i] = (Console.ReadLine());

            }
            Console.WriteLine("enter search name");//chitra 	|    logesh 
            String sname = Console.ReadLine();

            int position = -1;
            for (int j = 0; j < r.Length; j++)
            {
                if (sname == r[j])
                {
                    position = j;
                    break;
                }
            }


            if (position != -1)
            {
                Console.WriteLine($"{sname} is found");
                Console.WriteLine($"{sname} is at location {position}");
            }
            else
            {
                Console.WriteLine($"{sname} is not found");
            }


            Console.Read();

        }
    }
}
