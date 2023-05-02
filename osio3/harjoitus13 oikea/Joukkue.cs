using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus13_oikea
{
    internal class Joukkue
    {
        public string Nimi { get; set; }
        public string Kotikaupunki { get; set; }
        private Dictionary<int, Pelaaja> Pelaajat { get; set; }

        public Joukkue(string nimi, string kotikaupunki)
        {
            Nimi = nimi;
            Kotikaupunki = kotikaupunki;
            Pelaajat = new Dictionary<int, Pelaaja>();
        }




        public Pelaaja HaePelaaja(int numero)
        {
            try
            {
                return Pelaajat[numero];
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Pelaajaa ei löytynyt numerolla " + numero);
                return null;
            }
        }

        public void LisaaPelaaja(Pelaaja pelaaja)
        {
            try
            {
                Pelaajat.Add(pelaaja.PelaajaNumero, pelaaja);
                Console.WriteLine("Pelaaja " + pelaaja.Etunimi + " " + pelaaja.Sukunimi + " lisättiin joukkueeseen " + Nimi);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Pelaaja numerolla " + pelaaja.PelaajaNumero + " on jo joukkueessa " + Nimi);
            }
        }

        public void PoistaPelaaja(int numero)
        {
            try
            {
                Pelaajat.Remove(numero);
                Console.WriteLine("Pelaaja numero " + numero + " poistettiin joukkueesta " + Nimi);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Pelaajaa ei löytynyt numerolla " + numero);
            }
        }

        public List<Pelaaja> HaePelaajat()
        {
            return new List<Pelaaja>(Pelaajat.Values);
        }
    }
}

