using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{

    class Employee
    {
        public int Id;
        public string Name;
        public string Department;
        public double Salary;
    }

    class EmployeeList
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee()
        {
            try
            {
                Employee emp = new Employee();

                Console.WriteLine("Enter Id: ");
                emp.Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Name: ");
                emp.Name = Console.ReadLine();

                Console.WriteLine("Enter Department: ");
                emp.Department = Console.ReadLine();

                Console.WriteLine("Enter Salary: ");
                emp.Salary = double.Parse(Console.ReadLine());

                employees.Add(emp);
                Console.WriteLine("Employee added successfully!");
            }
            catch
            {
                Console.WriteLine("Invalid input");
            }
        }
        public void ViewEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees found");
                return;
            }
            Console.WriteLine("\n----------Employee List--------");
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Dept: {emp.Department}, Salary: {emp.Salary}");
            }
        }
        public void SearchEmployee()
        {
            Console.Write("Enter employee ID to search");
            int id = int.Parse(Console.ReadLine());

            Employee emp = null;
            foreach (var e in employees)
            {
                if (e.Id == id)
                {
                    emp = e;
                    break;
                }
            }

            if (emp != null)
            {
                Console.WriteLine($"Found employee with {emp.Id} id, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary} /-");
            }
            else
            {
                Console.WriteLine("Employee not found...");
            }
        }
        public void UpdateEmployee()
        {
            Console.Write("Enter Employee Id to update: ");
            int id = int.Parse(Console.ReadLine());

            var emp = employees.Find(e => e.Id == id);
            if (emp != null)
            {
                Console.Write("Enter new Name: ");
                emp.Name = Console.ReadLine();

                Console.Write("Enter new Department: ");
                emp.Department = Console.ReadLine();

                Console.Write("Enter new Salary: ");
                emp.Salary = double.Parse(Console.ReadLine());

                Console.WriteLine("Employee updated successfully! ");
            }
            else
            {
                Console.WriteLine("Employee not found...");
            }
        }

        public void DeleteEmployee()
        {
            Console.Write("Enter employee Id to delete: ");
            int id = int.Parse(Console.ReadLine());

            var emp = employees.Find(e => e.Id == id);
            if (emp != null)
            {
                employees.Remove(emp);
                Console.WriteLine("Employee deleted");
            }
            else
            {
                Console.WriteLine("Employee not found");
            }
        }
    }
    class EmployeeOp
    {
        static void Main()
        {
            EmployeeList list = new EmployeeList();
            int choice;


            do
            {
                Console.WriteLine("\n==========Employee management system===========");
                Console.WriteLine("1. Add employee ");
                Console.WriteLine("2. View all employees ");
                Console.WriteLine("3. Search employee by Id ");
                Console.WriteLine("4. Update employee ");
                Console.WriteLine("5. Delete employee ");
                Console.WriteLine("6. Exit ");
                Console.WriteLine("Enter your choice from 1 to 6: ");

                bool isValid = int.TryParse(Console.ReadLine(), out choice);
                if (!isValid)
                {
                    Console.WriteLine("Invalid input, Enter a number. ");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        list.AddEmployee();
                        break;
                    case 2:
                        list.ViewEmployees();
                        break;
                    case 3:
                        list.SearchEmployee();
                        break;
                    case 4:
                        list.UpdateEmployee();
                        break;
                    case 5:
                        list.DeleteEmployee();
                        break;
                    case 6:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Please select a valid choice from 1 to 6 ");
                        break;

                }

            } while (choice != 6);

        }

    }
}
    