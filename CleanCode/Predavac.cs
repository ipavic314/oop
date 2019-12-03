using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    class Predavac : Osoba
    {
        public Kolegij Kolegij { get; set; }
        public Predavac(string ime, string prezime, Kolegij kolegij) : base(ime, prezime)
        {
            Kolegij = kolegij;
        }

        public override string ToString() => $"{base.ToString()}, kolegij: {Kolegij}";


     
    }
}
