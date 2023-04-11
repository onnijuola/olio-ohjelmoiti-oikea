//harjoitus yksi
using harjoitus1;

internal class Program
{
    private static void Main(string[] args)
    {
        auto autoolio = new auto();

        autoolio.nimi = "mazda";
        autoolio.nopeus = 100;
       
        autoolio.renkaat = 4;
        

        autoolio.lisätieto();


        Console.WriteLine(autoolio.haetiedot());
    }
}