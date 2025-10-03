/*
 * Auteur : Lorenzo OTTAVIANI.
 * Date : 03/10/2025 17h41
 * But de l'exercice :
 *    Affiche le carré d'un nombre entré par l'utilisateur.
 * Entrée : Un nombre entier.
 * Sortie : Affichage du carré du nombre.
 */

namespace job4;

class Program
{
    static int Carree(int n)
    {
        return n * n;
    }
    
    static void Main(string[] args)
    {
        Console.Write("Choisir un nombre : ");
        string? entree = Console.ReadLine();
        
        if (!string.IsNullOrWhiteSpace(entree))
        {
            try
            { 
                int nombre = int.Parse(entree);
                int res = Carree(nombre);
                Console.WriteLine($"Le carrée de ton nombre est : {res}");
            }
            catch (FormatException e)
            {
             Console.WriteLine("\nNombre invalide !");
             Console.WriteLine(e);
            }
        }
        else
        {
            Console.WriteLine("Tu n'as rien entré !");
        }
    }
}
