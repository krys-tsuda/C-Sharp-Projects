using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating object of Employee class
            Employee employee1 = new Employee()
            {
                FirstName = "Jackie",
                LastName = "Moon",
                Id = 123456
            };
            // Creating second object of Employee class
            Employee employee2 = new Employee()
            {
                FirstName = "Sarah",
                LastName = "Wish",
                Id = 456789
            };

            // Compare two Employee objects using overloaded operators
            bool areEqual = employee1 == employee2;
            bool areNotEqual = employee1 != employee2;

            // Display results
            Console.WriteLine($"Are employee1 and employee2 equal? {areEqual}");    
            Console.WriteLine($"Are employee1 and employee2 not equal? {areNotEqual}");

            Console.ReadLine();
        }
    }
}
