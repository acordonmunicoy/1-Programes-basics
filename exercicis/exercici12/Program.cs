namespace exercici12;

/* Fes un programa que a partir de dos números imprimeixi per pantalla la seva suma, la seva resta, 
la seva multiplicació i la seva divisió

Entra el primer número: 3
Entra el segon número: 4

4 + 3 = 7
4 - 3 = 1
4 * 5 = 12
4 / 3 = 1  i en sobra 1


Entra el primer número: 25
Entra el segon número: 5

25 + 5 = 30
25 - 5 = 20
25 * 5 = 125
25 / 5 = 5  i en sobra 0
*/



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digam el primer numero");
        var primer = Console.ReadLine();
        int primerint = Convert.ToInt32(primer);

        Console.WriteLine("Digam el segon numero");
        var segon = Console.ReadLine();
        int segonint = Convert.ToInt32(segon);

        Console.WriteLine($"Primer número {primerint}");
        Console.WriteLine($"Segon número {segonint}");
        Console.WriteLine($"La suma de {primer} i {segon} es {primerint + segonint}");
        Console.WriteLine($"La resta de {primer} i {segon} es {primerint - segonint}");
        Console.WriteLine($"La multiplicacio de {primer} i {segon} es {primerint * segonint}");
        Console.WriteLine($"La divisio de {primer} i {segon} es {primerint / segonint}");

    }
}
