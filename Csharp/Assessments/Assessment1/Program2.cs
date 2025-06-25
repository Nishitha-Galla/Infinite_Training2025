using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
//Sample Input:
//"abcd"
//"a"
//"xy"
//Expected Output:
//dbca
//a
//yx

namespace Assessment1
{
    class Program2
    {
        static void Main()
        {
            Console.WriteLine(SwapFirstLast("abcd"));
            Console.WriteLine(SwapFirstLast("a"));
            Console.WriteLine(SwapFirstLast("xy"));

            Console.ReadLine();
        }
        static String SwapFirstLast(string word)
        {
            if (word.Length <= 1)
            {
                return word;
            }

            char first = word[0];
            char last = word[word.Length - 1];

            string mid = word.Substring(1, word.Length - 2);

            return last + mid + first;
        }
    }
}
