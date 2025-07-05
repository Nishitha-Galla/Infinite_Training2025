using ConcessionLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionApp
{
    class Program
    {

        const double TotalFare = 500; 
        static void Main(string[] args)
        {
            Console.Write("Enter you name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            TravelConcession tc = new TravelConcession();
            tc.CalculateConcession(name, age, TotalFare);

            Console.ReadLine();
        }
    }
}
