using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    class Dekan : Osoba
    {
        public string Titula { get; set; }
        public Dekan(string ime, string prezime, string titula) : base(ime, prezime)
        {
            Titula = titula;
        }

        public override string ToString() => $"{base.ToString()}, titula: {Titula}";

        public void DajPotpis(IPotpis potpis) => potpis.Sign();
       
    }
}
