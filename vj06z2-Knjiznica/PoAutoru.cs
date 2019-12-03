using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vj06z2
{
    class PoAutoru : IComparer<Knjiga>
    {
        public int Compare(Knjiga x, Knjiga y) => x.Naslov.CompareTo(y.Naslov);
       
    }
}
