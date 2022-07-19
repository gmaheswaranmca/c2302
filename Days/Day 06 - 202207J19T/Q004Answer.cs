using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCY2302
{
    internal class Q004Answer
    {
        static void Main02(string[] args)
        {
            short age = 0;

            //read age
            Console.Write("Enter age of the person:");
            age = short.Parse(Console.ReadLine());
            //is age given is valid 
            if (age < 0)
            {
                Console.WriteLine("Invalid age.");
                return;
            }
            //what is the person category from given age 

            switch (age)
            {
                case 0:
                    Console.WriteLine("The person is infant.");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("The person is toddler.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("The person is studying kinder garden.");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("The person is studying primary lower school.");
                    break;
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("The person is studying primary upper school.");
                    break;
                case 11:
                case 12:
                case 13:
                    Console.WriteLine("The person is studying lower high school.");
                    break;
                case 14:
                case 15:
                    Console.WriteLine("The person is studying upper high school.");
                    break;
                case 16:
                case 17:
                    Console.WriteLine("The person is studying senior secondary school.");
                    break;
                case 18:
                case 19:
                case 20:
                case 21:
                    Console.WriteLine("The person is studying college.");
                    break;
                default:
                    Console.WriteLine("The person is graduated.");
                    break;
            }

            Console.Read();
        }
        static void Main01(string[] args)
        {
            short age = 0;
            //read age
            Console.Write("Enter age of the person:");
            age = short.Parse(Console.ReadLine());
            //is age given is valid 
            if (age < 0)
            {
                Console.WriteLine("Invalid age.");
                return;
            }
            //what is the person category from given age 


            if (age == 0)
            {
                Console.WriteLine("The person is infant.");
            }
            else if ((age == 1) || (age == 2))
            {
                Console.WriteLine("The person is toddler.");
            }
            //else if ((3 <= age) && (age <= 5)) //age bt 3 and 5    3 <= age <= 5
            else if ((age == 3) || (age == 4) || (age == 5))
            {
                Console.WriteLine("The person is studying kinder garden.");
            }
            else if ((age == 6) || (age == 7))
            {
                Console.WriteLine("The person is studying primary lower school.");
            }
            else if ((age == 8) || (age == 9) || (age == 10))
            {
                Console.WriteLine("The person is studying primary upper school.");
            }
            else if ((age == 11) || (age == 12) || (age == 13))
            {
                Console.WriteLine("The person is studying lower high school.");
            }
            else if ((age == 14) || (age == 15))
            {
                Console.WriteLine("The person is studying upper high school.");
            }
            else if ((age == 16) || (age == 17))
            {
                Console.WriteLine("The person is studying senior secondary school.");
            }
            else if ((age == 18) || (age == 19) || (age == 20) || (age == 21))
            {
                Console.WriteLine("The person is studying college.");
            }
            else
            {
                Console.WriteLine("The person is graduated.");
            }
            Console.Read();
        }
    }
}
