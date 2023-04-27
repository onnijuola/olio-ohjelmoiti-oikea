using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_11
{
    internal class Opiskelija
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Ryhmätunnus { get; set; }
        public string OpiskelijaID { get; set; }

        public Opiskelija(string etunimi, string sukunimi, string ryhmätunnus, string opiskelijaID)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Ryhmätunnus = ryhmätunnus;
            OpiskelijaID = opiskelijaID;
        }
    }
}

