using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vj05z4
{
    class Pravokutnik : GeometrijskicLik
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Pravokutnik(string boja, int x, int y) : base(boja)
        {
            X = x;
            Y = y;
        }

        public override double Opseg() => 2 * (X + Y);


        public override double Povrsina() => X * Y;
       
    }
}
