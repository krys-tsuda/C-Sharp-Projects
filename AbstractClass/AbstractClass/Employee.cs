using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    // Declaring class Employe inherits from class Person
    public class Employee : Person
    {
        public int Id { get; set;
        }

        // implementing SayName() method inside of class
        public override void SayName()
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine($"Name: {fullName}");
        }
    }
}
