namespace exercici20;

/* Ens cal un programa que quan li entrem un número de tres xifres i ens retorni 
el número amb els dígits invertits. 

Ex. 245 -> 542
Entra el número a invertir: 347
El número invertit és: 743
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quin numero vols, de tres xifres, invertir?");
        var numero = Console.ReadLine();
        string numero1 = numero.Substring(0, 1);
        string numero2 = numero.Substring(1,1);
        string numero3 = numero.Substring(2);
        Console.WriteLine("El numero invertit és "+(numero3)+ (numero2) +(numero1));
    }
}
