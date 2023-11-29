using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        bool continueLoop = false;

        while (!continueLoop)   //Assignment Part Two: Created an infinite while loop. No condition set for program to stop
        {
            //ASSIGNMENT PART ONE
            //ARRAY LOOP

            //one dimensional array of strings
            string[] favMovies = new string[] { "#3", "#2", "#1" };

            Console.WriteLine("\nWhat's your name?");
            string userName = Console.ReadLine();

            Console.WriteLine($"\nHi there {userName}! \n\nWhat are your top 3 favorite movies?");

            //promts user for top three movies updating array
            for (int i = 0; i < favMovies.Length; i++)  //for loop iterates through array items
            {
                Console.Write($"Enter your #{3 - i} favorite movie: "); //prints to console increasing fav movie increment
                favMovies[i] += " " + Console.ReadLine();  //appends user input to the end of each string
            }

            Console.WriteLine($"\n{userName}'s Top 3 Favorite Movies:");

            for (int i = 0; i < favMovies.Length; i++)  //iterates through array items 
            {
                Console.WriteLine(favMovies[i]);    //prints array item to console
            }

            //ASSIGNMENT PART TWO
            //INFINITE LOOP
            Console.WriteLine("\nWould anyone else like to list their favorite movies? \nYes or No:");
            string answer = Console.ReadLine();

            //created a condition for program to exit loop based on user input
            if (answer.ToLower() == "no")
            {
                continueLoop = true;    //ends program
            }
        }

        Console.ReadLine();

        //ASSIGNMENT PART THREE
        //ARRAY LOOP OPERATORS

        //instantiates an array
        string[] movieGenres = new string[] { "Horror", "Action", "Comedy", "Romance", "Drama" };   

        //LOOP WITH "<" OPERATOR
        Console.WriteLine("\nMovie Genres:");
        for (int i = 0; i < 5; i++)     //starting value, loops until condition is false, after each loop add 1
        {
            Console.WriteLine(movieGenres[i]);  //prints to console array item
        }

        //LOOP WITH  "<=" OPERATOR
        Console.WriteLine("\nMovie Genres:");
        for (int i = 0; i <= 4; i++)    //starting value, loops until condition is false, after each loop add 1
        {
            Console.WriteLine(movieGenres[i]);  //prints to console array item
        }

        Console.ReadLine();

        //ASSIGNMENT PART FOUR
        //SEARCH LIST

        //list of strings each item is unique
        List<string> pdxTheaters = new List<string>() { "Bagdad Theater", "Laurelhurst Theater", "Moreland Theater", "Hollywood Theater" };

        bool continueSearching = true;

        //loop continues while condition is met
        while (continueSearching)   
        {
            Console.WriteLine("\nSearch here for Portland movie theaters: ");
            string userSearch = Console.ReadLine();     //user input to search list

            bool matchFound = false;

            //loop that iterates through list
            foreach (string pdxTheater in pdxTheaters)
            {
                if (pdxTheater == userSearch)   //if user search matches an item 
                {
                    Console.WriteLine("Match found: " + pdxTheaters.IndexOf(pdxTheater));     //display index of list item to console
                    matchFound = true;  //stops loop if match found
                    break;
                }
            }

            if (!matchFound)    //if no match is found
            {
                Console.WriteLine("\nSorry, currently we have no information on that theater.");  //message prints to console
            }

            Console.WriteLine("\nDo you want to search again? (Yes/No):");    //prompts user for info to continue search
            string searchAgain = Console.ReadLine();

            if (searchAgain.ToLower() != "yes") //if user doesnt input yes
            {
                continueSearching = false;  //exits loop 
            }
        }

        Console.ReadLine();

        //ASSIGNMENT PART FIVE
        //SEARCH LIST MATCHING ITEMS

        //list of strings with identical items
        List<string> snackOrders = new List<string>() { "popcorn", "skittles", "snickers", "popcorn", "soda", "licorice" };

        Console.WriteLine("\nSearch for snacks ordered:");
        string snackSearch = Console.ReadLine();    //user input for search

        bool searchSnack = false;

        List<int> snackMatch = new List<int>();

        //loop iterates through list
        for (int i = 0; i < snackOrders.Count; i++)
        {
            if (snackOrders[i] == snackSearch)  //if user search matches an item
            {
                snackMatch.Add(i);
                searchSnack = true; //at least one match is found
            }
        }

        if (searchSnack) //if at least one match is found
        {
            Console.WriteLine("\nMatches found: " + string.Join(", ", snackMatch));
        }
        else   //if no match
        {
            Console.WriteLine("\nSorry, unable to find a match.");  //prints to console
        }

        Console.ReadLine();

        //ASSIGNMENT PART SIX
        //SEARTH LIST FOR DUPLICATES

        Console.WriteLine("\nSnack Inventory:");

        //list of strings with identical items
        List<string> inventoryItems = new List<string>() { "popcorn", "skittles", "m&m", "licorice", "sour patch", "skittles" };

        //HashSet to track unique items
        HashSet<string> uniqueItems = new HashSet<string>();

        //loop iterates through list
        foreach (string inventoryItem in inventoryItems)
        {
            if (!uniqueItems.Add(inventoryItem))    //checks if item is in HashSet
            {
                Console.WriteLine($"{inventoryItem}- item is a duplicate"); //prints to console if duplicate is found
            }
            else
            {
                Console.WriteLine($"{inventoryItem}- item is unique");  //prints to console if item is unique
            }
        }

        Console.ReadLine();

    }
}

