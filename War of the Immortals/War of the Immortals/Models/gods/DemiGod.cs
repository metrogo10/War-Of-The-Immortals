using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using War_of_the_Immortals.Interfaces;
namespace War_of_the_Immortals.models.gods
{
    public class DemiGod : Card, IOuterField, IEffect
    {
        public void Effect()
        {
            throw new NotImplementedException();
        }
        public long Effect(params int[] d)
        {
            throw new NotImplementedException();
        }
        public string Effect(params string[] s)
        {
            throw new NotImplementedException();
        }
    }
}