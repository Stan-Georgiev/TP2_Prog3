// <copyright file="Parc.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace TP2_Prog3
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Représente un parc contenant un ensemble d’attractions.
    /// </summary>
    public class Parc
    {
        /// <summary>
        /// Ensemble des attractions présentes dans le parc.
        /// Utilisation d’un <see cref="HashSet{T}"/> afin d’éviter les doublons.
        /// </summary>
        private readonly HashSet<Attraction> attractions = new HashSet<Attraction>();

        /// <summary>
        /// Ajoute une attraction au parc.
        /// </summary>
        /// <param name="attraction">L’attraction est ajouté.</param>
        public void AjouterAttraction(Attraction attraction)
        {
            this.attractions.Add(attraction);
        }

        /// <summary>
        /// Retourne l’ensemble des attractions présentes dans le parc.
        /// </summary>
        /// <returns>Un <see cref="HashSet{Attraction}"/> contenant toutes les attractions.</returns>
        public HashSet<Attraction> GetAttractions()
        {
            return this.attractions;
        }
    }
}