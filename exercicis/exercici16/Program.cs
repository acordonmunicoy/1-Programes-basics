namespace exercici16;

/* Ningú entén res del nou sistema d’avaluació. Necessitem un programa que calculi la part que és més senzilla: 
a partir de la mitjana de les notes les pràctiques i la nota de l’examen ens calculi la nota final

Nota de pràctiques: 8
Nota de l’examen: 9
La nota final és 8.7 o sigui un 8

Nota de pràctiques: 10
Nota de l’examen: 5
La nota final és 6.5 o sigui un 7 
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quina nota de practiques has tret?");
        var notespractiques = Console.ReadLine();
        int notapt = Convert.ToInt32(notespractiques);
        Console.WriteLine("Quina nota has tret a l'examen?");
        var notesexamens = Console.ReadLine();
        int notaexm = Convert.ToInt32(notesexamens);
        double resultat = notapt * 0.3 + notaexm * 0.7;
        double resultatexm = Math.Truncate(resultat);
        Console.WriteLine("La teva nota final és: " + (notapt * 0.3 + notaexm * 0.7) + " o sigui " + resultatexm);
    }
}
