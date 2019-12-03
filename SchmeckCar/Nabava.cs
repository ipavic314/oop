using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmeckCar
{
    class Nabava
    {
        public Nabava(Dobavljac dobavljac, DateTime datumNabave, int placenIznos, int davanja, int prodajnaCijena, Auto auto)
        {
            Dobavljac = dobavljac;
            DatumNabave = datumNabave;
            PlacenIznos = placenIznos;
            Davanja = davanja;
            ProdajnaCijena = prodajnaCijena;
            Auto = auto;
        }

        public Dobavljac Dobavljac { get; set; }
        public DateTime DatumNabave { get; set; }
        public int PlacenIznos { get; set; }
        public int Davanja { get; set; }
        public int ProdajnaCijena { get; set; }
        public Auto Auto { get; set; }
    }
}
