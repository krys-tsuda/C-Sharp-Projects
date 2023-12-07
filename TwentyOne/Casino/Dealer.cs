using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        // Dealer "has a" deck, not "is a" deck
        // therefore does not inherit from class Deck but has a property of class Deck
        public Deck Deck { get; set; }  
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            // add to list Hand, that is then passed into Deal
            Hand.Add(Deck.Cards.First());   // method available to list takes first item
            string card = string.Format(Deck.Cards.First().ToString() + "\n");  // formatting card dealt to string
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"F:\TechAcademy\WorkingBranch\Logs\log.txt", true))   // creating new object StreamWriter, path, append true
            {
                file.WriteLine(DateTime.Now);   // property what writes time at exact moment
                file.WriteLine(card);   // write string card to file
            }
            Deck.Cards.RemoveAt(0); // method removes index item from deck
        }
    }
}
