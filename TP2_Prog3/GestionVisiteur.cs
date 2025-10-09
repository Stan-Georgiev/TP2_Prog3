using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Prog3
{
    internal class GestionVisiteur
    {
        
       public List<Visiteur> VisiteursDansParc = new List<Visiteur>();
        public GestionVisiteur(Parc parc)
        {
            
        }

        public int GetNbVisiteur(GestionVisiteur visiteur)
        {
            return visiteur.VisiteursDansParc.Count;
        }

        public void EntrerVisiteurDansFilAttente(string attractionId, Visiteur visiteur)
        {
            visiteur.AjouterHistorique($"{visiteur.GetNom()} rentre dans la file de l'attraction {attractionId}");
        }

        public void EntrerVisiteurDansAttraction(string attractionId, Visiteur visiteur,Parc parc)
        {
       
           foreach (var attractions in  parc.GetAttractions())
           {
               if (attractions.GetId() == attractionId && attractions.VisiteursEnligne.Count < attractions.GetCapacity())
               {
                   attractions.VisiteursEnligne.Add(visiteur);
               }
               else if  (attractions.GetId() == attractionId && attractions.VisiteursEnligne.Count > attractions.GetCapacity())
               {
                   visiteur.AjouterHistorique($"{visiteur.GetNom()} est terriblement triste, il ne reste pas de place dans la file de l'attraction {attractionId}!!!!!");
               }
           }
       
           
        }

        public void EntrerVisiteurDansParc(Visiteur visiteur, GestionVisiteur gestionVisiteur)
        {
            gestionVisiteur.VisiteursDansParc.Add(visiteur);
            visiteur.AjouterHistorique($"{visiteur.GetNom()} rentre dans le parc");
        }

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
