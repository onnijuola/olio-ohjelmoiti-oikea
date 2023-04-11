using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus3
{
    internal class kiuas
    {
        public string nimi { get; set; }
        public string id { get; set; }

        public kiuas(string _nimi, string _id)
        {
            nimi = _nimi;
            id = _id;
            
        }






        public void Lämpö(int lämpöt)
        {
            Console.WriteLine("Minkä lämpötilan haluat?");
            lämpöt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lämpötila on nyt " + lämpöt + " astetta.");
        }



        public string haetiedot()
        {
            string oppilaat = "nimi: " + nimi + " id " + id;
            return oppilaat;

        }

    }
}
