using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program\n");

            // Takes person1 input for hourly rate and hours worked, converting to decimal
            Console.WriteLine("Person 1, please give the following information.");
            Console.WriteLine("What is your hourly rate?");
            decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());    // stores hourly rate
            Console.WriteLine("How many hours a week do you work?");
            decimal hoursWorked1 = Convert.ToDecimal(Console.ReadLine());   // stores weekly rate

            // Takes person2 input for hourly rate and hours worked, converting to decimal, and storing in variable to be used later
            Console.WriteLine("\nPerson 2, please give the following information.");
            Console.WriteLine("What is your hourly rate?");
            decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());    // stores hourly rate
            Console.WriteLine("How many hours a week do you work?");
            decimal hoursWorked2 = Convert.ToDecimal(Console.ReadLine());   // stores weekly rate

            // Calls function, passing in arguments hourlyRate and hoursWorked, returning annual salary
            decimal annualSalary1 = calculateAnnualSalary(hourlyRate1, hoursWorked1);   // person 1 annual salary
            decimal annualSalary2 = calculateAnnualSalary(hourlyRate2, hoursWorked2);   // person 2 annual salary

            // Annual salary of person 1 and person 2 is displayed in console
            Console.WriteLine("\nAnnual salary of Person 1:\n" + annualSalary1);
            Console.WriteLine("\nAnnual salary of Person 2:\n" + annualSalary2);

            // Compares annual salary of person 1 and person 2 displaying who makes more money
            Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
            Console.WriteLine(annualSalary1 > annualSalary2);

            // exit program
            Console.WriteLine("\nPress any key to exit program.");
            Console.ReadKey();
        }
        
        // Reusable method to be called that calculates annual salary 
        static decimal calculateAnnualSalary(decimal hourlyRate, decimal hoursWorked)   // gives paramaters hourlyRate and hoursWorked
        {
            // calculates weekly rate by multiplying hourly rate to hours worked
            // calculates annual salary by multiplying weekly rate to weeks per year 
            // displaying results in console
            decimal weeklyRate = hourlyRate * hoursWorked;  //weekly rate
            return weeklyRate * 52.143m;    // weeks per year
        }
    }
}
