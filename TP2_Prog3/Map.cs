// <copyright file="Map.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TP2_Prog3
{
    using System;
    using System.IO;

    /// <summary>
    /// Représente la carte du parc d'attractions importée depuis un fichier texte.
    /// Les données sont stockées dans une matrice de chaînes où chaque cellule contient :
    /// - L'ID d'une attraction (ex : M0001, R0002)
    /// - "-----" pour un emplacement vide.
    /// </summary>
    public class Map
    {
        /// <summary>
        /// Gets matrice de chaînes représentant la carte du parc.
        /// </summary>
        public string[,] Maps { get; private set; }

        /// <summary>
        /// Gets hauteur de la carte (nombre de lignes).
        /// </summary>
        public int Height { get; private set; }

        /// <summary>
        /// Gets largeur de la carte (nombre de colonnes).
        /// </summary>
        public int Width { get; private set; }

        /// <summary>
        /// Chemin du fichier contenant la carte.
        /// </summary>
        private readonly string mapFilePath = "../../../map.txt";

        /// <summary>
        /// Initializes a new instance of the <see cref="Map"/> class.
        /// Initialise une nouvelle instance de la classe <see cref="Map"/>.
        /// </summary>
        public Map()
        {
            this.LoadMap();
        }

        /// <summary>
        /// Charge la carte depuis le fichier texte et la stocke dans la matrice.
        /// </summary>
        private void LoadMap()
        {
            if (!File.Exists(this.mapFilePath))
            {
                throw new FileNotFoundException($"Fichier introuvable : {this.mapFilePath}");
            }

            string[] lines = File.ReadAllLines(this.mapFilePath);

            if (lines.Length == 0)
            {
                throw new InvalidDataException("Le fichier map.txt est vide.");
            }

            // Première ligne : "20;20"
            string[] sizeParts = lines[0].Split(';');
            if (sizeParts.Length != 2 ||
                !int.TryParse(sizeParts[0], out var height) ||
                !int.TryParse(sizeParts[1], out var width))
            {
                throw new InvalidDataException("La première ligne doit être du format 'Hauteur;Largeur'.");
            }

            this.Height = height;
            this.Width = width;
            this.Maps = new string[height, width];

            // Lire le reste des lignes
            for (int i = 0; i < height; i++)
            {
                if (i + 1 >= lines.Length)
                {
                    throw new InvalidDataException($"Le fichier de carte ne contient pas assez de lignes (attendu : {height}).");
                }

                // Chaque ligne contient des valeurs séparées par plusieurs espaces.
                string[] cells = lines[i + 1]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (cells.Length != width)
                {
                    throw new InvalidDataException($"La ligne {i + 2} ne contient pas {width} colonnes (trouvé : {cells.Length}).");
                }

                for (int j = 0; j < width; j++)
                {
                    this.Maps[i, j] = cells[j].Trim();
                }
            }
        }
    }
}
