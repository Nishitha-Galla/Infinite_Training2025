using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program2
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            string input = num.ToString();

            Console.WriteLine("{0} {0} {0} {0}", input);
            Console.WriteLine("{0}{0}{0}{0}", input);
            Console.WriteLine("{0} {0} {0} {0}", input);
            Console.WriteLine("{0}{0}{0}{0}", input);

            Console.Read();

        }
    }
}
