namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Com et dius?");
        var Nom = Console.ReadLine();
        Console.WriteLine("En quin any vas neixer?");
        var Any = Console.ReadLine();
        int Anyint = Convert.ToInt32(Any);
        int RestaAny = 2025 - Anyint;


        Console.WriteLine($"Hola {Nom}! Ja tens {RestaAny} anys?"); 
    }
}
