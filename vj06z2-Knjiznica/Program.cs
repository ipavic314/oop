using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vj06z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Knjiga k1 = new Knjiga("koko", "Ivana", 2567897854921);
            Knjiga k2 = new Knjiga("joko", "Maja", 1234597854921);
            Knjiga k3 = new Knjiga("Nolo", "Marina", 2567897812345);

            List<Knjiga> knjige = new List<Knjiga> { k1, k2, k3 };
            knjige.Sort();
            knjige.ForEach(Console.WriteLine);
            foreach (var item in knjige)
            {
                Console.WriteLine(item);
            }
        }
    }
}
