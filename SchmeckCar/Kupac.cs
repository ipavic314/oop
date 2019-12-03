using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmeckCar
{
    class Kupac : Osoba
    {
        public string OsiguravajucaKuca { get; set; }
        public string BrojOsobne { get; set;}
        public string MjestoIzdavanja { get; set; }
        public Kupac(string ime, string oib, string adresa, string kontakt, string osiguravajucakuca, string brojosobne, string mjestoizdavanja) : base(ime, oib, adresa, kontakt)
        {
            OsiguravajucaKuca = osiguravajucakuca;
            BrojOsobne = brojosobne;
            MjestoIzdavanja = mjestoizdavanja; 
        }


    }
}
