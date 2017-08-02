using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using War_of_the_Immortals.Interfaces;
namespace War_of_the_Immortals.models.Soldier
{
    public class Soldier : Card, IUpperField
    {
        public int ATK { get; set; } 
        public int DEF { get; set; }
    }
}