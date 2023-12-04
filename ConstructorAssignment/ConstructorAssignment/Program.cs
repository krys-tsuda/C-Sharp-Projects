using System;

namespace ConstructorAssignment
{
    class Program
    {
        // Creating a constant variable
        const string programType = "Assignment";
        static void Main(string[] args)
        {
            // Variable using keyword "var"
            var assignmentName = "Constructor";
            Console.WriteLine($"{assignmentName} {programType}");

            Console.WriteLine("\nWhat's your name?");
            string myName = Console.ReadLine();
            Console.WriteLine("\nWhat program are you in?");
            string myProgram = Console.ReadLine();

            // Chaining constructors together
            MyClass studentAssignment = new MyClass(myName);
            MyClass studentAssignment2 = new MyClass(myName, myProgram);

            // Display output to console
            Console.WriteLine($"\nStudent Name: {studentAssignment.studentName} \nProgram Name: {studentAssignment.programName}");
            Console.WriteLine($"\nStudent Name: {studentAssignment2.studentName} \nProgram Name: {studentAssignment2.programName}");

            Console.ReadLine();
        }
    }
}
