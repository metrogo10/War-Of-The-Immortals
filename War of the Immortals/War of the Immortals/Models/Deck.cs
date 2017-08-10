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
        public string AddCard(Card c) { if (deck.Count < 70) { deck.Add(c); return "Card Added"; } return "Card not added Deck already full."; }
        public string RemoveCard(Card c) { if (deck.Contains(c)) { deck.Remove(c); return "Card removed successfully"; } return "Cannot remove card because it is not in the deck."; }
    }
}