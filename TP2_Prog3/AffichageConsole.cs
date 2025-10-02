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
            
          
            Console.WriteLine($"{visiteurs.GetNbVisiteur()}visiteurs(s) présent(s) dans le parc.");

            foreach(Attraction i in parc.GetAttractions())
            {
                Console.WriteLine("");
            }
        }

        public static void AfficherHistoriqueVisiteur(Visiteur visiteur)
        {
            Console.WriteLine($"### {visiteur} ###");
            foreach(string i in visiteur.GetHistorique())
            {
                Console.WriteLine($"- {i}");
            }
        }

    }
}
