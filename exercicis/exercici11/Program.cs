namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Com et dius?");
        var nom = Console.ReadLine();

        var domini = "cendrassos.net";

        Console.WriteLine($"{nom}@{domini}");
    }
}
