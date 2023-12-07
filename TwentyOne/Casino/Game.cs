using System;
using System.Collections.Generic;

namespace Casino
{ 
    // the more generic you make code the easier you can add features
    public abstract class Game
    {
        private List<Player> _players = new List<Player>(); // private list makes sure theres always an empty list
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }  // dicitonary to store bets

        // abstract method (only exists in abstract class)
        // any class inheriting from this class must implement
        public abstract void Play();

        // virtual method (only exists in abstract class) gets inherited 
        // inheriting class has the ability to override it
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
