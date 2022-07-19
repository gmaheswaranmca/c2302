using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCY2302
{
    internal class Q006Answer
    {
        static void Main01(string[] args)
        {
            int start = 1;
            int end = 100;


            //count number of even numbers
            int count = 0;
            for (int num = start; (num <= end); num++)
            {
                if ((20 <= num) && (num <= 40)) //20 <= num <= 40
                {
                    continue;
                }

                if ((num % 2) == 0)
                {
                    count++;
                }
            }

            //Print count 
            Console.WriteLine("The number of even numbers as per Qn is {0}",
                count);
            Console.Read();

        }
    }
}
