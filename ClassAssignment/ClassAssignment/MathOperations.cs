using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment
{
    // Define a class MathOperations
    class MathOperations
    {
        // Define a void method that outputs an integer
        public void Divide(int number)
        {
            // Divides data passed by 2
            int result = number / 2;
            // Displays results to console
            Console.WriteLine($"{number} / 2 = {result}");
        }

        // Define a method with out parameters
        public void Add(int a, int b, out int sum)
        {
            sum = a + b;    // set the value of the output parameter
        }

        // Define a method to subtract
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // Overload method with additional parameter
        public int Subtract(int a, int b, int c)
        {
            return a - b - c;
        }
    }
}
