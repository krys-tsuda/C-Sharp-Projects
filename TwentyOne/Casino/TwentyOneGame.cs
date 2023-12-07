using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Casino.Interfaces;

namespace Casino.TwentyOne
{
    // inherits from Game and IWalkAway
    public class TwentyOneGame : Game, IWalkAway
    {
        // property of Dealer 
        public TwentyOneDealer Dealer { get; set; } 

        // use override to implement method from abstract class
        public override void Play()
        {
            Dealer = new TwentyOneDealer();    // create new object of TwentyOneDealer
            foreach (Player player in Players)  // for each player playing
            {
                player.Hand = new List<Card>();    // new hand
                player.Stay = false;    // player property Stay set to false
            }
            Dealer.Hand = new List<Card>();    // Dealer gets new hand
            Dealer.Stay = false;    // Dealer property stay set to false
            Dealer.Deck = new Deck();   // new deck for every game
            Dealer.Deck.Shuffle(3);
            
            // loop through each player have them place bet
            foreach (Player player in Players)
            {
                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bet!");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);    // converts string input to integer, output is bet
                    if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");  // if not valid prints message to console
                }
                if (bet < 0)
                {
                    throw new FraudException("Security! Kick this person out.");
                }
                bool successfullyBet = player.Bet(bet);   // passing their bet into bet mothod
                if (!successfullyBet)
                {
                    return;    // saying end this method
                }
                Bets[player] = bet;   // adding to dictionary Bets key player with value bet
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.WriteLine($"{player.Name}");
                    Dealer.Deal(player.Hand);   // passing in players hand is given card and then printed to console
                    if (i == 1)    // second turn
                    {
                        bool blackJack = TwentyOne.TwentyOneRules.CheckForBlackJack(player.Hand);   // cheacks if player got blackjack
                        if (blackJack)  // if yes do this
                        {
                            Console.WriteLine($"Blackjack! {player.Name} wins {Bets[player]}");
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]); // adds to players balance original bet and  bet * 1.5
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);   // Dealer deals dealers hand
                if (i == 1)    // second turn
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);     // cheacks if dealer got black jack
                    if (blackJack)  // if yes do this
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");     // prints message to console
                        foreach (KeyValuePair<Player, int> entry in Bets)   // for each player and bet entry in Bets
                        {
                            Dealer.Balance += entry.Value;  // add to dealers balance
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)    // while player does not stay loop continues
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)  // iterates every card in Player Hand
                    {
                        Console.Write($"{card.ToString()} ");    // console displays card value formatted by ToString()
                    }
                    Console.WriteLine("\n\nHit or stay?");  // pormpts player hit or stay
                    string answer = Console.ReadLine().ToLower();   // converts to lower 
                    if (answer == "stay")   // if input is the same as 'stay'
                    {
                        player.Stay = true; // Stay is true 
                        break;  // ending loop
                    }
                    else if (answer == "hit")   // if 'hit'
                    {
                        Dealer.Deal(player.Hand);   // Deal another hand
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand); // checks to see if player busted
                    if (busted)
                    {
                        Dealer.Balance += Bets[player]; // add players bet to dealers balance
                        Console.WriteLine($"{player.Name} Busted! \nYou lose your bet of {Bets[player]}. Your balance is now {player.Balance}.");   // displays to console if player busts
                        Console.WriteLine("Do you want to play again?");    // asks player to play again
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah" )   // if yes
                        {
                            player.isActivelyPlaying = true;    // still actively playing
                        }
                        else
                        {
                            player.isActivelyPlaying = false;   //not actively playing
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);    // checks if dealer busted
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);    // checks if dealer should stay
            while (!Dealer.Stay && !Dealer.isBusted)    // while dealer is not staying or busted
            {
                Console.WriteLine("Dealer is hitting...");  
                Dealer.Deal(Dealer.Hand);   // deal Dealer Hand
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);    // checks if dealer busted
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);    //checks if deal should stay
            }
            if (Dealer.Stay)    // if dealer stays
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)    // if dealer busts
            {
                Console.WriteLine("Dealer busted!");    
                foreach (KeyValuePair<Player, int> entry in Bets)   // for each key of KeyValuePair entry in Bets
                {
                    Console.WriteLine($"{entry.Key.Name} won {entry.Value}");   // formats Key Name won value of entry
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);  // First find Player where Name is the same as entry Key Name then add entry value times 2 to  Balance
                    Dealer.Balance -= entry.Value;  // deducts entry value from dealers balance
                }
                return;
            }
            // if no one busts or gets blackjack
            foreach (Player player in Players)
            {
                // passes player hand and dealers hand into CompareHands() method and sets the results as the value of bool var playerWon
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);    // player won = true, dealer won = false, tie = null
                if (playerWon == null)  // if null
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player];    // add value of players bet to players balance
                }
                else if (playerWon == true)    // if player wins
                {
                    Console.WriteLine($"{player.Name} won {Bets[player]}!");
                    player.Balance += (Bets[player] * 2);   // add value of players bet and bet * 2 to players balance
                    Dealer.Balance -= Bets[player];    // deduct from dealers balance
                }
                else    // if dealer wins
                {
                    Console.WriteLine($"Dealer wins {Bets[player]}");
                    Dealer.Balance += Bets[player];    // add value of players bet to dealers balance
                }
                Console.WriteLine("Play again?");   // ask if player wants to play again
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")    // if yes
                {
                    player.isActivelyPlaying = true;    // player is actively playing set to true
                    return;
                }
                else
                {
                    player.isActivelyPlaying = false;   // player is actively playein set to false
                    return;
                }
            }
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
