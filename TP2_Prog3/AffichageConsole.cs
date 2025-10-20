namespace TP2_Prog3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Classe utilitaire responsable de l’affichage du parc et des visiteurs dans la console.
    /// </summary>
    internal static class AffichageConsole
    {
        public static void Afficher(Parc parc, Map map, GestionVisiteur gestionVisiteurs)
        {
            LinkedList<Attraction> attractions = parc.GetAttractions();
            Console.Clear();

            // --- Affichage de la carte ---
            for (int i = 0; i < map.Height; i++)
            {
                for (int j = 0; j < map.Width; j++)
                {
                    string cell = map.Maps[i, j];

                    if (cell == "-----")
                    {
                        Console.ResetColor();
                        Console.Write("-----   ");
                    }
                    else
                    {
                        Attraction? attraction = attractions.FirstOrDefault(a => a.GetId() == cell);

                        if (attraction != null)
                        {
                            double fillPercentage = (double)attraction.VisiteursEnligne.Count / attraction.GetCapacity() * 100;

                            if (fillPercentage >= 100)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                            }
                            else if (fillPercentage >= 75)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }

                            Console.Write($"{cell,-6} ");
                        }
                        else
                        {
                            // ID inconnu (pas dans la liste d’attractions)
                            Console.ResetColor();
                            Console.Write($"{cell,-6} ");
                        }
                    }
                }

                Console.WriteLine();
            }

            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine($"{gestionVisiteurs.GetNbVisiteur(gestionVisiteurs)} visiteur(s) présent(s) dans le parc.\n");

            // --- Détails des attractions ---
            foreach (Attraction attraction in parc.GetAttractions())
            {
                double fillPercentage = (double)attraction.VisiteursEnligne.Count / attraction.GetCapacity() * 100;

                if (fillPercentage >= 100)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                else if (fillPercentage >= 75)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                const string Circle = "●";
                Console.Write(Circle);
                Console.ResetColor();

                Console.WriteLine(
                    $"    {attraction.GetId(),-8}" +
                    $"{attraction.GetName() + " (" + attraction.GetTypeAttraction() + ")",-30}" +
                    $"{attraction.VisiteursEnligne.Count,5} / {attraction.GetCapacity()}");
            }
        }

        public static void AfficherHistoriqueVisiteur(Visiteur visiteur)
        {
            Console.WriteLine();
            Console.WriteLine($"### {visiteur} ###");

            foreach (string entry in visiteur.GetHistorique())
            {
                Console.WriteLine($"- {entry}");
            }
        }
    }
}
