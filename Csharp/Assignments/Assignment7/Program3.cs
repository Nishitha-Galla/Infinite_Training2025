using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public double EmpSalary { get; set; }
    }
    class Program3
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter no of employees: ");
            int count = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter employee details: {i + 1} ");

                Console.Write("Employee Id: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("City: ");
                string city = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                employees.Add(new Employee
                {
                    EmpId = id,
                    EmpName = name,
                    EmpCity = city,
                    EmpSalary = salary
                });
            }

            Console.WriteLine("\n-----------Employees List----------");
            Display(employees);

            Console.WriteLine("\n-----------Employees with salary > 45000--------");
            var sal = from emp in employees
                              where emp.EmpSalary > 45000
                              select emp;
            Display(sal);

            Console.WriteLine("\n------------Employees from bangalore----------");
            var bangEmps = from emp in employees
                          where emp.EmpCity.ToLower() == "bangalore"
                          select emp;
            Display(bangEmps);

            Console.WriteLine("\n-----------Employees data by their name in ascending order---------");
            var sortEmps = from emp in employees
                           orderby emp.EmpName
                           select emp;
            Display(sortEmps);

            Console.ReadLine();
        }
        static void Display(IEnumerable<Employee> empList)
        {
            foreach (var emp in empList)
            {
                Console.WriteLine($"Id: {emp.EmpId}, Name: {emp.EmpName}, City: {emp.EmpCity}, Salary: {emp.EmpSalary}");
            }
        }
    }
}
