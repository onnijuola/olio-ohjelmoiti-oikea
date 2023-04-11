using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus2
{
    internal class oppilas
    {


        public string nimi { get; set; }
        public string id { get; set; }
        public int pisteet { get; set; }

        public oppilas(string _nimi, string _id, int _pisteet)
        {
            nimi = _nimi;
            id = _id;
            pisteet = _pisteet;
        }






        public void muokkaa(int i)
        {
                Console.WriteLine("tässä nykyiset oppilaat ");
            pisteet += i;
               if (pisteet < 0) 
               {

                    pisteet = 0;            
               }
               
        }

            public string haetiedot()
            {
                string oppilaat = "nimi: " + nimi + " id " + id + " pisteet " + pisteet.ToString();
                return oppilaat;

            }

        
    }
}
