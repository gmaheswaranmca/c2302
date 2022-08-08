using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDay06082022
{
    class Flight
    {
        private int fightNumber;
        private string sourcePoint;
        private string destinationPoint;
        private int noOfSeats;
        private float ticketFare;
        private int noOfBookedSeats;
        private int noOfAvailableSeats;
        private float totalBookingAmount;

        private static int nextflightnumber;


        public Flight(): this("","",0,0)
        {
            
        }
        public Flight(string p_sourcePoint, string p_destinationPoint,int p_noOfSeats, float p_ticketFare)
        {
            this.fightNumber = Flight.nextflightnumber;
            Flight.nextflightnumber++;

            this.sourcePoint = p_sourcePoint;
            this.destinationPoint = p_destinationPoint;
            this.noOfSeats = p_noOfSeats;
            this.ticketFare = p_ticketFare;
            this.noOfBookedSeats = 0;
            this.noOfAvailableSeats = 0;
            this.totalBookingAmount = 0;
        }
        public Flight(Flight anotherFlight) : this(anotherFlight.sourcePoint, anotherFlight.destinationPoint, anotherFlight.noOfSeats, anotherFlight.ticketFare)
        {

        }
        public void Read()
        //flightNumber, noOfAvailableSeats and totalBookingAmount
        {
            this.sourcePoint = Console.ReadLine();
            this.destinationPoint = Console.ReadLine();
            this.noOfSeats = int.Parse(Console.ReadLine());
            this.ticketFare = (float)int.Parse(Console.ReadLine());

        }
        public void Calculate()
        {
            this.noOfAvailableSeats = this.noOfSeats - this.noOfBookedSeats;
            this.totalBookingAmount = this.ticketFare * this.noOfBookedSeats;
        }
        public void BookATicket()
        {
            this.noOfBookedSeats++;
        }
        public void CancelATicket()
        {
            this.noOfBookedSeats--;

        }
        public void display()
        {
            Console.WriteLine($"Flight No: {this.fightNumber}");
            Console.WriteLine($"Source Point: {this.sourcePoint}");
            Console.WriteLine($"Destination Point: {this.destinationPoint}");
            Console.WriteLine($"No of Seats: {this.noOfSeats}");
            Console.WriteLine($"No of Booked Seats: {this.noOfBookedSeats}");
            Console.WriteLine($"Ticket Fare: {this.ticketFare}");
            Console.WriteLine($"Total Booking Amount: {this.totalBookingAmount}");
            Console.WriteLine($"No of Available Seats: {this.noOfAvailableSeats}");

        }
        public double GetTotalBookingAmount()
        {

            return this.totalBookingAmount;

        }


        public void DisplayAfterRead()
        {
            Console.WriteLine("(" + this.fightNumber + ")" + this.sourcePoint + "-" + this.destinationPoint);

        }
        public static void Displaynextflightnumber()
        {

            Console.WriteLine($"Next Flight Number is {Flight.nextflightnumber}");
        }

        static Flight()
        {
            nextflightnumber = 1011;
        }
    }
}
