using harjoitus_11;

internal class Program
{
    private static void Main(string[] args)
    {



        Dictionary<string, Opiskelija> opiskelijat = new Dictionary<string, Opiskelija>();

        while (true)
        {
            Console.Write("Komento (lisää/poista/tulosta/poistu): ");
            string komento = Console.ReadLine();

            if (komento == "lisää")
            {
                Console.Write("Etunimi: ");
                string etunimi = Console.ReadLine();

                Console.Write("Sukunimi: ");
                string sukunimi = Console.ReadLine();

                Console.Write("Ryhmätunnus: ");
                string ryhmätunnus = Console.ReadLine();

                Console.Write("OpiskelijaID: ");
                string opiskelijaID = Console.ReadLine();

                try
                {
                    Opiskelija opiskelija = new Opiskelija(etunimi, sukunimi, ryhmätunnus, opiskelijaID);
                    opiskelijat.Add(opiskelijaID, opiskelija);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("OpiskelijaID on jo käytössä!");
                }
            }
            else if (komento == "poista")
            {
                Console.Write("OpiskelijaID: ");
                string opiskelijaID = Console.ReadLine();

                if (opiskelijat.Remove(opiskelijaID))
                {
                    Console.WriteLine("Opiskelija poistettu.");
                }
                else
                {
                    Console.WriteLine("Opiskelijaa ei löytynyt.");
                }
            }
            else if (komento == "tulosta")
            {
                foreach (Opiskelija opiskelija in opiskelijat.Values)
                {
                    Console.WriteLine("{0} {1} ({2}), ID: {3}", opiskelija.Etunimi, opiskelija.Sukunimi, opiskelija.Ryhmätunnus, opiskelija.OpiskelijaID);
                }
            }
            else if (komento == "poistu")
            {
                break;
            }
            else
            {
                Console.WriteLine("Tuntematon komento!");
            }
        }

        Console.WriteLine("Ohjelma sulkeutuu.");
    }



}
