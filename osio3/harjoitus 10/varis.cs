using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_10
{
    internal class varis : eläin ,icanfly
    {
        public float wingsize { get; set; }

        public varis(string _nimi, float _wingsize)
        {
            nimi = _nimi;
            wingsize = _wingsize;
        }

        public override void teeääni()
        {
            Console.WriteLine("kaaa kaw ");
        }

        public void fly()
        {
            Console.WriteLine("{0}   lentää    {0} ", nimi,wingsize);
        }
    }

}
