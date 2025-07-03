using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    
    class NotEligibleException : Exception
    {
        public NotEligibleException(string message) : base(message) { }
    }
    class Scholarship
    {
        public void Merit(double marks, double fees)
        {
            double scholarshipAmount;

            if (marks >= 70 && marks <= 80)
                scholarshipAmount = 0.20 * fees;
            else if (marks > 80 && marks <= 90)
                scholarshipAmount = 0.30 * fees;
            else if (marks > 90)
                scholarshipAmount = 0.50 * fees;
            else
                throw new NotEligibleException("Sorry, you are not eligible for scholarship. Your marks are below 70");

            Console.WriteLine($"Scholarship amount: {scholarshipAmount}/-");
            Console.WriteLine($"Fees after scholarship: {fees - scholarshipAmount}/-");
        }
    }
    class Program2
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter marks: ");
                double marks = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter total fees: ");
                double fees = Convert.ToDouble(Console.ReadLine());

                Scholarship s = new Scholarship();
                s.Merit(marks, fees);
            }
            catch (NotEligibleException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input, please enter numbers only...");
            }
            Console.Read();
        }
    }
}
