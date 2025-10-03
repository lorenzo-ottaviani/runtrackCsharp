/*
 * Auteur : Lorenzo OTTAVIANI.
 * Date : 29/09/2025 23h35
 * But de l'exercice :
 *    Déclarer et afficher des variables de chaque type primitif.
 * Entrée : ∅
 * Sortie : Affichage des variables.
 */

using System; // Inutile, importé automatiquement en .NET 8.0

namespace job0;

class Program
{
    static void Main(string[] args)
    {
        char lettre = 'a';
        Console.WriteLine(lettre);
        
        string mot = "pomme";
        Console.WriteLine(mot);
        
        int petit = 15;
        Console.WriteLine(petit);
        
        long grand = 2000;
        Console.WriteLine(grand);
        
        float oligo = 8.25f;
        Console.WriteLine(oligo);
        
        double multi = 8.25;
        Console.WriteLine(multi);
        
        bool test = false;
        Console.WriteLine(test);
        
        Console.Write("Test de l'int TOTO 12,25 : ");
        // int TOTO = 12.25;
        // Console.WriteLine(TOTO);
        Console.Write("Non autorisé !!");
    }
}
