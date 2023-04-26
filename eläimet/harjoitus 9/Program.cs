using harjoitus_9;

internal class Program
{
  
  




    private static void Main(string[] args)
    {
        radio radioolio = new radio();
        radio.aktivointi();
        radio.ääni();
        Console.WriteLine("valitse taajuus.ehdotan taajuudet 100.00 ja 89.0");
        radio.taajuus();
        
       
    }
}