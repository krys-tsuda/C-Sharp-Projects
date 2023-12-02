using System;
using System.Collections.Generic;
using System.Text;

namespace Operators
{
    // Declaring class Employee
    public class Employee
    {
        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        // overload operator== to compare employee Ids
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;    // employee Ids do match
        }
        // overload operator!= to compl
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;    // employee Ids do not match
        }
    }
}
