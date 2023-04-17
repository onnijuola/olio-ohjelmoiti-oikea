using harjoitus6;

internal class Program
{
    private static void Main(string[] args)
    {
        

        eläimet eläinolio = new eläimet();
        eläimet.kuinkamonta();
        eläinolio.eläin = "koira";
        Console.WriteLine(eläinolio.ToString());

        eläinolio.eläin2 = "mäyrä";
        Console.WriteLine(eläinolio.ToString());

    }
}