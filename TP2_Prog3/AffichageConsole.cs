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
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < map.GetHeigt(); i++)
            {
                if (map.map[i] == "")
                {
                    builder.Append("-----   ");
                }
                else
                {
                    builder.Append(map.map[i]);
                }
            }
           
            Console.WriteLine($"{visiteurs.GetNbVisiteur()}visiteurs(s) présent(s) dans le parc.");
        }

        public static void AfficherHistoriqueVisiteur(Visiteur visiteur)
        {

        }

    }
}
