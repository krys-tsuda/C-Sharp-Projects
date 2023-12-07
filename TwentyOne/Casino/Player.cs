using System;
using System.Collections.Generic;


namespace Casino
{
    public class Player
    {
        // constructor call chain
        public Player(string name) : this(name, 100)    // assign name to name if no balance is provided default 100
        {
            // doesn't need any implementation, uses code from other constructor
        }
        // Player construct when object is first created will have name and beginning balance
        public Player(string name, int beginningBalance)
        {
            // class properties
            Hand = new List<Card>();    // new hand
            Balance = beginningBalance;    // a starting balance
            Name = name;    // a name
        }
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }    
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        public Guid Id { get; set; }
        // method for player to place bet
        public bool Bet(int amount)
        {
            if (Balance - amount < 0)   // if player does not have enough to pleace bet
            {
                Console.WriteLine("You do not have anough to place a bet that size.");  // message prints to console
                return false;   // returns a value of false
            }
            else
            {
                Balance -= amount; // deducts bet from balance
                return true;
            }
        }
        // overloading an operator+ taking two operands game and player
        public static Game operator +(Game game, Player player)
        {
            // takes game and adds player then returns game
            game.Players.Add(player);
            return game;
        }
        // overloading an operator- taking two operands game and player
        public static Game operator -(Game game, Player player)
        {
            // takes game and removes player then returns game
            game.Players.Remove(player);
            return game;
        }
    }
}
