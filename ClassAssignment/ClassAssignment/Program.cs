using System;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates object of MathOperations class
            MathOperations mathOperations = new MathOperations();

            // Prompts user for input
            Console.WriteLine("Example: void method\nPlease pick a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            
            mathOperations.Divide(number);  // Calls method passing in user input

            int result; // variable to store output value
            mathOperations.Add(25, 5, out result);  // pass the variable as an out parameter

            Console.WriteLine($"\nExample: output parameter\n25 + 5 = {result}");    // display result to console

            // Calling Subtract method
            int result1 = mathOperations.Subtract(17, 3);
            Console.WriteLine($"\nExample: overload method\n17 - 3 = {result1}");

            // Calling Subtract method with additional parameter
            int result2 = mathOperations.Subtract(1000, 100, 10);
            Console.WriteLine($"1000 - 100 - 10 = {result2}");

            // Calling static method of class StaticClass
            StaticClass.Example();

            // Accessing static data
            Console.WriteLine($"This is {StaticClass.a}.");

            Console.ReadLine();
        }
    }
}
