using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCY2302
{
    internal class Q005Answer
    {
        static void Main01(string[] args)
        {
            int start = 0; //1
            int end = 0; //20


            //Read number range
            Console.Write("Enter start number of the range:");
            start = int.Parse(Console.ReadLine());

            Console.Write("Enter end number of the range:");
            end = int.Parse(Console.ReadLine());


            //count if number in range is divisible by 3/5/7
            int count = 0;//->1->2->3->4->5->6->7->8->9->10->11
            for (int num = start; (num <= end); num++)//1T  2T 3T 4T 5T 6T 7T 8T 9T 10T 11T 12T 13T 14T 15T 16T 17T 18T 19T 20T 21F
            {
                if (((num % 3) == 0) || ((num % 5) == 0) || ((num % 7) == 0))//F F T F T T T F T T F T F T T F F T F T
                {
                    count++; //X X 1 X 2 3 4 X 5 6 X 7 X 8 9 X X 10 X 11
                }
            }

            //initialization-condition => statements => incrementOrDecrement-condition => statements
            //incrementOrDecrement-condition => statements => continued till condition is true  

            //Print count 
            Console.WriteLine("The given range is {0}-{1}",
                start,
                end);
            Console.WriteLine("The number of numbers which are divisible by 3/5/7 is {0}",
                count);
            Console.Read();

        }
    }
}
