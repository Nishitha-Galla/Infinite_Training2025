using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program4
    {
        static void Main()
        {
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");

            }
            Console.ReadKey();
        }
    }
}
