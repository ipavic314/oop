using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vj05z1
{
    class KompleksniBroj
    {
        public KompleksniBroj(int re, int im)
        {
            Re = re;
            Im = im;
        }

        public int Re { get; set; }
        public int Im { get; set; }

        public override string ToString() => $"{Re} + {Im.IntInFormat("i")}";

        public override bool Equals(object obj)
        {
            if (obj is KompleksniBroj other)
            {
                return Re == other.Re && Im == other.Im;
            }
            else
            {
                return false;
            }
        }

       /* public override int GetHashCode()
        {
            var hashCode = 29377563;
            hashCode = hashCode * -1521134295 + Re.GetHashCode();
            hashCode = hashCode * -1521134295 + Im.GetHashCode();
            return hashCode;
        }*/

        public override int GetHashCode()
         {
             return Re.GetHashCode() + Im.GetHashCode();
         }

        public static bool operator ==(KompleksniBroj x, KompleksniBroj y) => x.Re == y.Re && x.Im == y.Im;
        public static bool operator !=(KompleksniBroj x, KompleksniBroj y) => x.Re != y.Re && x.Im != y.Im;

    }
}
