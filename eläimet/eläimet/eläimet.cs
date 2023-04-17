using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eläimet
{
    internal class eläimet
    {
        public string eläin { get; set; }
        public static int instansi = 0;


        public override string ToString()
        {
            return eläin + " olen";
        }
        public eläimet(string _eläin, int _instansi)
        {
            eläin = _eläin;
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
