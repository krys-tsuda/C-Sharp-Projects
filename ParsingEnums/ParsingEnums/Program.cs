using System;

// Define an enum for the days of the week
public enum DaysOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class Program
{
    static void Main()
    {
        try
        {
            // Prompt the user to enter the current day of the week
            Console.Write("Enter the current day of the week: ");
            string userInput = Console.ReadLine();

            // Convert the user input to the enum type (ignore case)
            DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

            // Assign the value to a variable of that enum data type
            Console.WriteLine($"The current day is: {currentDay}");
        }
        catch (ArgumentException)
        {
            // Catch an ArgumentException if the user enters an invalid day
            Console.WriteLine("Please enter an actual day of the week.");
        }
        catch (Exception ex)
        {
            // Catch any other exceptions that may occur
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            Console.ReadLine();
        }
    }
}

