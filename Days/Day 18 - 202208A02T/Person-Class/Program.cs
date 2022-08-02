using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsLearningApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person maheswaran = new Person();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Enter personal details of maheswaran:");
            Console.WriteLine("-----------------------------------------");
            maheswaran.Read();

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Maheswaran profile is");
            Console.WriteLine("-----------------------------------------");
            maheswaran.Print();

            Person gokulraj = new Person();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Enter personal details of gokulraj:");
            Console.WriteLine("-----------------------------------------");
            gokulraj.Read();


            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("gokulraj profile is");
            Console.WriteLine("-----------------------------------------");
            gokulraj.Print();

            Console.Read();
        }
    }
}
