using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace War_of_the_Immortals.Interfaces
{
    interface IEffect
    {
        void Effect();
        long Effect(params int[] d);
        string Effect(params string[] s);
    }
}