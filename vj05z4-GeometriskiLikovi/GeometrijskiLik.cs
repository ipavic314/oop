using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vj05z4
{
   abstract class GeometrijskicLik
    {
        protected GeometrijskicLik(string boja)
        {
            Boja = boja;
        }

        public string Boja { get; set; }
        public abstract double Povrsina();
        public abstract double Opseg();
    }
}
