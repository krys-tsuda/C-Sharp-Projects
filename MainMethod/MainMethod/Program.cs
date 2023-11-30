using System;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Calls first method with integerand displays return
            int intResult = mathOps.MathOperation(5);
            Console.WriteLine("Result for integer operation: " + intResult);

            // Calls second method with decimal and displays return
            int decimalResult = mathOps.MathOperation(12.5m);
            Console.WriteLine("Result for decimal operation: " + decimalResult);

            // Calls third method with string and displays return
            int stringResult = mathOps.MathOperation("15");
            Console.WriteLine("Result for string operation: " + stringResult);

            // Calls third method with string that cannot be turned into an integer and displays return
            int stringResult2 = mathOps.MathOperation("fifteen");
            Console.WriteLine("Result for string operation: " + stringResult2);

            Console.ReadLine();
        }
    }
}
