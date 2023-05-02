using harjoitus12;

internal class Program
{
    private static void Main(string[] args)
    {
        Korttipakka pakka = new Korttipakka();
        Console.WriteLine("Korttipakka ennen sekoitusta:");
        pakka.TulostaKorttipakka();
        Console.WriteLine("Korttipakka sekoituksen jälkeen:");
        pakka.SekoitaKorttipakka();
        pakka.TulostaKorttipakka();
    }
}