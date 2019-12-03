using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmeckCar
{
    class Popust3 : IPopust
    {
        public double IzracunajKonacnuCijenu(int iznos)
        {
            if (iznos < 100)
            {
                return iznos * 0.97;
            }
            else
            {
                return iznos * 0.93;
            }
        }
    }
}
