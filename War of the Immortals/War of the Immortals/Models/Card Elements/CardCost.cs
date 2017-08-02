using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace War_of_the_Immortals.models.CardElements
{
    public class CardCost
    {
        public Element e { get; set; }
        public int Quantity { get; set; }
        public bool Payed { get; set; }
    }
}