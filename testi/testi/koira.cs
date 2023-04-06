using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testi
{
    internal class koira
    {
        public string nimi { get; set; }
        public int ikä { get; set; }
        public string väri { get; set; }
        public float paino { get; set; }
        public string rotu { get; set; }


      

        public void hauku()
        {
            Console.WriteLine("hau");

        }

        public string haetiedot()
        {
            string koirantiedot = "nimi: " + nimi + " ikä: " + ikä.ToString() + " väri: " + väri +" paino: " + paino.ToString() + " rotu: " + rotu;
    

                return koirantiedot;

        }

    }
}
