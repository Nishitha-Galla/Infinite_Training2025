using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    delegate int CalculatorDelegate(int a, int b);

    class Program4
    {
        public static void Operations(int a, int b, CalculatorDelegate operation)
        {
            int result = operation(a, b);
            Console.WriteLine(result);
        }

        static void Main()
        {
            Console.Write("Enter first number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Addition: ");
            Operations(x, y, (a, b) => a + b);

            Console.Write("Subtraction: : ");
            Operations(x, y, (a, b) => a - b);

            Console.Write("Muliplication: ");
            Operations(x, y, (a, b) => a * b);

            Console.Read();

        }
    }
   
}
