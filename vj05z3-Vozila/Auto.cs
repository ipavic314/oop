using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vj05z3
{
    class Auto
    {
        public Auto(string brojSasije, string tip, int ubrzanje)
        {
            BrojSasije = brojSasije;
            Tip = tip;
            Ubrzanje = ubrzanje;
        }

        public string BrojSasije { get; set; }
        public string Tip { get; set; }
        public int Ubrzanje { get; set; }

        public virtual void Vozi() => Console.WriteLine("Auto vozi");
        public virtual void Stani() => Console.WriteLine("Auto stani");

      
       
    }
}
