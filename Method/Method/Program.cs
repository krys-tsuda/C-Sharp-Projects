using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiats SalesOperations class
            SalesOperations salesOperations = new SalesOperations();

            Console.WriteLine("Online Doughnut Order");
            // Prompts user for input
            Console.WriteLine("How many doughnuts would you like?");
            int totalDoughnuts = Convert.ToInt32(Console.ReadLine());

            // Optional input parameter
            Console.WriteLine("\nOption to add coffee to your order. \nEnter quantity or press enter.");
            string coffeeInput = Console.ReadLine();

            // Check if the user entered the quantity of coffee
            if (string.IsNullOrEmpty(coffeeInput))
            {
                // Call the method with one parameter
                int totalCost = salesOperations.CalculateCost(totalDoughnuts);
                Console.WriteLine($"\nTotal = ${totalCost}.00");
            }
            else
            {
                // Parse the quantity of coffee and call the method with two parameters
                int totalCoffees = Convert.ToInt32(coffeeInput);
                int totalCost = salesOperations.CalculateCost(totalDoughnuts, totalCoffees);
                Console.WriteLine($"\nTotal = ${totalCost}.00");
            }

            Console.ReadLine();

        }
    }
}
