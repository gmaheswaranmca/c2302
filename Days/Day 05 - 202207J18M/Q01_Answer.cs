using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCY2302
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstSalary = 0.0;
            double secondSalary = 0.0;
            double thirdSalary = 0.0;
            //Read salaries
            Console.Write("Enter first salary:");
            firstSalary = double.Parse(Console.ReadLine());

            Console.Write("Enter second salary:");
            secondSalary = double.Parse(Console.ReadLine());

            Console.Write("Enter third salary:");
            thirdSalary = double.Parse(Console.ReadLine()); //6000 5000 5500

            //finding largest
            double largestSalary = double.MinValue; //-ve 
            if(firstSalary > largestSalary) 
            {
                largestSalary = firstSalary; 
            }

            if (secondSalary > largestSalary)
            {
                largestSalary = secondSalary;
            }

            if (thirdSalary > largestSalary)
            {
                largestSalary = thirdSalary;
            }

            //print the largest
            Console.WriteLine("largest of {0},{1} and {2} is {3}",
                firstSalary,
                secondSalary,
                thirdSalary,
                largestSalary);
            Console.Read();
        }
        static void Main03(string[] args)
        {
            double firstSalary = 0.0;
            double secondSalary = 0.0;
            double thirdSalary = 0.0;
            //Read salaries
            Console.Write("Enter first salary:");
            firstSalary = double.Parse(Console.ReadLine());

            Console.Write("Enter second salary:");
            secondSalary = double.Parse(Console.ReadLine());

            Console.Write("Enter third salary:");
            thirdSalary = double.Parse(Console.ReadLine());

            //finding largest
            double largestSalary = (firstSalary > secondSalary) ? (firstSalary > thirdSalary ? firstSalary : thirdSalary) : (secondSalary > thirdSalary ? secondSalary : thirdSalary);
            
            //print the largest
            Console.WriteLine("largest of {0},{1} and {2} is {3}",
                firstSalary,
                secondSalary,
                thirdSalary,
                largestSalary);
        }
        static void Main02(string[] args)
        {
            double firstSalary = 0.0;
            double secondSalary = 0.0;
            double thirdSalary = 0.0;
            //Read salaries
            Console.Write("Enter first salary:");
            firstSalary = double.Parse(Console.ReadLine());

            Console.Write("Enter second salary:");
            secondSalary = double.Parse(Console.ReadLine());

            Console.Write("Enter third salary:");
            thirdSalary = double.Parse(Console.ReadLine());

            //finding largest
            double largestSalary = 0.0;
            if (firstSalary > secondSalary)
            {
                if (firstSalary > thirdSalary)
                {
                    largestSalary = firstSalary;
                }
                else
                {
                    largestSalary = thirdSalary;
                }
            }
            else
            {
                if (secondSalary > thirdSalary)
                {
                    largestSalary = secondSalary;
                }
                else
                {
                    largestSalary = thirdSalary;
                }
            }
            //print the largest
            Console.WriteLine("largest of {0},{1} and {2} is {3}",
                firstSalary,
                secondSalary,
                thirdSalary,
                largestSalary);
        }
        static void Main01(string[] args)
        {
            double firstSalary = 0.0, secondSalary = 0.0, thirdSalary = 0.0;
            //Read salaries
            Console.Write("Enter first salary:");
            firstSalary = double.Parse(Console.ReadLine());

            Console.Write("Enter second salary:");
            secondSalary = double.Parse(Console.ReadLine());

            Console.Write("Enter third salary:");
            thirdSalary = double.Parse(Console.ReadLine());

            //finding largest
            double largestSalary = 0.0;
            if ((firstSalary > secondSalary) && (firstSalary > thirdSalary))
            {
                largestSalary = firstSalary;
            }
            else if (secondSalary > thirdSalary)
            {
                largestSalary = secondSalary;
            }
            else
            {
                largestSalary = thirdSalary;
            }

            //print the largest
            Console.WriteLine("largest of {0},{1} and {2} is {3}",
                firstSalary,
                secondSalary,
                thirdSalary,
                largestSalary);
        }
    }
}
