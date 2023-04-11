using harjoitus5;

internal class Program
{
    private static void Main(string[] args)
    {
        float a = 10;
        float b = 5;
        
        Console.WriteLine("Summa: " + laskin.Summa(a, b));
        Console.WriteLine("Erotus: " + laskin.Erotus(a, b));
        Console.WriteLine("Kertolasku: " + laskin.Kertolasku(a, b));
        Console.WriteLine("Jako: " + laskin.Jako(a, b));
    }
}