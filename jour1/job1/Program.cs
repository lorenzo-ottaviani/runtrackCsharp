/*
 * Auteur : Lorenzo OTTAVIANI.
 * Date : 30/09/2025 9h49
 * But de l'exercice :
 *    Afficher un message entré par l'utilisateur.
 * Entrée : Le message.
 * Sortie : Affichage du message.
 */

using System;

namespace job1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans notre programme !");
            Console.Write("Entrez votre message : ");

            string? message = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(message))
            {
                Console.WriteLine("Votre message est : " + message);
            }
            else
            {
                Console.WriteLine("Aucun message saisi.");
            }
            
        }
    }
}
