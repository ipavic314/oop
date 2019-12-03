using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vj06z1
{
    class Pec : IPaliGasi
    {
        public Pec(string proizvodac, TipPec tip)
        {
            Proizvodac = proizvodac;
            Tip = tip;
        }

        public string Proizvodac { get; set; }
        public TipPec Tip { get; set; }

        public void Gasi() => Console.WriteLine("Pec gasi");


        public void Pali() => Console.WriteLine("Pec pali");
       

        public override string ToString() => $"Proizvodac: {Proizvodac}, Tip: {Tip}";
       
    }
}
