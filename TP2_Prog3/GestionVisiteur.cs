using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Prog3
{
    internal class GestionVisiteur
    {
        private int _nbVisiteur;
        
        public GestionVisiteur(Parc parc)
        {
            
        }

        public int GetNbVisiteur()
        {
            return _nbVisiteur;
        }

        public void EntrerVisiteurDansFilAttente(string attractionId, Visiteur visiteur)
        {
            visiteur.AjouterHistorique($"{visiteur.GetNom} rentre dans la file de l\'attraction {attractionId}");
        }

        public void EntrerVisiteurDansAttraction(string attractionId)
        {
           
        }

        public void EntrerVisiteurDansParc(Visiteur visiteur)
        {
            _nbVisiteur++;
            visiteur.AjouterHistorique($"{visiteur.GetNom} rentre dans le parc");
        }

        public void SortirVisiteurDuParc(Visiteur visiteur)
        {
            _nbVisiteur--;
            visiteur.AjouterHistorique($"{visiteur.GetNom} sort du le parc");
        }
    }
}
