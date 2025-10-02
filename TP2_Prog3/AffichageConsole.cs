using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Prog3
{
    internal class AffichageConsole
    {
        public static void Afficher(Parc parc, Map map, GestionVisiteur visiteurs)
        {
            for (int i = 0; i < map.GetHeigt(); i++)
            {
                if (map.map[i] == "")
                {
                    map.map.Add("-----   ");
                }
                else
                {
                    
                }
            }
        }
    }
}
