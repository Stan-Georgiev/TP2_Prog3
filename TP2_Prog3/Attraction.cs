// <copyright file="Attraction.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TP2_Prog3
{
    /// <summary>
    /// Représente une attraction dans le parc avec un identifiant, un type, un nom et une capacité.
    /// </summary>
    public class Attraction
    {
        /// <summary>
        /// Liste des visiteurs actuellement en file d’attente pour cette attraction.
        /// </summary>
        ///
        public List<Visiteur> VisiteursEnligne = new List<Visiteur>();
        private string id;
        private string name;
        private int capacity;

        /// <summary>
        /// Initializes a new instance of the <see cref="Attraction"/> class.
        /// Initialise une nouvelle instance de la classe <see cref="Attraction"/>.
        /// </summary>
        /// <param name="id">Identifiant unique de l’attraction.</param>
        /// <param name="type">Type de l’attraction.</param>
        /// <param name="name">Nom de l’attraction.</param>
        /// <param name="capacity">Capacité maximale de l’attraction.</param>
        public Attraction(string id, TypeAttraction type, string name, int capacity)
        {
            this.id = id;
            this.name = name;
            this.capacity = capacity;
            this.Type = type;
        }

        /// <summary>
        /// Définit les différents types d’attractions disponibles.
        /// </summary>
        public enum TypeAttraction
        {
            /// <summary>
            /// Sensation forte (S).
            /// </summary>
            S = 0,

            /// <summary>
            /// Intermédiaire (I).
            /// </summary>
            I = 1,

            /// <summary>
            ///  Famille (F).
            /// </summary>
            F = 2,

            /// <summary>
            /// Toilette (T).
            /// </summary>
            T = 3,

            /// <summary>
            /// Magasin (M).
            /// </summary>
            M = 4,

            /// <summary>
            ///  Restaurant (R).
            /// </summary>
            R = 5,
        }

        /// <summary>
        /// Gets obtient le type de cette attraction.
        /// </summary>
        private TypeAttraction Type { get; }

        /// <summary>
        /// Retourne l’identifiant unique de l’attraction.
        /// </summary>
        /// <returns>L’identifiant de l’attraction.</returns>
        public string GetId()
        {
            return this.id;
        }

        /// <summary>
        /// Retourne le nom de l’attraction.
        /// </summary>
        /// <returns>Le nom de l’attraction.</returns>
        public string GetName()
        {
            return this.name;
        }

        /// <summary>
        /// Retourne la capacité maximale de l’attraction.
        /// </summary>
        /// <returns>La capacité de l’attraction.</returns>
        public int GetCapacity()
        {
            return this.capacity;
        }

        /// <summary>
        /// Retourne le type de l’attraction.
        /// </summary>
        /// <returns>Le type de l’attraction (<see cref="TypeAttraction"/>).</returns>
        public TypeAttraction GetTypeAttraction()
        {
            return this.Type;
        }
    }
}
