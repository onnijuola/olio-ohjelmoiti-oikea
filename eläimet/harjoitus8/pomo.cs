using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus8
{
    internal class pomo
    {
        class Pomo : Henkilo
        {
            public double Boonus { get; set; }
            public string Auto { get; set; }

            public Pomo(string nimi, string tyopaikka, double palkka, double boonus, string auto)
                : base(nimi, tyopaikka, palkka)
            {
                Boonus = boonus;
                Auto = auto;
            }
        }

    }
}
