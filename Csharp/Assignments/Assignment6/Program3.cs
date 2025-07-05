using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment6
{
    class LineCounter
    {
        public void CountLines()
        {
            string filePath = "StringsInArray.txt";

            if (File.Exists(filePath))
            {
                int lineCount = File.ReadAllLines(filePath).Length;
                Console.WriteLine("Total number of lines in the file are: " +lineCount);
            }
            else
            {
                Console.WriteLine("File doesn't exist..");
            }
        }
    }

    class Program3
    {
        static void Main()
        {
            LineCounter lc = new LineCounter();
            lc.CountLines();

            Console.ReadLine();
        }
    }
}
