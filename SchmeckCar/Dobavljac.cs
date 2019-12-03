using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmeckCar
{
    class Dobavljac : Osoba
    {
        public Dobavljac(string ime, string oib, string adresa, string kontakt, List<string> ziroracun) : base(ime, oib, adresa, kontakt)
        {
            ZiroRacun = ziroracun;
        }

        public List<string> ZiroRacun { get; set; }


    }
}
