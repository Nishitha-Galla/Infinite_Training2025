using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionLib
{
    public class TravelConcession
    {
        public void CalculateConcession(string name, int age, double totalFare)
        {
            if (age <= 5)
            {
                Console.WriteLine("Little Champs - Free Ticket");
            }
            else if (age > 60)
            {
                double concession = totalFare * 0.30;
                double finalAmount = totalFare - concession;
                Console.WriteLine($"Senior citizen - {name}, finalAmount: {finalAmount}/-");
            }
            else
            {
                Console.WriteLine($"Ticket booked to {name} for {totalFare}/-");
            }
        }
    }
}
