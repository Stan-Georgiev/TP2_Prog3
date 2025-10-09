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
            HashSet<Attraction> attractions = parc.GetAttractions();
            Console.Clear();

            for (int i = 0; i < map.MapLines.Count; i++)
            {
                for (int j = 0; j < map.MapLines[i].Count; j++)
                {
                    string cell = map.MapLines[i][j].ToString();
                    Attraction attraction = attractions.FirstOrDefault(a => a.GetId().ToString() == cell);

                    if (attraction != null)
                    {
                        double fillPercentage = (double)attraction.VisiteursEnligne.Count / attraction.GetCapacity() * 100;

                        if (fillPercentage >= 100)
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                        else if (fillPercentage >= 75)
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        else
                            Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ResetColor();
                    }

                    Console.Write(cell + "   ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine($"{visiteurs.GetNbVisiteur(visiteurs)} visiteur(s) présent(s) dans le parc.");
            Console.WriteLine();

            foreach (Attraction attraction in parc.GetAttractions())
            {
                double fillPercentage = (double)attraction.VisiteursEnligne.Count / attraction.GetCapacity() * 100;

                
                if (fillPercentage >= 100)
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                else if (fillPercentage >= 75)
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                else
                    Console.ForegroundColor = ConsoleColor.Green;

               
                string circle = "●";

              
                Console.Write(circle);
                Console.ResetColor();
                
                Console.WriteLine(
                    $"    {attraction.GetId(),-8}{(attraction.GetName() + " (" + attraction.GetTypeAttraction() + ")"),-30}{attraction.VisiteursEnligne.Count,5} / {attraction.GetCapacity()}"


                );
            }

        }

          
           

        public static void AfficherHistoriqueVisiteur(Visiteur visiteur)
        {
            Console.WriteLine($"### {visiteur} ###");
            foreach (string entry in visiteur.GetHistorique())
            {
                Console.WriteLine($"- {entry}");
            }
        }

    }
}
