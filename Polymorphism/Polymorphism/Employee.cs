using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    // Declaring class Employee inherits from abstract class Person and interface IQuittable
    class Employee : Person, IQuittable
    {
        // class properties
        public int Id
        {
            get; set;
        }

        // implementing SayName() method from abstract class Person
        public override void SayName()
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine($"Name: {fullName}");
        }
        // implementing Quit() method from interface class IQuittable
        public void Quit()
        {
            Console.WriteLine($"{firstName} {lastName} with employee ID {Id} has quite.");
        }
    }
}
