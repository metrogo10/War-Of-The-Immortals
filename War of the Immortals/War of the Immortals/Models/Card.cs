using IMMORTALS.Gods;
using IMMORTALS.nonCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace War_of_the_Immortals
{
    public class Card
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Rarity Rarity { get; set; }
        public List<CardCost> Cost { get; set; }
        public bool Splitcost { get; set; }
    }
}