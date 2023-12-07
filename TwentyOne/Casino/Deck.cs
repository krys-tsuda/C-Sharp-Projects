using System;
using System.Collections.Generic;

namespace Casino
{
    public class Deck
    {
        //constructor, method called when an object is created
        public Deck()
        {
            Cards = new List<Card>();   //instantiates property cards as an empty list
            
            for (int i = 0; i < 13; i++)    // loops through amount of Faces
            {
                for (int j = 0; j < 4; j++) // loops through amount of Suits
                {
                    Card card = new Card(); // creating new card
                    card.Face = (Face)i;    // casting value of j to Face
                    card.Suit = (Suit)j;    // casting value of i to Suit
                    Cards.Add(card);    // adding card to list Cards
                }
            }
        }
        public List<Card> Cards { get; set; }

        //accessible everywhere, so we dont have to create object, data type returning, name of function, parameters type and name
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();     //temp list to store shuffled cards
                Random random = new Random();   //new object from class Random

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);     //take a random index between 0-52
                    TempList.Add(Cards[randomIndex]);  //add it to temp list
                    Cards.RemoveAt(randomIndex);   //delete it from list of cards
                }
                this.Cards = TempList;  //then assign temp list to no empty deck of cards
            }
        }
        //method when someone wants to shuffle more than once
        //public static Deck Shuffle(Deck deck, int times)    //takes paramaters deck and how many times to shuffle
        //{
        //    for (int i = 0; i < times; i++) //loops until = to times
        //    {
        //        deck = Shuffle(deck);   //shuffle and then reassign 
        //    }
        //    return deck;   
        //}
    }
}
