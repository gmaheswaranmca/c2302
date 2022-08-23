/*Calculator 
	FindSum
	FindDiff
	FindProduct
	FindQuotient 

MyUtil
	DoCalculate(first,second,operation)
Main
	Choice 1-Additon, 2-Subtraction, 3-Multiplication, 4-Division
	
	
Menu Driven Arithmetic Operations:
*/

class Calculator
    {
        public static int FindSum(int first, int second)
        {
            return first + second;
        }

        public static int FindDiff(int first, int second)
        {
            return first - second;
        }
        public static int FindProduct(int first, int second)
        {
            return first * second;
        }
        public static int FindQuotient(int first, int second)
        {
            return first / second;
        }
    }
    class MyUtil
    {
        public static int DoCalculate(int first, int second, int operationType)
        {
            if (operationType == 2)
                return Calculator.FindDiff(first, second);
            else if (operationType == 3)
                return Calculator.FindProduct(first, second);
            else if (operationType == 4)
                return Calculator.FindQuotient(first, second);
            else 
                return Calculator.FindSum(first, second);
        }
    }

    class Solve
    {
       
        static void Main()
        {
            int first;
            int second;

            Console.WriteLine("Enter First Number:");
            first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            second = int.Parse(Console.ReadLine());

            int choice;
            do
            {
                Console.Write("Choice (1-Add, 2-Subtract, 3-Multiply, 4-Divide, 0-Exit):");
                choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.WriteLine($"Sum of {first} and {second} is " +
                            MyUtil.DoCalculate(first, second, 1));
                        break;
                    case 2:
                        Console.WriteLine($"Diff of {first} and {second} is " +
                            MyUtil.DoCalculate(first, second, 2));
                        break;
                    case 3:
                        Console.WriteLine($"Product of {first} and {second} is " +
                            MyUtil.DoCalculate(first, second, 3));
                        break;
                    case 4:
                        Console.WriteLine($"Quotient of {first} and {second} is " +
                            MyUtil.DoCalculate(first, second, 4));
                        break;
                    default:
                        Console.WriteLine("End of Program...");
                        break;
                }

            } while (choice != 0);

            Console.Read();
        }
    }	
	