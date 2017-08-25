using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace War_of_the_Immortals.models
{
    public class Deck
    {
        private List<Card> deck;
        private List<Card> deck2;
        public string AddCard(Card c) { if (deck.Count < 70) { deck.Add(c); return "Card Added"; } return "Card not added Deck already full."; }
        public string RemoveCard(Card c) { if (deck.Contains(c)) { deck.Remove(c); return "Card removed successfully"; } return "Cannot remove card because it is not in the deck."; }
        public void Shuffle()
        {
            deck2 = deck;
            Random R = new Random();
            for (int i = 0; i < deck2.Count; i++)
            {
                int e = R.Next(deck2.Count);
                Card temp = deck2[e];
                deck2[e] = deck2[i];
                deck2[i] = temp;
            }
        }
        public Card Draw()
        {
            Card c= deck2[0];
            deck2.Remove(deck2.ElementAt(0));
            return c;
        }
    }
}