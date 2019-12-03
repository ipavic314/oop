using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vj05z3
{
    class SportskiAuto : Auto
    {

        public SportskiAuto(string brojSasije, string tip, int ubrzanje) : base(brojSasije, tip, ubrzanje)
        {
        }

        public override void Stani() => Console.WriteLine("Sportski auto stani");
        public override void Vozi() => Console.WriteLine("Sportski auto vozi");

        public void Driftaj() => Console.WriteLine("SPortski auto deiftaj");


      
    }
}
