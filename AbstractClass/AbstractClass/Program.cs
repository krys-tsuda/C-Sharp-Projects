using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates an Employee object
            Employee employee = new Employee
            {
                firstName = "Sample",
                lastName = "Student"
            };
            // Call SayName method on employee object
            employee.SayName();

            Console.ReadLine();
        }
    }
}
