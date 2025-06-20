using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program4
    {
        static void Main()
        {
            //avg, min, max
            int[] arr = { 26, 3, 22, 11 }; 
            int sum = 0, min = arr[0], max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }
            Console.WriteLine("Average of the array elements is: " + (sum / arr.Length));
            Console.WriteLine($"Min value of array is {min}");
            Console.WriteLine($"Max value of array is {max}");


            //marks........................................................................
            Console.WriteLine("-------------------");
            Console.WriteLine("Enter 10 marks");

            int[] marks = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Mark" + (i + 1) + "-");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = 0, minmark = marks[0], maxmark = marks[0];
            for (int i = 0; i < 10; i++)
            {
                total += marks[i];
                if (marks[i] < minmark) minmark = marks[i];
                if (marks[i] > maxmark) maxmark = marks[i];
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (marks[i] > marks[j])
                    {
                        int temp = marks[i];
                        marks[i] = marks[j];
                        marks[j] = temp;
                    }
                }
            }
            Console.WriteLine("Total marks: " + total);
            Console.WriteLine("Avg marks: " + (total / 10));
            Console.WriteLine("min marks: " + minmark);
            Console.WriteLine("max marks: " + maxmark);

            Console.WriteLine("marks in ascending order:  ");
            for (int i = 0; i < 10; i++)
                Console.Write(marks[i] + " ");

            Console.WriteLine("\nmarks in descending order:  ");
            for (int i = 9; i >= 0; i--)
                Console.Write(marks[i] + " ");
            Console.WriteLine();


            //copying array elements......................................................
            Console.WriteLine("----------------------");
            Console.WriteLine("Copying array elements");

            int[] arr1 = { 1, 2, 3, 4 };
            int[] arr2 = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
                arr2[i] = arr1[i];

            Console.Write("Copied array: ");
            for (int i = 0; i < arr2.Length; i++)
                Console.Write(arr2[i] + " ");

            Console.Read();
            


        }

    }
}
