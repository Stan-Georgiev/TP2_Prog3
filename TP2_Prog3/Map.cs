// <copyright file="Map.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace TP2_Prog3
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using TP2_Prog3.Util;

    /// <summary>
    /// Représente la carte du parc, importée depuis un fichier texte.
    /// La carte contient les lignes et colonnes définissant la disposition du parc.
    /// </summary>
    public class Map
    {
        /// <summary>
        /// Lignes de la carte générée et utilisées dans le programme.
        /// </summary>
        public readonly List<List<string>> MapLines = new List<List<string>>();

        /// <summary>
        /// Chemin du fichier texte contenant la carte.
        /// </summary>
        private static readonly string TxtPath = Path.Combine(Environment.CurrentDirectory, "map.txt");

        /// <summary>
        /// Carte importée depuis le fichier texte.
        /// Chaque ligne est représentée par une liste de chaînes.
        /// </summary>
        private static readonly List<List<string>> ImportedMap = FileReader.ReadFile(TxtPath, out width, out height);

        /// <summary>
        /// Hauteur de la carte (nombre de lignes).
        /// </summary>
        private static int height;

        /// <summary>
        /// Largeur de la carte (nombre de colonnes).
        /// </summary>
        private static int width;

        /// <summary>
        /// Initializes a new instance of the <see cref="Map"/> class.
        /// Génère la carte à partir du fichier importé.
        /// </summary>
        public Map()
        {
            this.GenerateMap();
        }

        /// <summary>
        /// Gets la hauteur de la carte.
        /// </summary>
        public int Height => height;

        /// <summary>
        /// Gets la largeur de la carte.
        /// </summary>
        public int Width => width;

        /// <summary>
        /// Génère la carte en copiant les lignes importées dans <see cref="MapLines"/>.
        /// </summary>
        private void GenerateMap()
        {
            foreach (var line in ImportedMap)
            {
                this.MapLines.Add(line);
            }
        }
    }
}
