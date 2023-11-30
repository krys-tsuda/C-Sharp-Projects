using System;
using System.Collections.Generic;
using System.Text;

namespace Method
{
    // Defines a class 
    class SalesOperations
    {
        // method that can take two integeres as paramaters
        // second is optional default value 0
        public int CalculateCost(int totalDoughnuts, int totalCoffees = 0)
        {
            // performs cost calculation based on user input
            return (2 * totalDoughnuts) + (1 * totalCoffees);
        }
    }
}
