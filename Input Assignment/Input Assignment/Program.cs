using System;
using System.IO;

namespace Input_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number.");    // prompts user for number
            int number = Convert.ToInt32(Console.ReadLine());   // converts input to int
            string text = number.ToString();    // converts text to be logged to string
            File.WriteAllText(@"F:\TechAcademy\WorkingBranch\Logs\inputlog.txt", text);    // writing text to given file path
            Console.WriteLine   // prints text file to console
            (
                "\nText from inputlog.txt: " + File.ReadAllText(@"F:\TechAcademy\WorkingBranch\Logs\inputlog.txt")
            );
            Console.ReadLine();
        }
    }
}
