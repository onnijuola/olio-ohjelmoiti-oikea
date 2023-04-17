using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus6
{
    internal class eläimet
    {
        public string eläin { get; set; }
        public string eläin2 { get; set; }
        public static int instansi = 0;


        public override string ToString()
        {
            return eläin + " olen";
        }
        public eläimet(string _eläin, string _eläin2, int _instansi)
        {
            eläin = _eläin;
            eläin2 = _eläin2;
            instansi = _instansi;

        }
        public eläimet()
        {
            instansi++;
        }


        public static void kuinkamonta()
        {
            Console.WriteLine("eläimiä on " + instansi);
        }

    }
}
