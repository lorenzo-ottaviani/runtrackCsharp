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
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans notre programme !");
            string message = Console.ReadLine();
            Console.WriteLine("Entrez votre message : " + message);
            
        }
    }
}