//eläin esimerkki
using testi;

internal class Program
{
    private static void Main(string[] args)
    {

        koira koiraolio = new koira();

        koiraolio.nimi = "rekku";
        koiraolio.ikä = 4;
        koiraolio.väri = "harmaa";
        koiraolio.paino = 13;
        koiraolio.rotu = "saksan paimen";

        koiraolio.hauku();


        Console.WriteLine(koiraolio.haetiedot());


    }

   
}