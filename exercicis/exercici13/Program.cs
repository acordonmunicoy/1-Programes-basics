namespace exercici13;

/* Un alumne ha inventat un sistema per codificar dates que consisteix a eliminar els separadors de les dates 
per fer no es vegi que són dates (la data 24/09/2024 la converteix en 24092024). 
El problema és que ho ha aplicat a tots els documents de l’institut i ara la direcció no sap 
ordenar els documents.

Necessitem un programa que faci el procés invers

Entra la data sense formatar: 25092024
La data és 25/09/2024

Entra la data sense formatar: 12031970
La data és 12/03/1970 */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quina data sense format vols convertir?");
        var Data = Console.ReadLine();

        string DataString = (Data);
        Console.WriteLine(DataString.Substring(0, 2) + "/" + DataString.Substring(2, 2) + "/" + DataString.Substring(4, 4));
    }
        //Console.WriteLine(Data.Length);
        //Console.WriteLine(DataString[0] + DataString[1] + "/" + DataString[2] + DataString[3] + "/" + DataString[4] + DataString[5] + DataString[6] + DataString[7]);
        // data.Length
        // Console.WriteLine(paraula.Length);
        //Console.WriteLine($"numero de lletres" + [Data.Length]);  + DataString[7] + DataString[8]
    
}
