using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vj06z1
{
    class Zarulja : IPaliGasi
    {
        public Zarulja(int duljinaNiti, int snaga)
        {
            DuljinaNiti = duljinaNiti;
            Snaga = snaga;
        }

        public int DuljinaNiti { get; set; }
        public int Snaga { get; set; }

        public void Gasi() => Console.WriteLine("Zarulja pali!");


        public void Pali() => Console.WriteLine("Zarulja gasi!");
       

        public override string ToString() => $"Duljina niti {DuljinaNiti.IntInFormat("mm")}, Snaga: {Snaga.IntInFormat("W")}";


       
    }
}
