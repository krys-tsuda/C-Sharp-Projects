using System;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating new object of class Employee
            Employee employee = new Employee();
            employee.FirstName = "Sample";  // setting value to variable FirstName
            employee.LastName = "Student";  // setting value to variable LastName
            employee.SayName();    // calling superclass method 

            Console.ReadLine();
        }
    }
}
