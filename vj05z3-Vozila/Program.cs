using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vj05z3
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("589", "Opel", 125);
            auto.Vozi();
            auto.Stani();
            SportskiAuto sa = new SportskiAuto("985", "Lamborgini", 250);
            sa.Vozi();
            sa.Stani();
            sa.Driftaj();
        }
    }
}
