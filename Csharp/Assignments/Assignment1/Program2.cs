using System;

namespace Assignment1
{
    class Program2
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            CheckNumber(num);
            Console.ReadKey();
        }
        static void CheckNumber(int n)
        {
            if (n > 0)
                Console.WriteLine($"{n} is a positive number");
            else if (n < 0)
                Console.WriteLine($"{n} is a negative number");
            else
                Console.WriteLine("The number is zero");
        }
    }
}
