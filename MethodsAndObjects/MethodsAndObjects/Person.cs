using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsAndObjects
{
    public class Person
    {
        // class properties
        public string FirstName { get; set; }   
        public string LastName { get; set; }

        // void method writes full name to console
        public void SayName()
        {
            string fullName = FirstName + " " + LastName;
            Console.WriteLine($"Name: {fullName}");
        }
    }
}
