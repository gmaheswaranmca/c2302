using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDay06082022
{
    class Question03
    {
        static void Main()
        {
            Console.WriteLine("We experiment the flight object ");
            Flight flight1 = new Flight();
            Flight flight2 = new Flight("","",0,0);
            Flight flight3 = new Flight(flight2);

            bool checker = true;
            
            Console.WriteLine("Enter 3 flight details source, destination, no of seats, ticket fare in each line:");
            flight1.Read();
            flight2.Read();
            flight3.Read();

            do
            {
                int optionTranType = 0, choiceForFlight = 0;


                Console.Write("Choice(1-Booking,2-Cancellation):");
                optionTranType = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Pick the flight");
                Console.Write("1."); flight1.DisplayAfterRead();
                Console.Write("2."); flight2.DisplayAfterRead();
                Console.Write("3."); flight3.DisplayAfterRead();
                Console.Write("Your choice(use the flight serial number): ");
                choiceForFlight = Convert.ToInt32(Console.ReadLine());
                
                if (optionTranType == 1)//---------------------For Booking-----------------------------------
                {
                    if (choiceForFlight == 1)//flight 1
                    {
                        flight1.BookATicket();
                    }
                    else if (choiceForFlight == 2)//flight 2
                    {
                        flight2.BookATicket();
                    }
                    else if (choiceForFlight == 3)//flight 3
                    {
                        flight3.BookATicket();
                    }
                }
                else if (optionTranType == 2)//-------------------------For Cancel---------------------------------
                {
                    if (choiceForFlight == 1)//flight 1
                    {
                        flight1.CancelATicket();
                    }
                    else if (choiceForFlight == 2)//flight 2
                    {
                        flight2.CancelATicket();
                    }
                    else if (choiceForFlight == 3)//flight 3
                    {
                        flight2.CancelATicket();
                    }
                }
                Console.WriteLine("Are you sure to continue (true/false)");
                checker = Convert.ToBoolean(Console.ReadLine());
            } while (checker);

            double turnOver = 0;

            flight1.Calculate();
            turnOver += flight1.GetTotalBookingAmount();

            flight2.Calculate();
            turnOver += flight2.GetTotalBookingAmount();
            
            flight3.Calculate();
            turnOver += flight3.GetTotalBookingAmount();

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Flight #1");
            flight1.display();
            
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Flight #2");
            flight2.display();
            
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Flight #3");
            flight3.display();
            
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Total TurnOver:{turnOver}");
            Console.WriteLine("----------------------------------------------------");


            Flight.Displaynextflightnumber();
            Console.Read();
        }
    }
}
