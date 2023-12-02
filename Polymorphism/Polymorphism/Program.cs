using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating an Employee object
            Employee employee = new Employee()
            {
                firstName = "Sample",
                lastName = "Employee",
                Id = 123456
            };

            // creating object of IQuittable using polymorphism
            IQuittable employeeQuit = employee;

            // calling Quit() method on IQuittable object
            employeeQuit.Quit();

            Console.ReadLine();
        }
    }
}
