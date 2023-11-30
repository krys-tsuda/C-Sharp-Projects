using System;
using System.Collections.Generic;
using System.Text;

namespace MethodClass
{
    // Define a class MathOperations
    class MathOperations
    {
        // Define a void method that takes two integers
        public void PerformMath(int firstNum, int secondNum)
        {
            // Perform math operation on first integer
            int result = firstNum * 2;

            // Display the second integer
            Console.WriteLine($"Result of math operation on {firstNum}: {result} \nSecond integer: {secondNum}");
        }
    }
}
