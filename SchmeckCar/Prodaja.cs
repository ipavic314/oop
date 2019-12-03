using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmeckCar
{
    class Prodaja :IComparable<Prodaja>
    {
        public Prodaja(Kupac kupac, DateTime datumKupovine,int iznos, IPopust popust, Auto auto)
        {
            Kupac = kupac;
            DatumKupovine = datumKupovine;
            Iznos = iznos;
            Popust = popust; 
            Auto = auto;
        }

        public Kupac Kupac { get; set; }
        public DateTime DatumKupovine { get; set; }
        public Auto Auto { get; set; }
        public int Iznos { get; set; }
        public IPopust Popust { get; set; }

        public int CompareTo(Prodaja other) => -Popust.IzracunajKonacnuCijenu(Iznos).CompareTo(other.Popust.IzracunajKonacnuCijenu(other.Iznos));

        public override string ToString() => $"Kupac: {Kupac}, Datum kupovine: {DatumKupovine}, Auto: {Auto}, Iznos: {Iznos}, Popust: {Popust}";
     
    }
}
