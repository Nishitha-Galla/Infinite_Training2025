using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Program
{
    class Employee
    {
        public int EmployeeID;
        public string FirstName;
        public string LastName;
        public string Title;
        public string City;
        public DateTime DOB;
        public DateTime DOJ;
    }
    
    class Program
    {
       
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{ EmployeeID=1001, FirstName="Malcolm", LastName = "Daruwalla", Title= "Manager", DOB = new DateTime(1984,11,16), DOJ= new DateTime(2011,6,8), City="Mumbai" },
                new Employee{ EmployeeID=1002, FirstName="Asdin", LastName = "Dhalla", Title= "AsstManager", DOB = new DateTime(1984,8,20), DOJ= new DateTime(2012,7,7), City="Mumbai" },
                new Employee{ EmployeeID=1003, FirstName="Madhavi", LastName = "Oza", Title= "Consultant", DOB = new DateTime(1987,11,14), DOJ= new DateTime(2015,4,12), City="Pune" },
                new Employee{ EmployeeID=1004, FirstName="Saba", LastName = "Shaik", Title= "SE", DOB = new DateTime(1990,6,3), DOJ= new DateTime(2016,2,2), City="Pune" },
                new Employee{ EmployeeID=1005, FirstName="Nazia", LastName = "Shaikh", Title= "SE", DOB = new DateTime(1991,3,8), DOJ= new DateTime(2016,2,2), City="Mumbai" },
                new Employee{ EmployeeID=1006, FirstName="Amit", LastName = "Pathak", Title= "Consultant", DOB = new DateTime(1989,11,7), DOJ= new DateTime(2014,8,8), City="Chennai" },
                new Employee{ EmployeeID=1007, FirstName="Vijay", LastName = "Natrajan", Title= "Consultant", DOB = new DateTime(1989,12,2), DOJ= new DateTime(2015,6,1), City="Mumbai" },
                new Employee{ EmployeeID=1008, FirstName="Rahul", LastName = "Dubey", Title= "Associate", DOB = new DateTime(1993,11,11), DOJ= new DateTime(2014,11,6), City="Chennai" },
                new Employee{ EmployeeID=1000, FirstName="Suresh", LastName = "Mistry", Title= "Associate", DOB = new DateTime(1992,8,12), DOJ= new DateTime(2014,12,3), City="Chennai" },
                new Employee{ EmployeeID=1010, FirstName="Sumit", LastName = "Shah", Title= "Manager", DOB = new DateTime(1991,4,12), DOJ= new DateTime(2016,1,2), City="Pune" },

            };
            Console.WriteLine("All employees: ");
            foreach (var e in employees)
            {
                Console.WriteLine("EmpId: " +e.EmployeeID + ", Name: " + e.FirstName + " " + e.LastName + ", Title: " + e.Title + " ,City: " + e.City +", DOB: "+ e.DOB.ToString("dd MMMM yyyy") + ", DOJ: " +e.DOJ.ToString("dd MMMM yyyy"));
            }

            Console.WriteLine("\n Employees not in mumbai");
            var not_in_mumbai = employees.Where(e => e.City != "Mumbai");
            foreach (var e in not_in_mumbai)
            {
                Console.WriteLine("EmpId: " + e.EmployeeID + ", Name: " + e.FirstName + " " + e.LastName + ", Title: " + e.Title +   ", City: " + e.City + ", DOB: " + e.DOB.ToString("dd MMMM yyyy") + ", DOJ: " + e.DOJ.ToString("dd MMMM yyyy"));
            }

            var assManagers = employees.Where(e => e.Title == "AsstManager");
            Console.WriteLine("\n Employee with title assisstant manager");
            foreach (var e in assManagers)
            {
                Console.WriteLine("EmpId: " + e.EmployeeID + ", Name: " + e.FirstName + " " + e.LastName + ", Title: "+ e.Title +   " ,City: " + e.City + ", DOB: " + e.DOB.ToString("dd MMMM yyyy") + ", DOJ: " + e.DOJ.ToString("dd MMMM yyyy"));
            }

            Console.WriteLine("\n Employees whose last name starts with S: ");
            var lastName = employees.Where(e => e.LastName.StartsWith("S"));
            foreach (var e in LastName)
            {
                Console.WriteLine("EmpId: " + e.EmployeeID + ", Name: " + e.FirstName + " " + e.LastName + ", Title: "+ e.Title +  ", City: " + e.City + ", DOB: " + e.DOB.ToString("dd MMMM yyyy") + ", DOJ: " + e.DOJ.ToString("dd MMMM yyyy"));
            }

            Console.ReadLine();


        }
    }
}
