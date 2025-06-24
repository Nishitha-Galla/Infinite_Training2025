using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.Create a class called student which has data members like rollno, name, class, Semester, branch, int[] marks = new int marks [5](marks of 5 subjects )
//-Pass the details of student like rollno, name, class, SEM, branch in constructor
//- For marks write a method called GetMarks() and give marks for all 5 subjects
//-Write a method called displayresult, which should calculate the average marks
//-If marks of any one subject is less than 35 print result as failed
//-If marks of all subject is >35, but average is < 50 then also print result as failed
//-If avg > 50 then print result as passed.
//-Write a DisplayData() method to display all object members values.


namespace Assignment3
{
    class Program2
    {
        int rollno;
        string name;
        string studentClass;
        int sem;
        string branch;
        int[] marks = new int[5];
        double average;

        public Program2(int rollno, string name, string studentClass, int sem, string branch)
        {
            this.rollno = rollno;
            this.name = name;
            this.studentClass = studentClass;
            this.sem = sem;
            this.branch = branch;
        }

        public void GetMarks()
        {
            Console.WriteLine("Enter 5 subject marks:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Subject " + (i + 1) + "-");
                marks[i] = int.Parse(Console.ReadLine());
            }
        }
        public void DisplayResult()
        {
            int failedSubjects = 0;
            average = 0;

            for (int i = 0; i < 5; i++)
            {
                average += marks[i];
                if (marks[i] < 35)
                    failedSubjects++;
            }

            average /= 5.0;

            Console.WriteLine("\n=============Result=============");

            if (failedSubjects > 0)
            {
                Console.WriteLine("Fail");
            }
            else if (average < 50)
            {
                Console.WriteLine("Fail, your average marks are below 50");
            }
            else
            {
                Console.WriteLine("Congratulations! You Passed");
            }

        }
        public void ShowData()
        {
            Console.WriteLine("\n==============Student marks data=============");
            Console.WriteLine("Roll no: " + rollno);
            Console.WriteLine("Student name: " + name);
            Console.WriteLine("Student class: " + studentClass);
            Console.WriteLine("Semester: " + sem);
            Console.WriteLine("Branch: " + branch);
            Console.WriteLine("Marks: " + string.Join(",", marks));
            Console.WriteLine("Average marks: " + average);
        }

        static void Main()
        {
            Program2 s1 = new Program2(26, "Nishitha","C Section", 3, "CSE");

            s1.GetMarks();
            s1.DisplayResult();
            s1.ShowData();

            Console.Read();
        }
    }
}
