namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Com es diu el producte?");
        var nomProducte = Console.ReadLine();
        Console.WriteLine("Quin és el preu del producte?");
        var prudproducte = Console.ReadLine();
        Console.WriteLine("Esta en stoc?");
        var stoc = Console.ReadLine();

        Console.WriteLine($"El producte es diu {nomProducte}, el seu preu és de {prudproducte} i {stoc} esta en stoc.");
    }
}
