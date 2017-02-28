using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_6_Bis_Labyrinthe
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            *******************************
            **d ****    * ***   ***  *   **
            ***  **** * * *    *   *   ****
            **** **   * * * **   *   *   **
            **   ** **    *   ****** *** a*
            ** **   *** ***** ***   *   ***
            *  *  * *****     **  * * * * *
            * *   * **    *****  ** * * * *
            *   ***    **       **    *   *
            *******************************
            */

            string[] schema1 = { "*******************************", "**d ****    * ***   ***  *   **", "***  **** * * *    *   *   ****", "**** **   * * * **   *   *   **", "**   ** **    *   ****** *** a*", "** **   *** ***** ***   *   ***", "*  *  * *****     **  * * * * *", "* *   * **    *****  ** * * * *", "*   ***    **       **    *   *", "*******************************" };
            Labyrinthe lab = new Labyrinthe(schema1, 10, 31);
            Personnage character = new Personnage(lab);
            Console.WriteLine("Bienvenue au jeu du labyrinthe. Vous vous déplacez avec les touches Z(haut) , Q(gauche), S(bas), D(droite), faites attention car on ne peut pas revenir sur ses pas, si vous vous trompez de direction, vous n'arriverez jamais à la sortie 3:) ... (Il vous faudra donc relancer le programme pour réessayer) ");
            Console.WriteLine();          
            while (character.IsArrived() == false) 
            {
                Console.WriteLine();
                Console.WriteLine(lab);
                Console.WriteLine();
                try { character.NextMove(Console.ReadLine()); }                                  
                catch (IndexOutOfRangeException) { }        // J'avais dans un premier temps un problème car le personnage passait au travers des murs, j'ai donc utilisé le try/catch pour que le programme ne crash pas lorsqu'on sort des limites de la matrice. Mais ce n'est plus utile maintenant que tout fonctionne correctement.
            }
            Console.WriteLine();
            Console.WriteLine("Oh, je vois que vous avez trouvé la sortie ! Ca n'arrivera pas la prochaine fois 3:) ");
            Console.ReadLine();


        }
    }
}
