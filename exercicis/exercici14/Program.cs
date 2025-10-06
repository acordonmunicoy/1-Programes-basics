namespace exercici14;

// Declara una paraula i fes que el programa imprimeixi només la primera lletra, l'última lletra i la lletra del mig 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quina paraula vols analitzar?");
        var paraula = Console.ReadLine();

        //string paraulastring = (paraula);
        Console.WriteLine(paraula.Length);

        Console.WriteLine($"La primera lletra és " + paraula[0]);
        Console.WriteLine($"La ultima lletra és " + paraula[paraula.Length -1]);
        Console.WriteLine($"La ultima lletra és " + paraula[paraula.Length / 2]);
    }
}
