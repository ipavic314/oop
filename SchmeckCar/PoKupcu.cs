using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmeckCar
{
    class PoKupcu : IComparer<Prodaja>
    {
        public int Compare(Prodaja x, Prodaja y) => x.Kupac.Ime.CompareTo(y.Kupac.Ime);
       
    }
}
