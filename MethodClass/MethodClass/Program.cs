using System;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Calls method passing in two numbers
            mathOps.PerformMath(50, 100);

            // Calls method specifying parameters by name
            mathOps.PerformMath(firstNum: 17, secondNum: 66);
        }
    }
}
