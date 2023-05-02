using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus12
{
    internal class Korttipakka
    {
        private List<string> kortit;

        public Korttipakka()
        {
            kortit = new List<string> { "Ässä", "Kakkonen", "Kolmonen", "Nelonen", "Viitonen", "Kuutonen", "Seiska",
                                    "Kasi", "Ysi", "Kymppi", "Jätkä", "Kuningatar", "Kuningas" };
        }

        public void TulostaKorttipakka()
        {
            foreach (string kortti in kortit)
            {
                Console.WriteLine(kortti);
            }
        }

        public void SekoitaKorttipakka()
        {
            Random random = new Random();
            int n = kortit.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                string kortti = kortit[k];
                kortit[k] = kortit[n];
                kortit[n] = kortti;
            }
        }
    }
}
