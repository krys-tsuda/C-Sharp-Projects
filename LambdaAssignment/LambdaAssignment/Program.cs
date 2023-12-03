using System;
using System.Collections.Generic;
using System.Linq;


namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating new object List with data type Employee
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, firstName = "Joe", lastName = "Doe" },
                new Employee { Id = 2, firstName = "Krystle", lastName = "Smith" },
                new Employee { Id = 3, firstName = "Ashley", lastName = "Wilson" },
                new Employee { Id = 4, firstName = "Jeff", lastName = "Miller" },
                new Employee { Id = 5, firstName = "Sarah", lastName = "Williams" },
                new Employee { Id = 6, firstName = "Megz", lastName = "Jones" },
                new Employee { Id = 7, firstName = "Jackie", lastName = "Davis" },
                new Employee { Id = 8, firstName = "Joe", lastName = "Taylor" },
                new Employee { Id = 9, firstName = "Shane", lastName = "Clark" },
                new Employee { Id = 10, firstName = "Keisa", lastName = "Johnson" }
            };

            //Displaying list of employees
            Console.WriteLine("List of Employees:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"ID: {employee.Id}, Name: {employee.firstName} {employee.lastName}");
            }

            // New list of employees with firsName "Joe"
            List<Employee> sameNameList1 = new List<Employee>();

            // loop through each employee in list employees
            foreach (var employee in employees)
            {
                // Compare firstName if "Joe" add to list sameName
                if (employee.firstName == "Joe")
                {
                    sameNameList1.Add(employee);
                }
            }

            // Displaying list of employees with same name 
            Console.WriteLine("\nList of Employees with First Name 'Joe' (using foreach):");
            foreach (var joe in sameNameList1)
            {
                Console.WriteLine($"ID: {joe.Id}, Name: {joe.firstName} {joe.lastName}");
            }

            // Using lambda expression to create new list of employees first name 'Joe'
            List<Employee> sameNameList2= employees.Where(e => e.firstName == "Joe").ToList();

            // Displaying list of employees (using lambda expression)
            Console.WriteLine("\nList of Employees with First Name 'Joe' (using lambda):");
            sameNameList2.ForEach(joe => Console.WriteLine($"ID: {joe.Id}, Name: {joe.firstName} {joe.lastName}"));

            // Using lambda expression to create new list of employess with Id greater than 5
            List<Employee> greaterThan5 = employees.Where(e => e.Id > 5).ToList();

            // Displaying list of employees Id greater than 5 (using lambda)
            Console.WriteLine("\nList of Employees with Id Greater Than 5 (using lambda)");
            greaterThan5.ForEach(e => Console.WriteLine($"ID: {e.Id}, Name: {e.firstName} {e.lastName}"));

            Console.ReadLine();
        }
    }
}
