using System;


// Define a struct named Number
struct Number
{
    // Property Amount data type decimal
    public decimal Amount { get; set; }
}
class Program
{
    static void Main()
    {
        // Create an object of data type Number
        Number myNumber = new Number();

        // Assign an amount to the Amount property of object
        myNumber.Amount = 123.45m;

        // Print amount to console
        Console.WriteLine($"The amount is: {myNumber.Amount}");

        Console.ReadLine();
    }
}
