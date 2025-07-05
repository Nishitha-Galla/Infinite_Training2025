using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment6
{
    
    class FileWriter
    {
        public void WriteArray()
        {
            Console.Write("Enter length of array: ");
            int length = Convert.ToInt32(Console.ReadLine());

            string[] lines = new string[length];

            for(int i = 0; i < length; i++)
            {
                Console.Write("Enter the {0} element in array: ", i+1);
                lines[i] = Console.ReadLine();
            }

            FileStream fs = new FileStream("StringsInArray.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);

            foreach(string line in lines)
            {
                writer.WriteLine(line);
            }
            writer.Close();
            fs.Close();

            Console.WriteLine("Data written successfully");
        }
    }
    
    class Program2
    {
        static void Main()
        {
            FileWriter fw = new FileWriter();
            fw.WriteArray();

            Console.ReadLine();

        }
    }
}
