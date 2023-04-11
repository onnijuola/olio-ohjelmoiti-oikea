using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus5
{
    internal class laskin
    {
        public static float Summa(float a, float b)
        {
            return a + b;
        }

        public static float Erotus(float a, float b)
        {
            return a - b;
        }

        public static float Kertolasku(float a, float b)
        {
            return a * b;
        }

        public static float Jako(float a, float b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Jakaja ei voi olla nolla.");
            }

            return a / b;
        }
    }
}
