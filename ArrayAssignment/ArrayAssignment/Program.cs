using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        bool continueLoop = false;  //continueLoop set to false

        while (!continueLoop)   //while var is not true do this
        {
            string[] stringArray = { "purple", "green", "pink", "blue", "yellow" }; //defines string array

            Console.WriteLine("Please select and index from stringArray.");
            int stringIndex = Convert.ToInt32(Console.ReadLine());  //takes user input converting to int 

            if (stringIndex < 0 || stringIndex > stringArray.Length)    //if chosen index is less than or greater than array length
            {
                Console.WriteLine("Chosen index does not exist, try another."); //print message to console
            }
            else    //if index is within the length of array
            {
                Console.WriteLine(stringArray[stringIndex]);    //print to console index corresponding element
                intQuery();     //calls intQuery method
                continueLoop = true;    //ends loop
            }
        }
    }

    static void intQuery()  //defines intQuery method
    {
        bool arrayIndex = false;    //arrayIndex set to false

        while (!arrayIndex) //while var is not true do this
        {
            int[] numArray = { 17, 25, 300, 4500, 666 };    //ddefins int array

            Console.WriteLine("\nPlease select an index from numArray.");
            int numIndex = Convert.ToInt32(Console.ReadLine()); //takes user input converting to int

            if (numIndex < 0 || numIndex > numArray.Length) //if chosen index is less than or great than array length
            {
                Console.WriteLine("Chosen index does not exist, try another."); //print message to console
            }
            else    //if index is within the length of array
            {
                Console.WriteLine(numArray[numIndex]);  //print to console index corresponding element
                listQuery();    //calls listQuery
                arrayIndex = true;  //ends loop
            }       
        }
    }

    static void listQuery()
    {
        bool listIndex = false; //listIndex set to false

        while(!listIndex)   //while var is not true do this
        {
            List <string> weekDays = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" }; //instansiates string list

            Console.WriteLine("\nPlease select an index from weekDays");
            int weekIndex = Convert.ToInt32(Console.ReadLine());    //takes user input converting to int

            if (weekIndex < 0 || weekIndex > weekDays.Count)    //if chosen index is less than or greater than list count
            {
                Console.WriteLine("Chosen index does not exist, try another."); //print message to console
            } 
            else   //if index is within list count
            {
                Console.WriteLine(weekDays[weekIndex]); //print to console index corresponding element
                listIndex = true;   //ends loop
            }
        }

        Console.ReadLine();

    }
}

