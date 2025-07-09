using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    class Box
    {
        public int Length { get; set; }
        public int Breadth { get; set; }

        public Box(int length, int breadth)
        {
            Length = length;
            Breadth = breadth;
        }
        public static Box operator +(Box box1, Box box2)
        {
            return new Box(

                box1.Length + box2.Length,
                box1.Breadth + box2.Breadth
            );
        }

    }
    class Program2
    {
        static void Main()
        {
            Console.WriteLine("-------Entering first box details------");
            Console.Write("Enter length: ");
            int length1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Breadth: ");
            int breadth1 = Convert.ToInt32(Console.ReadLine());

            Box box1 = new Box(length1, breadth1);

            Console.WriteLine("-------Entering second box details------");
            Console.Write("Enter length: ");
            int length2= Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter breadth: ");
            int breadth2 = Convert.ToInt32(Console.ReadLine());

            Box box2 = new Box(length2, breadth2);

            Box boxSum = box1 + box2;

            Console.WriteLine("\n-----------After adding the boxes---------");
            Console.WriteLine("Sum of lengths: " + boxSum.Length);
            Console.WriteLine("Sum of breadths: " + boxSum.Breadth);

            Console.ReadLine();


        }
    }
}
