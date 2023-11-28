using System;
using System.Text;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your first name?");
            string firstName = Console.ReadLine();  //defines string var with user input

            Console.WriteLine("What's your middle name?");
            string middleName = Console.ReadLine(); //defines string var with user input

            Console.WriteLine("What's your last name?");
            string lastName = Console.ReadLine();   //defines string var with user input

            string fullName = firstName + " " + middleName + " " + lastName;    //concatenates three strings
            Console.WriteLine($"\nYour full name is {fullName}.");    //prints to console inserting value of fullName

            Console.WriteLine($"Your name all uppercase {fullName.ToUpper()}.\n\n");    //converts to uppercase and prints to console

            //Building a paragraph using StringBuilder.Append(string value) method
            StringBuilder paragraph = new StringBuilder();  //new object of string builder

            //appending string value, adding more sentences.
            paragraph.Append("This paragraph is created by using StringBuilder method.");
            paragraph.Append("Adding one sentence at a time.");
            paragraph.Append("Eventually it'll be a paragraph.");
            paragraph.Append("Until then I'll just keep adding sentences.");

            Console.WriteLine(paragraph);   //print paragraph to console
            Console.ReadLine();
        }
    }
}
