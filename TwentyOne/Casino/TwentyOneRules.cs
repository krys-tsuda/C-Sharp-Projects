using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Casino.TwentyOne
{
    public class TwentyOneRules
    {
        // naming convention in private classes is _"name"
        //  best practice to make a method private when only used within its class
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        { 
            // Creeating object Dectionary with Face and int as key value pair
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };
        private static int[] GetAllPossibleHandValues(List<Card> Hand)  // Declaring an array with argument data type List or objects Card called Hand
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace); // setting int var value to the count of how many aces in Hand
            int[] result = new int[aceCount + 1];   // adding int of how many aces + 1 to array of results
            int value = Hand.Sum(x => _cardValues[x.Face]); // setting int value to dictionary item key Face
            result[0] = value;  // value is set to fist index
            if (result.Length == 1)  // if the length of array is 1 return result
            {
                return result;
            }
            for (int i = 1; i < result.Length; i++) // iterrate through as long as i is less then length of array adding 1 every time
            {
                value =+ (i * 10);  // value plus i times ten  is value
                result[i] = value;  // array item set to value of value
            }
            return result;
        }
        public static bool CheckForBlackJack(List<Card> Hand)   // method checks for blackjack
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);  // fills array with all possible values of Hand
            int value = possibleValues.Max();   // value set to Max of possibleVales
            if (value == 21) return true;   // if value is 21 return true
            else return false;  // otherwise false
        }
        public static bool IsBusted(List<Card> Hand)    // checks if busted
        {
            int value = GetAllPossibleHandValues(Hand).Min();   // value set to min of all possible hand values of hand
            if (value < 21) return true;    // if value is less than 21 return true
            else return false;  // other wise false
        }
        public static bool ShouldDealerStay(List<Card> Hand)    // checks if dealer should stay
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);  // fils array with possible values of Hand
            foreach (int value in possibleHandValues)  // for each possible hand value
            {
                if(value > 16 && value < 22)    // if value is greater than 16 and less than 22
                {
                    return true;    // return true
                }
            }
            return false;   // otherwise false
        }
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)  // compares player and dealer hands
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand); // array of players possible hand values
            int[] dealerResults = GetAllPossibleHandValues(DealerHand); // array of dealers possible hand values

            // determines winner
            int playerScore = playerResults.Where(x => x < 22).Max();   // gets players list of values less than 22 then gets the highest one
            int dealerScore = dealerResults.Where(x => x < 22).Max();   // gets dealers lsit of values less than 22 then gets the highest one

            if (playerScore > dealerScore) return true;    // comparison if player wins
            else if (playerScore < dealerScore) return false;   // comparison if dealer wins
            else return null;   // if there is a tie
        }
    }
}
