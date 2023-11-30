using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yearly Living Expenses\n");
            Console.WriteLine("To calculate income after living expenses please provide the following information.\nIf an expense does not apply enter 0.");

            // Prompt user input for following information
            Console.WriteLine("\nMonthly rent:");   
            int rent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nMonthly power:");
            int power = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nMonthly gas:");
            int gas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nMonthly water:");
            int water = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nAny other monthly expenses:");
            int misc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nYearly income after taxes:");
            int yearIncome = Convert.ToInt32(Console.ReadLine());

            // Creates an instance of MathOperations
            MathOperations mathOperations = new MathOperations();

            // Call the methods with user inputs
            int monthTotal = mathOperations.MonthTotal(rent, power, gas, water, misc);
            int yearTotal = mathOperations.YearTotal(monthTotal);
            int afterExpenses = mathOperations.AfterExpenses(yearIncome, yearTotal);
            

            //Display the results
            Console.WriteLine($"\nMonth Total: ${monthTotal}");
            Console.WriteLine($"Year Total: ${yearTotal}");
            Console.WriteLine($"Income after expenses: ${afterExpenses}");
          
            Console.ReadLine();
        }
    }
}
