using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    class Kolegij : IPotpis
    {
        public string Sifra { get; set; }
        public string Naziv { get; set; }
        private int ects;

        public Kolegij(string sifra, string naziv, int ects)
        {
            Sifra = sifra;
            Naziv = naziv;
            Ects = ects;
        }

        public int Ects
        {
            get => ects;
            set
            {
                if (value < 20 || value > 30)
                {
                    throw new Exception("Greska");
                }

                ects = value;
            }


        }

        public bool Odobren { get; private set; }

        public void Sign() => Odobren = true;

        public override string ToString() => $"Sifra: {Sifra}, naziv: {Naziv}, ects: {ects.IntInFormat("ects")}, Potvrden: {(Odobren?"da":"ne")}";
    

    }
}
