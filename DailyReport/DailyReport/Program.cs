using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Report \n");    //Displays on two lines followed by a blank line

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();   //stores input as string

            Console.WriteLine("\nWhat course are you on?");
            string yourCourse = Console.ReadLine();    //stores input as a string

            int yourPage;   //stores input as an int
            yourPageInput: 
            Console.WriteLine("\nWhat page number?");
            try
            {
                yourPage = Convert.ToInt32(Console.ReadLine()); //converts string input to integer
            }
            catch
            {
                Console.WriteLine("Page number needs to be a number. Please re-enter.");    //if string isn't a number console displays message
                goto yourPageInput; //returns back to intial question for re entry
            }

            bool needHelp;  //stores input as boolean 
            needHelpInput:
            Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false\".");
            try
            {
                needHelp = Convert.ToBoolean(Console.ReadLine());   //converts string input to boolean
            }
            catch
            {
                Console.WriteLine("Please enter \"true\" or \"false\" only.");  //if string isn't "true" or "false" console displays message
                goto needHelpInput; //returns back to initial question for re entry
            }

            Console.WriteLine("\nWere there any positive experiences you'd like to share? Please give specifics.");
            string yourExperience = Console.ReadLine();    //stores input as a string
             
            Console.WriteLine("\nIs there any other feedback you'd like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine();   //stores input as a string

            int yourHours;  //stores input as int
            yourHoursInput:
            Console.WriteLine("\nHow many hours did you study today?");
            try
            {
                yourHours = Convert.ToInt32(Console.ReadLine());   //converts string input to int
            }
            catch
            {
                Console.WriteLine("Page number needs to be a number. Please re-enter.");    //if string is not a number console displays message
                goto yourHoursInput;    //returns back to initial question for re entry
            }

            Console.WriteLine("\nThank you " + yourName + " for your answers. An Instructor will respond to this shortly. Have a great day!");  //inserts users name into message
            Console.WriteLine("\nPress any key to exit.");  //instructions to exit program
            Console.ReadKey();  //waits for user to press a key
        }
    }
}
