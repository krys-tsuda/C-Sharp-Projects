using System;
using System.Collections.Generic;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates Employee object with type string
            Employee<string> stringEmployee = new Employee<string>();

            // Assign list of strings as the property value of Things
            stringEmployee.Things = new List<string> { "badge", "laptop", "notebook" };

            // Instantiate an Employee object with type int
            Employee<int> intEmployee = new Employee<int>();

            // Assign list of integers as property value of Things
            intEmployee.Things = new List<int> { 1, 2, 3, 4, 5 };

            // Loop that prints all of the Things to console
            Console.WriteLine("Strings:");
            foreach (var str in stringEmployee.Things)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("\nIntegers:");
            foreach (var num in intEmployee.Things)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
