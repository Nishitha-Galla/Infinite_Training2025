using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program3
    {
        static void Main()
        {
            Console.Write("Input first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Input operation: ");
            char operation = char.Parse(Console.ReadLine());

            Console.Write("Input second number: ");
            int num2 = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case '/':
                    if (num2 != 0)
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    else
                        Console.WriteLine($"Cannot divide using zero");
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

            Console.ReadKey();

        }
    }
}
