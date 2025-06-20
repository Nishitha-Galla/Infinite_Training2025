using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program3
    {
        static void Main()
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Console.Write("Enter a number from 1 to 7 only: ");
            int day = Convert.ToInt32(Console.ReadLine());

            if (day >= 1 && day <= 7)
                Console.WriteLine(days[day - 1]);
            else
                Console.WriteLine("Invalid input");

            Console.Read();

        }
    }
}
