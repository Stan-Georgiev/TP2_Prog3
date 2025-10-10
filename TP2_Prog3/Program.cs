// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace TP2_Prog3
{
    using System;
    using System.Text;

    /// <summary>
    /// Classe principale du programme.
    /// Elle initialise le parc, les attractions et gèrent le cycle de vie des visiteurs.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Instance unique du parc contenant toutes les attractions.
        /// </summary>
        private static readonly Parc Parc = new Parc();

        /// <summary>
        /// Carte du parc utilisée pour l’affichage.
        /// </summary>
        private static readonly Map Map = new Map();

        /// <summary>
        /// Gestionnaire des visiteurs permettant d’entrer, de sortir et de déplacer les visiteurs.
        /// </summary>
        private static readonly GestionVisiteur GestionVisiteurs = new GestionVisiteur();

        /// <summary>
        /// Point d’entrée principal du programme.
        /// Initialise les attractions, ajoute des visiteurs et simule leurs déplacements.
        /// </summary>
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Création des attractions
            Attraction m1 = new Attraction("M0001", Attraction.TypeAttraction.M, "Magasin 1", 8);
            Attraction m2 = new Attraction("M0002", Attraction.TypeAttraction.M, "Magasin 2", 4);
            Attraction m3 = new Attraction("M0003", Attraction.TypeAttraction.M, "Magasin 3", 8);
            Attraction r1 = new Attraction("R0001", Attraction.TypeAttraction.R, "Restaurant 1", 50);
            Attraction r2 = new Attraction("R0002", Attraction.TypeAttraction.R, "Restaurant 2", 50);
            Attraction t1 = new Attraction("T0001", Attraction.TypeAttraction.T, "Toilette 1", 8);
            Attraction t2 = new Attraction("T0002", Attraction.TypeAttraction.T, "Toilette 2", 8);

            // Ajout des attractions au parc
            Parc.AjouterAttraction(m1);
            Parc.AjouterAttraction(m2);
            Parc.AjouterAttraction(m3);
            Parc.AjouterAttraction(r1);
            Parc.AjouterAttraction(r2);
            Parc.AjouterAttraction(t1);
            Parc.AjouterAttraction(t2);

            // Affichage initial
            AffichageConsole.Afficher(Parc, Map, GestionVisiteurs);

            // Création et entrée des visiteurs
            var visiteur1 = new Visiteur("Faylen Varks");
            TestEntrerVisiteur(visiteur1);

            var visiteur2 = new Visiteur("Bjorn Varks");
            TestEntrerVisiteur(visiteur2);

            var visiteur3 = new Visiteur("Aakoda Varks ");
            TestEntrerVisiteur(visiteur3);

            var visiteur4 = new Visiteur("Sigurd Tyrkirsson");
            TestEntrerVisiteur(visiteur4);

            // Déplacement des visiteurs dans une attraction
            foreach (var t in GestionVisiteurs.VisiteursDansParc)
            {
                GestionVisiteurs.EntrerVisiteurDansAttraction("M0002", t, Parc);
                Afficher();
            }

            // Sortie des visiteurs
            TestSortirVisiteur(visiteur3);
            TestSortirVisiteur(visiteur4);
            TestSortirVisiteur(visiteur2);
            TestSortirVisiteur(visiteur1);

            // Affichage de l’historique d’un visiteur
            AffichageConsole.AfficherHistoriqueVisiteur(visiteur1);
        }

        /// <summary>
        /// Rafraîchit l’affichage du parc après une courte pause.
        /// </summary>
        private static void Afficher()
        {
            Thread.Sleep(1000);
            AffichageConsole.Afficher(Parc, Map, GestionVisiteurs);
        }

        /// <summary>
        /// Teste l’entrée d’un visiteur dans le parc et dans une file d’attente.
        /// </summary>
        /// <param name="visiteur">Le visiteur à faire entrer.</param>
        private static void TestEntrerVisiteur(Visiteur visiteur)
        {
            GestionVisiteurs.EntrerVisiteurDansParc(visiteur, GestionVisiteurs);
            GestionVisiteurs.EntrerVisiteurDansFilAttente("M0002", visiteur);
            Afficher();
        }

        /// <summary>
        /// Teste la sortie d’un visiteur du parc.
        /// </summary>
        /// <param name="visiteur">Le visiteur à faire sortir.</param>
        private static void TestSortirVisiteur(Visiteur visiteur)
        {
            GestionVisiteurs.SortirVisiteurDuParc(visiteur, GestionVisiteurs, Parc);
            Afficher();
        }
    }
}
