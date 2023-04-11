using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus1
{
    internal class auto
    {
        public string nimi { get; set; }
        public int nopeus { get; set; }
       
        public float renkaat { get; set; }





        public void lisätieto()
        {
            Console.WriteLine("tässä ovat tietoni ");

        }

        public string haetiedot()
        {
            string autontiedot = "nimi: " + nimi + " nopeus: " + nopeus.ToString() + " renkaat: " + renkaat.ToString();


            return autontiedot;

        }

    }

}

