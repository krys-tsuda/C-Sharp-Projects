using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethods
{
    public class MathOperations // define class name
    {
        // Method to calculate monthly total
        public int MonthTotal(int rent, int power, int gas, int water, int misc)
        {
            return rent + power + gas + water + misc;
        }

        // Method to calculate yearly total
        public int YearTotal(int monthlTotal)
        {
            return monthlTotal * 12;
        }

        // Method to calculate income after expenses
        public int AfterExpenses(int yearIncome, int yearTotal)
        {
            return yearIncome - yearTotal;
        }
    }
}
