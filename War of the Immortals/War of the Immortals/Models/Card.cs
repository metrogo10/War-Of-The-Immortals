using IMMORTALS.Gods;
using IMMORTALS.nonCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IMMORTALS
{
    public class Card
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string CardType { get; set; }
        public Rarity Rarity { get; set; }
        public List<CardCost> Cost { get; set; }
        public bool Splitcost { get; set; }
    }
}