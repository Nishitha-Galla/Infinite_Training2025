using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program5
    {
        static void Main()
        {
            Console.Write("Enter 1st interger: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter 2nd integer: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = (num1 == num2) ? (num1 + num2) * 3 : num1 + num2;
            Console.WriteLine("Result is: " +result);
            Console.ReadKey();        
        }

    }
}
