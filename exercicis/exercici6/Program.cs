namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cuant medeix un costat del quadrat?");
        var costat = Console.ReadLine();
        int costatint = Convert.ToInt32(costat);

        int perimetre =  costatint * 4 ;
        
        Console.WriteLine($"El perimetre del quadrat es {perimetre}");
    }
}
