using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        public Deck()
        {
           

            //create an empty list of cards
            Cards = new List<Card>();

            for (int i=0; i<13; i++)
            {
                for (int j=0; j<4;j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
            
        }
        public List<Card> Cards { get; set; }

        //public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        public void Shuffle(int times = 1)
        {
            //timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
               // timesShuffled++;
                List<Card> TempList = new List<Card>();

                Random random = new Random();

                //while (deck.Cards.Count > 0)
                //{
                //    int randomIndex = random.Next(0, deck.Cards.Count);
                //    TempList.Add(deck.Cards[randomIndex]);
                //    deck.Cards.RemoveAt(randomIndex);
                //}

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                this.Cards = TempList;
            }
            //return deck;
        }
    }
}
