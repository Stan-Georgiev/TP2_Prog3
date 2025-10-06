using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Prog3
{
    internal class AffichageConsole
    {
        private static int nbVisiteur = 0;

        public static void Afficher(Parc parc, Map map, GestionVisiteur visiteurs)
        {
            for (int i = 0; i < map.MapLines.Count; i++)
            {
                if (map.MapLines[i].Length > 1 )
                {
                    Console.WriteLine(map.MapLines[i]);
                }
                else
                {
                    Console.WriteLine($"Error: File '{map.MapLines}' is null");
                }
               
                
            }
          
            Console.WriteLine($"{visiteurs.GetNbVisiteur()} visiteurs(s) présent(s) dans le parc.");

            foreach(Attraction i in parc.GetAttractions())
            {
                Console.WriteLine("");
            }
        }

        public static void AfficherHistoriqueVisiteur(Visiteur visiteur)
        {
            Console.WriteLine($"### {visiteur.ToString()} ###");
            foreach(string i in visiteur.GetHistorique())
            {
                Console.WriteLine($"- {i.ToString()}");
            }
        }

    }
}
