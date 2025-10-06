namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Carrer:");
        var carrer = Console.ReadLine();
        Console.WriteLine("Numero:");
        var Numero = Console.ReadLine();
        Console.WriteLine("CodiPostal:");
        var CodiPostal = Console.ReadLine();
        Console.WriteLine("Població:");
        var Poblacio = Console.ReadLine();

        Console.WriteLine($"{carrer}, {Numero}, {CodiPostal}, {Poblacio}");
    }
}
