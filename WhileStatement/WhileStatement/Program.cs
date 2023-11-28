using System;

namespace WhileStatement
{
    class Program
    {
        static void Main()
        {
            bool continueLoop = false;  //defines continueLoop as false

            do    //do this at least once
            {
                Console.WriteLine("Do you prefer chocolate or candy?\nEnter 'chocolate' or 'candy':");  //prints message to console
                string yourChoice = Console.ReadLine();     //variable defined by user input

                switch (yourChoice?.ToLower())  //start of switch statement
                {
                    case "chocolate":   //if chocolate
                        Console.WriteLine("That's fine, you should rethink your answer though.");   //prints message to console
                        break;
                    case "candy":   //if candy 
                        Console.WriteLine("Of course you do!"); //prints message to console
                        candyQuery();   //calles candyQuery function
                        continueLoop = true;    //ends loop
                        break;
                    default:    //answers other than candy or chocolate
                        Console.WriteLine("Invalid answer, try again.");    //prompts user for valid answer
                        break;
                }
            } while (!continueLoop);    //loop continues if condition is met
        }

        static void candyQuery()    //defines method
        {
            bool moreCandy = false; //assigns false value to var moreCandy
            int candyCount = 0; //var for candy count starts at 0

            while(!moreCandy)   //while loop runs as long as moreCandy is true
            {
                Console.WriteLine("Would you like more candy?\nYes or No:");   //console displays message
                string answer = Console.ReadLine(); //var defined by user input yes or no

                switch (answer?.ToLower())   //start of switch statement
                {
                    case "yes": //if answer is yes
                        candyCount++;   //increase candy count by 1
                        Console.WriteLine($"Now you have {candyCount} candies!");   //prints candy count to console
                        break;  //stops program from continuing
                    case "no":  //if answer is no
                        Console.WriteLine("Fine, that means more for me!");  //prints message to console
                        moreCandy = true;   //ends program
                        break;
                    default:    //answers other than yes or no
                        Console.WriteLine("Make up your mind!");    //prints to console
                        break;
                }

                Console.ReadLine();

            }
        }
    }
}
