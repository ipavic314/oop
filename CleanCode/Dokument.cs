using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    class Dokument :IPotpis
    {
        public Dokument(string naziv, string tekst)
        {
            Naziv = naziv;
            Tekst = tekst;
        }

        public string Naziv { get; set; }
        public string Tekst { get; set; }
        public bool Potpisan { get; private set; }

        public void Sign() => Potpisan = true;

        public override string ToString() => $"Naziv: {Naziv}, tekst: {Tekst}, Potpisan: {(Potpisan ? "da" : "Ne")}";
       
    }
}
