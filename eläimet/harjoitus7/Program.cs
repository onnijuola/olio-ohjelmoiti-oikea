using harjoitus7;

internal class Program
{
    private static void Main(string[] args)
    {
        hissi hissiolio = new hissi();
        Console.WriteLine("mihin kerrokseen haluat mennä? ");
        Console.WriteLine(hissiolio.Kerros(7));
        Console.WriteLine("hissin nopeus on " + hissiolio.Nopeus.ToString());
    }
}