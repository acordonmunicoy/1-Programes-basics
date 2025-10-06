namespace exercici10;

/* Declara dues variables: una per al nom i una altra per l’any de naixement. 
Combina-les per crear una contrasenya bàsica (per exemple, Pere i 1982 -> Pere1982). 
Imprimeix la contrasenya generada (i sobretot no la facis servir mai que és molt dolenta) */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Com et dius?");
        var nom = Console.ReadLine();

        Console.WriteLine("Quin any vas neixre?");
        var any = Console.ReadLine();

        Console.WriteLine($"La teva contrasenya serà : {nom}{any}");
    }
}
