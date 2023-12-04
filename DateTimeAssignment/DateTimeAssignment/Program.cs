using System;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;    // new DateTime object of the current date and time
            Console.WriteLine($"Current Date and Time:\n{currentDateTime}");    // prints current date and time to console
           
            Console.WriteLine("\nPick a number.");  // prompts user for a number
            int number = Convert.ToInt32(Console.ReadLine());   // converts input to integer
            
            DateTime futureDateTime = currentDateTime.AddHours(number);    // new DateTime abject adds user input as hours to current date and time 
            Console.WriteLine($"\nTime after {number} hours:\n{futureDateTime}");   // prints future date time to console
            
            Console.ReadLine();
        }
    }
}
