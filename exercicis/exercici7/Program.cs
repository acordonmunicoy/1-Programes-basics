namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Primera nota: ");
        var nota1 = Console.ReadLine();
        int nota1int = Convert.ToInt32(nota1);
        Console.WriteLine("Segona nota: ");
        var nota2 = Console.ReadLine();
        int nota2int = Convert.ToInt32(nota2);
        Console.WriteLine("Tercera nota: ");
        var nota3 = Console.ReadLine();
        int nota3int = Convert.ToInt32(nota3);

        int mitjana = (nota1int + nota2int + nota3int) / 3;
        
        Console.WriteLine($"La mitjana del alumnes es {mitjana}");
    }
}
