using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_9
{
    internal class radio
    {
        
    
        public static void taajuus()
        {
            float numero;
            numero = Convert.ToInt32(Console.ReadLine());   
            for(int i = 0; i < 1; i++)
            {

                if(numero == 100.00)
                {
                    Console.WriteLine(" valisit uutis kanavan");
                }
                else if(numero ==  89.0)
                {
                    Console.WriteLine("valitsit musiikki kanavan");
                }
                else if (numero < 107.9)
                {
                    Console.WriteLine("tässä kanavassa on mainos tauko");
                }
                else if (numero>107.9)
                {
                    Console.WriteLine("kanava ei ole käytössä");
                }
                else if (numero > 88.0)
                {
                    Console.WriteLine("tässä kanavassa on mainos tauko");
                }
                else if (numero < 88.0)
                {
                    Console.WriteLine("kanava ei ole käytössä");
                }
                else
                {
                    Console.WriteLine("en ymmärtänyt");
                    break;
                }







            }


        }

        public static void ääni()
        {
            int voimakkuus;
            Console.WriteLine("valitse ääni 0 ja 9 väliltä.");
            voimakkuus = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 1; i++)
            {
                if (voimakkuus < 9) 
                {
                    Console.WriteLine("laitoit " + voimakkuus);

                }
                else if (voimakkuus > 9)
                {
                    Console.WriteLine("radio ei pysty laittaa ääntä " + voimakkuus);
                    break;
                }



            }
        }


        public static void aktivointi()
        {
            string päälle;
            //string pois = "ei";
            Console.WriteLine("haluatko radion pääll. vastaa kyllä tai ei ");
            päälle = Console.ReadLine();
            for(int i = 0; i < 1; i++)
            {
                if (päälle == "kyllä")
                {
                    Console.WriteLine("laitoit radion päälle");
                }
                else if (päälle == "ei")
                {
                    Console.WriteLine("et laittanut radiota päälle");
                    break;
                }
            }
        }
        


    }
}
