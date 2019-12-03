using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmeckCar
{
    abstract class Osoba
    {
        protected Osoba(string ime, string oib, string adresa, string kontakt)
        {
            Ime = ime;
            Oib = oib;
            Adresa = adresa;
            Kontakt = kontakt;
        }

        public string Ime { get; set; }
        public string Oib { get; set; }
        public string Adresa { get; set; }
        public string Kontakt { get; set; }

        public override string ToString() => $"Ime: {Ime}, oib:{Oib}, adresa: {Adresa}, kontakt:{Kontakt}";
       
    }
}
