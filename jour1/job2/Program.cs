/*
 * Auteur : Lorenzo OTTAVIANI.
 * Date : 02/10/2025 16h45
 * But de l'exercice :
 *    Afficher la phrase "Bonjour {prénom entré par l'utilisateur} ! ".
 * Entrée : Le prénom.
 * Sortie : Affichage de la phrase.
 */

using System;

namespace job2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choisis un prénom : ");
            string? prenom = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(prenom))
            {
                Console.WriteLine($"Bonjour {prenom} !");
            }
            else
            {
                Console.WriteLine("Tu n'as rien entré !");
            }
        }
    }
}
