// <copyright file="Map.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace TP2_Prog3
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq.Expressions;
    using System.Runtime.InteropServices;
    using TP2_Prog3.Util;

    /// <summary>
    /// Représente la carte du parc, importée depuis un fichier texte.
    /// La carte contient les lignes et colonnes définissant la disposition du parc.
    /// </summary>
    public class Map
    {
        /// <summary>
        /// Lignes de la carte générée et utilisées dans le programme.
        /// Must be matrice.
        /// </summary>
        public int[,] Maps = new int[20,20];

        private string[] MapLines = new string[20];
        /// <summary>
        /// Chemin du fichier texte contenant la carte.
        /// </summary>
        private string destinationFilePath;
        private string sourceFilePath;
        private string fileName;

        /// <summary>
        /// Carte importée depuis le fichier texte.
        /// Chaque ligne est représentée par une liste de chaînes.
        /// </summary>
 

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


        public string[] lines = new string[20]; 


        string[] map = new string[20];
        /// <summary>
        /// Génère la carte en copiant les lignes importées dans <see cref="MapLines"/>.
        /// </summary>
        private void GenerateMap()
        {
            MapLines = lines.Skip(1).ToArray();
            for (int i = 0;  i <= MapLines.Length; i++)
            {
                if (map[i] == "-----")
                {
                    MapLines[i].Split();
                }
                else
                {
                    
                    MapLines[i].Trim();
                }
            }
        }

        public void CopyToDirectory(string destinationDirectoryPath)
        {
            sourceFilePath = "../../../map.txt";

            string fileName = Path.GetFileName(sourceFilePath);

            string destinationFilePath = Path.Combine(destinationDirectoryPath, fileName);

            File.Copy(sourceFilePath, destinationFilePath, true);
        }
    }
}
