using harjoitus8;

internal class Program
{
    private static void Main(string[] args)
    {
        Tyontekija t = new Tyontekija("Matti", "Firma Oy", 3000, 37.5);
        pomo p = new pomo("Mikko", "Firma Oy", 5000,1000, "BMW");

        Console.WriteLine("Työntekijä:");
        Console.WriteLine("Nimi: " + t.Nimi);
        Console.WriteLine("Työpaikka: " + t.Tyopaikka);
        Console.WriteLine("Palkka: " + t.Palkka);
        Console.WriteLine("Viikkotunnit: " + t.Viikkotunnit);

        Console.WriteLine();

        
    }
}