using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
     
    class Program2
    {
        static void Main()
        {
            List<string> str = new List<string>();

            Console.Write("Enter number of words: ");
            int n = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter word {0}: ", i + 1);
                string words = Console.ReadLine();
                str.Add(words);
            }
            var result = from s in str
                         let lower = s.ToLower()
                         where lower.StartsWith("a") && lower.EndsWith("m")
                         select s;

            Console.WriteLine("\n Words starting with a and ending with m: ");

            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
            Console.ReadLine();

        }  
    }
}
