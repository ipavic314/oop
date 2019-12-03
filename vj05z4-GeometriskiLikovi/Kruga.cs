using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vj05z4
{
    class Kruga : GeometrijskicLik
    {
        public int Promjer { get; set; }
        public Kruga(string boja, int promjer) : base(boja)
        {
            Promjer = promjer;
        }

        public override double Opseg() => 2 * Promjer * Math.PI;


        public override double Povrsina() => Promjer * Math.PI;
      
    }
}
