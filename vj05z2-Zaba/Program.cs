using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vj05z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Zaba z1 = new Zaba(5, "zelena");
            Zaba z2 = new Zaba(5, "zelena");
            Console.WriteLine(z1);
            Console.WriteLine(z2);

            Console.WriteLine(z1.Equals(z2));

            HashSet<Zaba> zabe = new HashSet<Zaba> { z1, z2 };

            foreach (var item in zabe)
            {
                Console.WriteLine(item);
            }


        }
    }
}
