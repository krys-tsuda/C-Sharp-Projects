using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validAnswer = false;
            while (!validAnswer)    // loops until condition is true
            {
                try
                {
                    Console.WriteLine("Hi there, how old are you?");    // prompts user for age
                    int userAge  = int.Parse(Console.ReadLine());

                    if (userAge <= 0)   // validate if age is zero or greater
                    {
                        throw new ArgumentException("Age must be greater than 0.");
                    }

                    int birthYear = DateTime.Now.Year - userAge;    // Calculate birth year
                    Console.WriteLine($"\nYou were born in the year {birthYear}");    //Display year user was born
                    validAnswer = true;    // exits loop
                }
                catch (FormatException)    // catches invalid input format error
                {
                    Console.WriteLine("Invalid input format. Please enter a valid number.");
                }
                catch (ArgumentException ex)   // argument exception
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception)   // catches any other error
                {
                    Console.WriteLine("An error has occured. Good bye.");
                }
                finally    // runs last
                {
                    Console.ReadLine();
                }
            }
        }
    }
}
