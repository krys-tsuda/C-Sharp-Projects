using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorAssignment
{
    // Defines a class with two constructors
    public class MyClass
    {
        // Default constructor
        public MyClass(string myName)
        {
            studentName = myName;   // parameter takes user input
            programName = "TechAcademy Program";    // default parameter
        }
        // Constructor with parameter
        public MyClass(string myName, string myProgram)
        {
            studentName = myName;   // parameter takes user input
            programName = myProgram;    // parameter takes user input
        }
        // class properties
        public string studentName { get; set; }
        public string programName { get; set; }
    }
}
