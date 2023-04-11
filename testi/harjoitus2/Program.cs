using harjoitus2;

internal class Program
{
    private static void Main(string[] args)
    {
        oppilas oppilasolio = new oppilas("juhani"," tvt ",80);

        


        Console.WriteLine(oppilasolio.haetiedot());
        oppilasolio.muokkaa(5);
    }
}