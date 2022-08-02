using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsLearningApp
{
    class Person
    {
        private string name;
        private string place;
        private string phoneNumber;
        private int age;
        private string dateOfBirth;

        public void Read()
        {
            Console.WriteLine("Enter Name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter Place:");
            place = Console.ReadLine();

            Console.WriteLine("Enter Phone Number:");
            phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Age:");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Date Of Birth:");
            dateOfBirth = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine($"Name:{name}");
            Console.WriteLine($"Place:{place}");
            Console.WriteLine($"Phone Number:{phoneNumber}");
            Console.WriteLine($"Age:{age}");
            Console.WriteLine($"Date Of Birth:{dateOfBirth}");
        }
    }
}
