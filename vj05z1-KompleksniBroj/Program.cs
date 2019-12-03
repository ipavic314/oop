using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vj05z1
{
    class Program
    {
        static void Main(string[] args)
        {
            KompleksniBroj k1 = new KompleksniBroj(3, 2);
            KompleksniBroj k2 = new KompleksniBroj(3, 2);
            Console.WriteLine(k1);
            Console.WriteLine(k2);
            Console.WriteLine("----------------------------");
            Console.WriteLine(k1.Equals(k2));
            Console.WriteLine(k1 == k2);
        }
    }
}
