using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Card  //best practice one class per file 
    {
        //class Card properties
        //public can be used by the rest of the program
        //has property of data type string called {data type}
        //you can get or set this property 

        //constructor method name is always class name
        //default values if none are given
        public Suit Suit { get; set; }
        public Face Face { get; set; }

        public override string ToString()   // override build in function
        {
            return string.Format($"{Face} of {Suit}");  // formats card when function is called on it
        }
    }
    //defining enum limiting values that can be assigned
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    //defining enum limiting calues that can be assigned
    public enum Face
    {
        Two, 
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace

    }
}
