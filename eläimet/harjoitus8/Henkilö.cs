using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus8
{
    abstract class Henkilo
    {
        public string Nimi { get; set; }
        public string Tyopaikka { get; set; }
        public double Palkka { get; set; }

        public Henkilo(string nimi, string tyopaikka, double palkka)
        {
            Nimi = nimi;
            Tyopaikka = tyopaikka;
            Palkka = palkka;
        }
    }
}
