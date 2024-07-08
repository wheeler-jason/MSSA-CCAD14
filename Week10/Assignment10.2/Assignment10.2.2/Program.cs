using System;

namespace Assignment10._2._2
{
    /*
     * Write a program to create a list of employees. 
     * Consider a hard coded list. Display all employees 
     * who have salary more than $5000 and age < 30.
     */

    internal class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
            new Employee { Name = "Alice", Age = 30, Salary = 20000 },
            new Employee { Name = "Bob", Age = 25, Salary = 7000 },
            new Employee { Name = "Charlie", Age = 21, Salary = 5000.50 }
            };

            var employeeQuery = from employee in employees
                        where employee.Salary > 5000 && employee.Age < 30
                        select employee;

            Console.WriteLine("Employees with salary > 5000 and age < 30:");
            foreach (var employee in employeeQuery)
            {
               Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}, Salary: {employee.Salary:C}");
            }
        }
    }
}
