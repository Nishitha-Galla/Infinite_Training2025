using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program1
    {
        static void Main()
        {
            int a, b;

            Console.Write("Enter 1st number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            b = Convert.ToInt32(Console.ReadLine());

            int temp_var = a;
            a = b;
            b = temp_var;

            Console.WriteLine($"After swapping: {a} and {b} ");
            Console.Read();

        }
    }
}
