namespace exercici9;

/* Demana un valor en metres. Converteix el valor a peus (1 metre = 3,28084 metres) 
i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quin valor en metres vols convertir?");
        var metres = Console.ReadLine();
        int metresint = Convert.ToInt32(metres);

        Console.WriteLine($" {metres} en peus son {metresint * 3.28084} ");
    }
}
