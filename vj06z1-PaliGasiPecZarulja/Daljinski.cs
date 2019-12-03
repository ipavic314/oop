using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vj06z1
{
    class Daljinski : IVolume
    {
        public void Gasi() => Console.WriteLine("Gasi");


        public void Pali() => Console.WriteLine("Pali");


        public void VolumeDown() => Console.WriteLine("Stisaj");


        public void VolumeUp() => Console.WriteLine("Poglasni");
      
    }
}
