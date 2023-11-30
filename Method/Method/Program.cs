using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiats SalesOperations class
            SalesOperations salesOperations = new SalesOperations();

            // Prompts user for input
            Console.WriteLine("How many doughnuts would you like?");
            int totalDoughnuts = Convert.ToInt32(Console.ReadLine());

            // Optional input parameter
            Console.WriteLine("\nWould you like to add coffee to your order? (Yes/No)");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "yes")
            {
                // takes input for second parameter
                Console.WriteLine("\nHow many coffees would you like to add?");
                int totalCoffees = Convert.ToInt32(Console.ReadLine());

                // calls method with optional parameter
                int totalCost = salesOperations.CalculateCost(totalDoughnuts, totalCoffees);
                Console.WriteLine($"\nTotal = ${totalCost}.00");
            }
            else 
            {
                // calls method without optional parameter
                int totalCost = salesOperations.CalculateCost(totalDoughnuts);
                Console.WriteLine($"\nTotal = ${totalCost}.00");
            }

            Console.ReadLine();

        }
    }
}
