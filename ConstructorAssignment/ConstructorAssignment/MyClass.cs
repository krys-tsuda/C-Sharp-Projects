using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorAssignment
{
    // Defines a class with two constructors
    public class MyClass
    {
        // Default constructor
        public MyClass(string myName) : this(myName, "TechAcademy Program")
        {
            // This constructor calls the other constructor with a default programName
        }

        // Constructor with parameters
        public MyClass(string myName, string myProgram)
        {
            studentName = myName;
            programName = myProgram;
        }

        // Class properties
        public string studentName { get; set; }
        public string programName { get; set; }
    }
}

