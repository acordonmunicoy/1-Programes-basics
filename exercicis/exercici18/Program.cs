namespace exercici18;

/* Un rellotger està perdent la memòria i necessita un programa que a partir de l'hora actual li puguem dir
 quina hora serà d’aquí un nombre determinat d’hores.

Hora actual: 9
Hores a incrementar: 3
D'aquí a 3 hores seran les 12


Hora actual: 11
Hores a incrementar: 3
D'aquí a 3 hores seran les 2
*/ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quina hora és ara?");
        var horaactual = Console.ReadLine();
        int horaactual1 = Convert.ToInt32(horaactual);
        Console.WriteLine("Quantes hores vols afegir?");
        var horaextre = Console.ReadLine();
        int horaextre1 = Convert.ToInt32(horaextre);

        if ((horaactual1 + horaextre1) > 12)
        Console.WriteLine("la hora és: " + ((horaactual1 + horaextre1)-12));
        else
        Console.WriteLine("la hora és: " + (horaactual1 + horaextre1));
    }
}
