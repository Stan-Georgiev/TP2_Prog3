// <copyright file="Visiteur.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace TP2_Prog3
{
    using System.Collections.Generic;

    /// <summary>
    /// Représente un visiteur du parc.
    /// Chaque visiteur possède un nom et un historique de ses actions dans le parc.
    /// </summary>
    public class Visiteur
    {
        /// <summary>
        /// Nom du visiteur.
        /// </summary>
        private readonly string nom;

        /// <summary>
        /// Historique des actions effectuées par le visiteur.
        /// </summary>
        private readonly LinkedList<string> historique = new LinkedList<string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Visiteur"/> class.
        /// </summary>
        /// <param name="nom">Nom du visiteur.</param>
        public Visiteur(string nom)
        {
            this.nom = nom;
        }

        /// <summary>
        /// Ajoute une action à l’historique du visiteur.
        /// </summary>
        /// <param name="action">Description de l’action effectuée.</param>
        public void AjouterHistorique(string action)
        {
            this.historique.AddLast(action);
        }

        /// <summary>
        /// Retourne l’historique complet des actions du visiteur.
        /// </summary>
        /// <returns>Une liste chaînée contenant les actions du visiteur.</returns>
        public LinkedList<string> GetHistorique()
        {
            return this.historique;
        }

        /// <summary>
        /// Retourne le nom du visiteur.
        /// </summary>
        /// <returns>Le nom du visiteur.</returns>
        public string GetNom()
        {
            return this.nom;
        }
    }
}