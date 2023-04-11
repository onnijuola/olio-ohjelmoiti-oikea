using harjoitus4;

internal class Program
{
    private static void Main(string[] args)
    {
        kappale kappaleolio = new kappale("Nevermind", "Nirvana", 1991);

        Kappale kappale1 = new Kappale("Smells Like Teen Spirit", "Nirvana", 302);
        Kappale kappale2 = new Kappale("In Bloom", "Nirvana", 254);
        Kappale kappale3 = new Kappale("Come As You Are", "Nirvana", 219);
        Kappale kappale4 = new Kappale("Breed", "Nirvana", 183);
        Kappale kappale5 = new Kappale("Lithium", "Nirvana", 257);

        kappaleolio.LisaaKappale(kappale1);
        kappaleolio.LisaaKappale(kappale2);
        kappaleolio.LisaaKappale(kappale3);
        kappaleolio.LisaaKappale(kappale4);
        kappaleolio.LisaaKappale(kappale5);

        kappaleolio.TulostaAlbumi();

        Console.ReadKey();
    }
}