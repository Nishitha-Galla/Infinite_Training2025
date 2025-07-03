using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    
    class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message) : base(message)
        {

        }
    }
    class Program3
    {
        static void Main()
        {
            Console.Write("Enter a number: ");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                if(number < 0)
                {
                    throw new NegativeNumberException("Don't enter a Negative number");
                }
                Console.WriteLine($"The number is: {number}");
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error! Please enter a valid integer");
            }

            Console.ReadLine();
        }
    }
}
