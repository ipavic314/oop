using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vj05z2
{
    class Zaba
    {
        public Zaba(int brojNogu, string boja)
        {
            BrojNogu = brojNogu;
            Boja = boja;
        }

        public int BrojNogu { get; set; }
        public string Boja { get; set; }


        public override string ToString() => $"Broj nogu:{BrojNogu}, Boja: {Boja}";

        /* public override bool Equals(object obj)
         {
             if (obj is Zaba other)
             {
                 return BrojNogu == other.BrojNogu && Boja == other.Boja;
             }
             else
             {
                 return false;
             }
         }*/

        // drugi nacin 
        public override bool Equals(object obj) => obj is Zaba other ? BrojNogu == other.BrojNogu && Boja == other.Boja : false;


        public override int GetHashCode()
        {
            return BrojNogu.GetHashCode() + Boja.GetHashCode();
        }



    }
}
