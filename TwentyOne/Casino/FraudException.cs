using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    // Seperate exception so we know when exception occurs its specifically fraud
    public class FraudException : Exception    // inherits from class Exception
    {
        public FraudException()    // standar constructor
            : base() { }    // inheriting from base exception
        public FraudException(string message)    // overloading constructor, takes string message argument
            : base(message) { }    // inherits base message
    }
}
