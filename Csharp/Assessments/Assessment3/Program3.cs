using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment3
{
    class Program3
    {
        public static void WriteFile()
        {
            FileStream fs = new FileStream("Append.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);

            Console.WriteLine("Enter text to append: ");
            string input = Console.ReadLine();

            writer.WriteLine(input);
            writer.Flush();
            writer.Close();

            Console.WriteLine("Data added successfully...");
        }

        static void Main()
        {
            WriteFile();
            Console.Read();
        }
    }
}
