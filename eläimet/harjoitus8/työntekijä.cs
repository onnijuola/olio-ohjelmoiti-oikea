using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus8
{
    class Tyontekija : Henkilo
    {
        public double Viikkotunnit { get; set; }

        public Tyontekija(string nimi, string tyopaikka, double palkka, double viikkotunnit) : base(nimi, tyopaikka, palkka)
        {
            Viikkotunnit = viikkotunnit;
        }
    }
}
