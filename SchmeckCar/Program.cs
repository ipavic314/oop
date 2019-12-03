using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmeckCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto(DateTime.Now, "123456", "Opel", "Astra", 5, 5, "Karavan", 150, 15, new List<Auto.TipRezervoara> {Auto.TipRezervoara.Benzinski });
            Auto a2 = new Auto(DateTime.Now, "654321", "Suzuki", "Vitara", 4, 5, "Jeep", 250, 20, new List<Auto.TipRezervoara> { Auto.TipRezervoara.Benzinski });

            Dobavljac d = new Dobavljac("Maja", "789456", "Bartolici", "maja@mail", new List<string> { "4596863" });
            Kupac k1 = new Kupac("Nela", "582976", "Petrova", "nela@gmail", "croatia", "758968", "Zagreb");
            Kupac k2 = new Kupac("Maja", "582976", "Petrova", "nela@gmail", "croatia", "758968", "Zagreb");

            Nabava n1 = new Nabava(d, DateTime.Now, 600000, 100000, 800000, a1);
            Nabava n2 = new Nabava(d, DateTime.Now, 50000, 10000, 80000, a2);

            Prodaja p1 = new Prodaja(k1, DateTime.Now, 80000, new Popust1(), a1);
            Prodaja p2 = new Prodaja(k2, DateTime.Now, 80000, new Popust2(), a2);

            List<Prodaja> prodano = new List<Prodaja> { p1, p2 };
            prodano.Sort();
            foreach (var item in prodano)
            {
                Console.WriteLine(item.Popust.IzracunajKonacnuCijenu(item.Iznos));
            } 

            Console.WriteLine("------------------------------");
            prodano.Sort(new PoKupcu());
            foreach (var item in prodano)
            {
                Console.WriteLine(item.Kupac.Ime);
            }

        }
    }
}
