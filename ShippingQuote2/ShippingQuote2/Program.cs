using System;

namespace ShippingQuote2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");   //intro message

            Console.WriteLine("Please enter the package weight:");  //prompts user for weight
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50) //if weight is greater than 50 prints message to console
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.WriteLine("Press any key to exit program.");
                Console.ReadKey();
            }
            else    //if less than 50 program continues
            {
                Console.WriteLine("Please enter package width:");   //prompts user for width
                int packageWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package height:");  //promts user for height
                int packageHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package length:");  //prompts user for length
                int packageLength = Convert.ToInt32(Console.ReadLine());

                int totalDimensions = packageWidth + packageHeight + packageLength; //totals dimensions 
                if (totalDimensions > 50)   //if dimensions greater than 50 prints message to console
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.WriteLine("Press any key to exit program.");
                    Console.ReadKey();
                }
                else    //if less than 50 program continues
                {
                    int shippingQuote = (packageWidth * packageHeight * packageLength) * packageWeight / 100;  //calculates shipping quote
                    Console.WriteLine($"Your estimated total for shipping this package is: ${shippingQuote}.00 \nThank you!");  //prints quote to console

                    Console.WriteLine("Press any key to exit program.");    //exit program
                    Console.ReadKey();
                }


            }
        }
    }
}
