using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
   abstract class Osoba
    {
        protected Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        public string Ime { get; set; }
        public string Prezime { get; set; }

        public override string ToString() => $"Ime: {Ime}, Prezime: {Prezime}";

        

    }
}
