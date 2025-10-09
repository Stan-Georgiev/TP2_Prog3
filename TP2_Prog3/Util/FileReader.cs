// <copyright file="FileReader.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TP2_Prog3.Util
{
    /// <summary>
    /// Classe utilitaire permettant de lire un fichier texte et de construire une grille
    /// représentant la carte du parc.
    /// </summary>
    public static class FileReader
    {
        /// <summary>
        /// Lit un fichier texte et retourne une grille de chaînes représentant la carte.
        /// La première ligne du fichier doit contenir la largeur et la hauteur séparées par un point-virgule.
        /// </summary>
        /// <param name="filePath">Chemin du fichier à lire.</param>
        /// <param name="width">Largeur de la carte (valeur de sortie).</param>
        /// <param name="height">Hauteur de la carte (valeur de sortie).</param>
        /// <returns>
        /// Une liste de listes de chaînes représentant les lignes de la carte.
        /// Retourne une liste vide si le fichier est introuvable ou en cas d’erreur.
        /// </returns>
        public static List<List<string>> ReadFile(string filePath, out int width, out int height)
        {
            var grid = new List<List<string>>();
            width = 0;
            height = 0;

            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"Erreur : le fichier '{filePath}' est introuvable.");
                    return grid;
                }

                var text = File.ReadAllLines(filePath);

                for (int i = 0; i < text.Length; i++)
                {
                    if (i == 0)
                    {
                        string[] parts = text[i].Split(';', StringSplitOptions.RemoveEmptyEntries);

                        if (parts.Length >= 2 &&
                            int.TryParse(parts[0], out int w) &&
                            int.TryParse(parts[1], out int h))
                        {
                            width = w;
                            height = h;
                        }
                        else
                        {
                            Console.WriteLine("Erreur : la première ligne doit contenir largeur;hauteur");
                        }

                        continue;
                    }

                    var row = text[i]
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .ToList();

                    grid.Add(row);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur est survenue lors de la lecture du fichier : {ex.Message}");
            }

            return grid;
        }
    }
}
