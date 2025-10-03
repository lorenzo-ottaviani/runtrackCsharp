/* Auteur : Lorenzo OTTAVIANI.
 * Date : 02/10/2025 17h15
 * But de l'exercice :
 *    Créer un tableau contenant les 10 chiffres dans l'ordre croissant.
 * Entrée : ∅
 * Sortie : Affichage de certains des nombres du tableau.
 */

using System;

namespace job3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Option 1 : déclaration préalable
            int[] entierBis = new int[10];
            for (int i = 0; i < entierBis.Length; i ++) 
            {
                entierBis[i] = i;
            }

            Console.WriteLine(entierBis[4]);

            // Option 2 : affectation directe des valeurs
            int[] entier = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            Console.WriteLine(entier[0]);
            Console.WriteLine(entier[1]);
            Console.WriteLine(entier[5]);
            Console.WriteLine(entier[9]);
            
            try
            {
                Console.WriteLine(entier[10]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"{e}\n");
                Console.WriteLine(e.Message);
                Console.WriteLine("Erreur : index hors limites !");
            }
        }
    }
}
