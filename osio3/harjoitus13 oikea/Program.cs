using harjoitus13_oikea;

internal class Program
{
    private static void Main(string[] args)
    {


        Joukkue hifk = new Joukkue("HIFK", "Helsinki");

        Pelaaja pelaaja1 = new Pelaaja() { Etunimi = "Juuso", Sukunimi = "Puustinen", PelaajaNumero = 9 };
        Pelaaja pelaaja2 = new Pelaaja() { Etunimi = "Antti", Sukunimi = "Suomela", PelaajaNumero = 20 };
        Pelaaja pelaaja3 = new Pelaaja() { Etunimi = "Niklas", Sukunimi = "Bäckström", PelaajaNumero = 30 };

        hifk.LisaaPelaaja(pelaaja1);
        hifk.LisaaPelaaja(pelaaja2);
        hifk.LisaaPelaaja(pelaaja3);

        Console.WriteLine("HIFK:n pelaajat:");
        List<Pelaaja> pelaajat = hifk.HaePelaajat();
        foreach (Pelaaja pelaaja in pelaajat)
        {
            Console.WriteLine(pelaaja.Etunimi + " " + pelaaja.Sukunimi + " #" + pelaaja.PelaajaNumero);
        }

        Console.WriteLine();

        Pelaaja haettuPelaaja = hifk.HaePelaaja(20);
        if (haettuPelaaja != null)
        {
            Console.WriteLine("HIFK:n pelaaja #" + haettuPelaaja.PelaajaNumero + ": " + haettuPelaaja.Etunimi + " " + haettuPelaaja.Sukunimi);
        }

        Console.WriteLine();

        hifk.PoistaPelaaja(20);

        Console.WriteLine("HIFK:n pelaajat:");
        pelaajat = hifk.HaePelaajat();
        foreach (Pelaaja pelaaja in pelaajat)
        {
            Console.WriteLine(pelaaja.Etunimi + " " + pelaaja.Sukunimi + " #" + pelaaja.PelaajaNumero);
        }

        Console.ReadLine();
    }

}
