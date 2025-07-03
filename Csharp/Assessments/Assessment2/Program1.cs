using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    
    abstract class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public double Grade { get; set; }

        public abstract bool IsPassed(double grade);
    }

    class UnderGraduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade >= 70.0;
        }
        
    }

    class Graduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade >= 80.0;

        }
    }
    class Program1
    {
        static void Main()
        {
            Console.WriteLine("----------------UNDERGRADUATE STUDENT------------------"); //undergrad
            UnderGraduate ugStudent = new UnderGraduate();

            Console.Write("Enter Id: ");
            ugStudent.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            ugStudent.FullName = Console.ReadLine();

            Console.Write("Enter Grade: ");
            ugStudent.Grade = Convert.ToDouble(Console.ReadLine());

            bool ugResult = ugStudent.IsPassed(ugStudent.Grade);
            Console.WriteLine($"[Undergraduate] {ugStudent.FullName} - ID: {ugStudent.Id} - Grade: {ugStudent.Grade} - Result: {(ugResult? "Passed" : "Failed")}");

            Console.WriteLine("\n-------------GRADUATE STUDENT-------------");  //Graduate

            Graduate gStudent = new Graduate();

            Console.Write("Enter Id: ");
            gStudent.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            gStudent.FullName = Console.ReadLine();

            Console.Write("Enter Grade: ");
            gStudent.Grade = Convert.ToDouble(Console.ReadLine());

            bool gResult = gStudent.IsPassed(gStudent.Grade);
            Console.WriteLine($"[Undergraduate] {gStudent.FullName} - ID: {gStudent.Id} - Grade: {gStudent.Grade} - Result: {(gResult ? "Passed" : "Failed")}");

            Console.ReadLine();

        }
    }
}
