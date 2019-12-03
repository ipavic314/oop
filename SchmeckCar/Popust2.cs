using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmeckCar
{
    class Popust2 : IPopust
    {
        public double IzracunajKonacnuCijenu(int iznos) => iznos * 0.95;
       
    }
}
