﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Card card = new Card() { Face = "King", Suit = "Spades" };
            //Game game = new Game();
            //game.Dealer = "Jesse";
            //game.Name = "TwentyOne";
            //Game game = new Game();
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            //game.ListPlayers();
            //Console.ReadLine();

            //example of polymorphism
            //Game game = new TwentyOneGame();

            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            game.ListPlayers();
            Console.ReadLine();

           //Deck deck = new Deck();
           //deck.Shuffle(3);

           //// //deck = Shuffle(deck);
           //// //deck = Shuffle(deck, 3);
           //// //deck = Shuffle(deck, 3);
           //// //deck = Shuffle(deck: deck, times: 3);


           //// //int timesShuffled = 0;
           //// //deck = Shuffle(deck, out timesShuffled, 3);

           //foreach (Card card in deck.Cards)
           // {
           //     Console.WriteLine(card.Face + " of " + card.Suit);
           // }
           //Console.WriteLine(deck.Cards.Count);
           ////// Console.WriteLine("Times shuffled: {0}", timesShuffled);

           //// //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);
           //Console.ReadLine();
        }

        

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i=0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
