// <copyright file="AffichageConsole.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

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
        /// <summary>
        /// Affiche la carte du parc, les attractions et le nombre de visiteurs présents.
        /// Les attractions sont colorées en fonction de leur taux de remplissage :
        /// - Rouge foncé : complet
        /// - Jaune foncé : plus de 75 % de remplissage
        /// - Vert : disponible.
        /// </summary>
        /// <param name="parc">Le parc contenant les attractions.</param>
        /// <param name="map">La carte du parc.</param>
        /// <param name="visiteurs">Gestionnaire des visiteurs.</param>
        public static void Afficher(Parc parc, Map map, GestionVisiteur visiteurs)
        {
            HashSet<Attraction> attractions = parc.GetAttractions();
            Console.Clear();

            foreach (var t in map.MapLines)
            {
                foreach (var cell in t)
                {
                    Attraction? attraction = attractions.FirstOrDefault(a => a.GetId().ToString() == cell);

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

        /// <summary>
        /// Affiche l’historique des actions d’un visiteur dans la console.
        /// </summary>
        /// <param name="visiteur">Le visiteur dont on veut afficher l’historique.</param>
        public static void AfficherHistoriqueVisiteur(Visiteur visiteur)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"### {visiteur} ###");

            foreach (string entry in visiteur.GetHistorique())
            {
                Console.WriteLine($"- {entry}");
            }
        }
    }
}
