using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus7
{
    internal class hissi
    {
        private readonly int maxnopeus = 100;
        private int nopeus;
        public int Nopeus
        {
            get { return nopeus; }
            set { nopeus = value; }
        }


        public int Kerros(int kerros)
        {
            kerros = Convert.ToInt32(Console.ReadLine());
           
            
                if (kerros >= 1 && kerros <= 7)
                { 
                    Console.WriteLine("hissi on nyt kerroksella " + kerros);
                }
                else
                {
                    Console.WriteLine("error virheellinen ");
                }
            
            return kerros;
        }
    }
}
