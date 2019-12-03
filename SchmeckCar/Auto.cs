using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmeckCar
{
    class Auto
    {
        public Auto(DateTime datum, string sasija, string marka, string autoTip, int brojSjedecihMjesta, int brojVrata, string karoserija, int snaga, int velicinaRezervoara, List<TipRezervoara> tip)
        {
            Datum = datum;
            Sasija = sasija;
            Marka = marka;
            AutoTip = autoTip;
            BrojSjedecihMjesta = brojSjedecihMjesta;
            BrojVrata = brojVrata;
            Karoserija = karoserija;
            Snaga = snaga;
            VelicinaRezervoara = velicinaRezervoara;
            Tip = tip;
        }

        public DateTime Datum { get; set; }
        public string Sasija { get; set; }
        public string Marka { get; set; }
        public string AutoTip { get; set; }
        public int BrojSjedecihMjesta { get; set; }
        public int BrojVrata { get; set; }
        public string Karoserija { get; set; }
        public int Snaga { get; set; }
        public int VelicinaRezervoara { get; set; }
        public List<TipRezervoara> Tip { get; set; }
        public enum TipRezervoara
        {
            Benzinski, 
            Plinski
        }







    }
}
