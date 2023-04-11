using harjoitus3;

internal class Program
{
    private static void Main(string[] args)
    {
        kiuas kiuasolio = new kiuas("boch", "tvt");
        Console.WriteLine(kiuasolio.haetiedot());
        
        Console.WriteLine("Haluatko laittaa saunan päälle? Kirjoita kyllä tai ei.");
        string kirjain = Console.ReadLine();

        if (kirjain == "ei")
        {
            Console.WriteLine("Sauna ei ole päällä.");
        }
        else if (kirjain == "kyllä")
        {
            Console.WriteLine("Laitoit saunan päälle.");
        }
        else
        {
            Console.WriteLine("En ymmärtänyt vastaustasi.");
        }
    }
}