using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program5
    {
        static void Main()
        {
            //length of the word
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            Console.WriteLine("Length of the word is: " + word.Length);

            //reverse 
            Console.WriteLine("------------");
            Console.WriteLine("\nEnter a word: ");
            string input = Console.ReadLine();
            string reverse = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse += input[i];
            }

            Console.WriteLine("Reversed word is: " + reverse);

            //compare
            Console.WriteLine("------------");
            Console.WriteLine("Enter 1st word: ");
            string first = Console.ReadLine();
            Console.WriteLine("Enter 2nd word: ");
            string second = Console.ReadLine();

            if (first == second)
                Console.WriteLine("Words are same");
            else
                Console.WriteLine("Words are different");

            Console.Read();


        }

    }
    
}
