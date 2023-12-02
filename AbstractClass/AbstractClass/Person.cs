using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    // Declaring abstract class 
    public abstract class Person
    {
        // class properties
        public string firstName { get; set; }
        public string lastName { get; set; }

        // abstract method
        public abstract void SayName();
    }
}
