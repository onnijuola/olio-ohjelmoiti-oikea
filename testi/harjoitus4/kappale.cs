using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus4
{
    internal class kappale
    {
        public string Nimi { get; set; }
        public string Artisti { get; set; }
        public int Julkaisuvuosi { get; set; }
        public List<Kappale> Kappaleet { get; set; }

        public kappale(string nimi, string artisti, int julkaisuvuosi)
        {
            Nimi = nimi;
            Artisti = artisti;
            Julkaisuvuosi = julkaisuvuosi;
            Kappaleet = new List<Kappale>();
        }

        public void LisaaKappale(Kappale kappale)
        {
            Kappaleet.Add(kappale);
        }

        public void TulostaAlbumi()
        {
            Console.WriteLine("Albumin tiedot:");
            Console.WriteLine("Nimi: " + Nimi);
            Console.WriteLine("Artisti: " + Artisti);
            Console.WriteLine("Julkaisuvuosi: " + Julkaisuvuosi);
            Console.WriteLine("Kappaleet:");

            foreach (Kappale kappale in Kappaleet)
            {
                Console.WriteLine("- " + kappale.ToString());
            }
        }
    }

    class Kappale
    {
        public string Nimi { get; set; }
        public string Esittaja { get; set; }
        public int Kesto { get; set; }

        public Kappale(string nimi, string esittaja, int kesto)
        {
            Nimi = nimi;
            Esittaja = esittaja;
            Kesto = kesto;
        }

        public override string ToString()
        {
            return Nimi + " - " + Esittaja + " (" + Kesto + " s)";
        }
    }
}
