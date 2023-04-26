using harjoitus_10;

internal class Program
{
    private static void Main(string[] args)
    {
        varis varisolio = new varis("varis", 90);
        varisolio.teeääni();
        varisolio.fly();

        ahven ahvenolio = new ahven("ahven", 50, "blub");
        ahvenolio.teeääni();
        ahvenolio.swim();
    }
}