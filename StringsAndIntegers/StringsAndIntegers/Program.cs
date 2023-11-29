using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            //list of integers
            List<int> numbList = new List<int>() { 5, 17, 23, 69, 81 };    

            Console.WriteLine("Pick a number.");
            int numberOne = Convert.ToInt32(Console.ReadLine());    //Prompts user for input

            //for loop iterating through list items
            for (int i = 0; i < 5; i++)
            {
                int numberTwo = numbList[i] / numberOne;    //variable defined as list item divided by user input
                Console.WriteLine(numbList[i] + " divided by " + numberOne + " equals " + numberTwo);
            }
        }
        catch (FormatException ex)  //format error
        {
            Console.WriteLine("Input error. Please use correct format.");   //if exception thrown prints to screen
        }
        catch (DivideByZeroException ex)    //divide by zero error
        {
            Console.WriteLine("You can not divide by zero!");   //if exception thrown prints to screen
        }
        catch (Exception ex)    //any other error 
        {
            Console.WriteLine("ex.Message");    //if exception thrown prints to screen
        }
        finally    //always runs at the end
        {
            Console.ReadLine();
        }

        Console.WriteLine("Program has emerged and may continue exacution.");   //prints to console letting you know program emerged from try/catch block
        Console.ReadLine();
    }
}