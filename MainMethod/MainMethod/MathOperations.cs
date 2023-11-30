using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethod
{
    // Defina a MathOperations class
    class MathOperations
    {
        // Method for ineger input
        public int MathOperation(int number)
        {
            // Addition operation
            int sum = number + 10;
            return sum;
        }

        // Method for decimal input
        public int MathOperation(decimal number)
        {
            // Multiplication operation 
            int product = (int)(number * 5);
            return product;
        }

        // Method for strin input
        public int MathOperation(string input)
        {
            // Try to parse string to integer
            if (int.TryParse(input, out int parsedNumber))
            {
                // Subtraction operation for parsed integers
                int difference = parsedNumber - 3;
                return difference;
            }
            else
            {
                // Return if string cannot be parsed to an integer
                return -1;
            }
        }
    }
}
