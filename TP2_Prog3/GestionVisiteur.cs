// <copyright file="GestionVisiteur.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace TP2_Prog3
{
    using System.Collections.Generic;

    /// <summary>
    /// Gère les visiteurs présents dans le parc, leur entrée, leur sortie
    /// ainsi que leur interaction avec les attractions.
    /// </summary>
    internal class GestionVisiteur
    {
        /// <summary>
        /// Gets liste des visiteurs actuellement présents dans le parc.
        /// </summary>
        public List<Visiteur> VisiteursDansParc { get; } = new List<Visiteur>();

        /// <summary>
        /// Retourne le nombre de visiteurs actuellement dans le parc.
        /// </summary>
        /// <param name="gestionVisiteur">Instance de gestion des visiteurs.</param>
        /// <returns>Le nombre de visiteurs présents dans le parc.</returns>
        public int GetNbVisiteur(GestionVisiteur gestionVisiteur)
        {
            return gestionVisiteur.VisiteursDansParc.Count;
        }

        /// <summary>
        /// Ajoute une entrée dans l’historique du visiteur indiquant
        /// qu’il est entré dans la file d’attente d’une attraction.
        /// </summary>
        /// <param name="attractionId">Identifiant de l’attraction.</param>
        /// <param name="visiteur">Le visiteur concerné.</param>
        public void EntrerVisiteurDansFilAttente(string attractionId, Visiteur visiteur)
        {
            visiteur.AjouterHistorique($"{visiteur.GetNom()} rentre dans la file de l'attraction {attractionId}");
        }

        /// <summary>
        /// Fait entrer un visiteur dans une attraction si la capacité le permet.
        /// Sinon, ajoute une note dans son historique indiquant qu’il n’a pas pu entrer.
        /// </summary>
        /// <param name="attractionId">Identifiant de l’attraction.</param>
        /// <param name="visiteur">Le visiteur concerné.</param>
        /// <param name="parc">Le parc contenant les attractions.</param>
        public void EntrerVisiteurDansAttraction(string attractionId, Visiteur visiteur, Parc parc)
        {
            foreach (var attraction in parc.GetAttractions())
            {
                if (attraction.GetId() == attractionId && attraction.VisiteursEnligne.Count < attraction.GetCapacity())
                {
                    attraction.VisiteursEnligne.Add(visiteur);
                }
                else if (attraction.GetId() == attractionId && attraction.VisiteursEnligne.Count >= attraction.GetCapacity())
                {
                    visiteur.AjouterHistorique($"{visiteur.GetNom()} est terriblement triste, il ne reste pas de place dans la file de l'attraction {attractionId}!");
                }
            }
        }

        /// <summary>
        /// Fait entrer un visiteur dans le parc et ajoute une entrée dans son historique.
        /// </summary>
        /// <param name="visiteur">Le visiteur est ajouté.</param>
        /// <param name="gestionVisiteur">Gestionnaire des visiteurs.</param>
        public void EntrerVisiteurDansParc(Visiteur visiteur, GestionVisiteur gestionVisiteur)
        {
            gestionVisiteur.VisiteursDansParc.Add(visiteur);
            visiteur.AjouterHistorique($"{visiteur.GetNom()} rentre dans le parc");
        }

        /// <summary>
        /// Fait sortir un visiteur du parc, le retire des attractions avec lesquelles il se trouve
        /// et ajoute une entrée dans son historique.
        /// </summary>
        /// <param name="visiteur">Le visiteur est retiré.</param>
        /// <param name="gestionVisiteur">Gestionnaire des visiteurs.</param>
        /// <param name="parc">Le parc contenant les attractions.</param>
        public void SortirVisiteurDuParc(Visiteur visiteur, GestionVisiteur gestionVisiteur, Parc parc)
        {
            gestionVisiteur.VisiteursDansParc.Remove(visiteur);

            foreach (var attraction in parc.GetAttractions())
            {
                if (attraction.VisiteursEnligne.Contains(visiteur))
                {
                    attraction.VisiteursEnligne.Remove(visiteur);
                }
            }

            visiteur.AjouterHistorique($"{visiteur.GetNom()} sort du parc");
        }
    }
}
