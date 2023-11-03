using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Into to program accepting user input as yourName
            Console.WriteLine("What's your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("\nHi there, " + yourName + " let's do some math!");

            //Converts user input to int and multiplies it by 50 displaying the product
            Console.WriteLine("\nPick a number to multiply by fifty.");
            int yourNum1 = Convert.ToInt32(Console.ReadLine());
            int myNum1 = 50;
            Console.WriteLine(yourNum1 + " multiplied by fifty = " + (yourNum1 * myNum1));

            //Converts user input to int adding 25 and displaying the sum
            Console.WriteLine("\nPick another number, let's add it to 25.");
            int yourNum2 = Convert.ToInt32(Console.ReadLine());
            int myNum2 = 25;
            Console.WriteLine(yourNum2 + " plus 25 = " + (yourNum2 + myNum2));

            //Converts user input to int dividing it by a double value displaying the answer as a double
            Console.WriteLine("\nPick another number to divide by twelve and a half.");
            int yourNum3 = Convert.ToInt32(Console.ReadLine());
            double myNum3 = 12.5;
            double quotient = yourNum3 / myNum3;
            Console.WriteLine(yourNum3 + " divided by 12.5 = " + quotient);

            //Converts user input to integer, coparing to see if greater than 50. If statement displaying results based on comparison being true or false.
            Console.WriteLine("\nPick another number, we'll compare it to fifty");
            int yourNum4 = Convert.ToInt32(Console.ReadLine());
            bool comparison = yourNum4 > 50;
            if (comparison == true)
            {
                Console.WriteLine(yourNum4 + " is greater than 50");
            }
            else
            {
                Console.WriteLine(yourNum4 + " is not greater than 50");
            }

            //Converts user input to integer, displaying remainder of operation
            Console.WriteLine("\nPick another number to divide by seven, we'll find the remainder.");
            int yourNum5 = Convert.ToInt32(Console.ReadLine());
            int myNum5 = 7;
            Console.WriteLine("The remainder of " + yourNum5 + " divided by " + myNum5 + " is: " + (yourNum5 % myNum5));

            //End of program
            Console.WriteLine("\nThanks " + yourName + ", that was fun. Press any key to exit.");
            Console.ReadKey();
        }   
    }
}
