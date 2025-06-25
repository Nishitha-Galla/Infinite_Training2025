using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.Write a C# Sharp program to remove the character at a given position in the string. The given position will be in the range 0..(string length -1) inclusive.
//Sample Input:
//"Python", 1
//"Python", 0
//"Python", 4
//Expected Output:
//Pthon
//ython
//Pythn

namespace Assessment1
{
    class Program1
    {
        static void Main()
        {
            Console.WriteLine(RemoveChar("Python", 1));
            Console.WriteLine(RemoveChar("Python", 0));
            Console.WriteLine(RemoveChar("Python", 4));

            Console.ReadLine();
        }
        static string RemoveChar(string word, int index)
        {
            string result = "";
            
            for (int i = 0; i < word.Length; i++)
            {
                if (i != index)
                {
                    result += word[i];
                }
            }
            return result;
        }
    }
}
