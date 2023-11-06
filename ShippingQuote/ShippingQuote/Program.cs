using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        //setting  constants max weight and max size
        const int maxWeight = 50;
        const int maxSize = 50;
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");   //intro message

            int packageWeight = GetPackageWeight(); // calls function to get package weight

            if (packageWeight > maxWeight)  //if package weights more than max weight 50 
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.\n");   //prints message to console
                ExitProgram();
            }
            else //if package is less than max weight get weight height and length
            {
                int packageWidth = GetPackageDimension("width");
                int packageHeight = GetPackageDimension("height");
                int packageLength = GetPackageDimension("length");
                int totalSize = CalculatePackageSize(packageWidth, packageHeight, packageLength);   //calculates total size

                if (totalSize > maxSize)    //if total size is greater than max size
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");    //prints messaage to console
                    ExitProgram();
                }
                else //if package is less than max size calculate shipping quote
                {
                    int quote = CalculateQuote(totalSize, packageWeight);
                    Console.WriteLine($"Estimated total for shipping package is: ${quote}.00 \nThank you!");
                    ExitProgram();
                }
            }
        }
        //Reusable methods to be called
        static int GetPackageWeight()   //prompts user for package weight and returns input
        {
            Console.WriteLine("How much does your package weigh?");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int GetPackageDimension(string dimensionName)    //prompts user for specific package dimensions and returns input
        {
            Console.WriteLine($"Please enter package {dimensionName}:");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int CalculatePackageSize(int width, int height, int length)  //calculates and returns size of package
        {
            return width + height + length;
        }

        static int CalculateQuote(int size, int weight) //calculates and return squote for shipping package
        {
            return (size * weight) / 100;
        }

        static void ExitProgram()   //message to exit program
        {
            Console.WriteLine("Press any key to exit program.");
            Console.ReadKey();
        }
    }


}

