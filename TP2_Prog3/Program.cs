
using System.Text;

namespace TP2_Prog3
{
    public static class Program
    {
      
      
        private static readonly Parc Parc = new();
        private static readonly Map Map = new Map();
        private static readonly GestionVisiteur GestionVisiteurs = new(Parc);
  
        private static void Afficher()
        {
            
            Thread.Sleep(1000);
            AffichageConsole.Afficher(Parc, Map, GestionVisiteurs);
        }
        private static void TestEntrerVisiteur(Visiteur visiteur)
        {
            GestionVisiteurs.EntrerVisiteurDansParc(visiteur,GestionVisiteurs);
            GestionVisiteurs.EntrerVisiteurDansFilAttente("M0002", visiteur);
            Afficher();
        }
        private static void TestSortirVisiteur(Visiteur visiteur)
        {
            GestionVisiteurs.SortirVisiteurDuParc(visiteur,GestionVisiteurs, Parc);
            Afficher();
        }
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8; 
            Attraction m1 = new Attraction("M0001", Attraction.TypeAttraction.M,"Manege 1",4);
            Attraction r1 = new Attraction("R0002", Attraction.TypeAttraction.R, "Restaurant 1", 50);
            Attraction r2 = new Attraction("R0001", Attraction.TypeAttraction.R, "Restaurant 2", 50);
            Attraction m3 = new Attraction("M0003", Attraction.TypeAttraction.M, "Manege 3", 4);
            Attraction m2 = new Attraction("M0002", Attraction.TypeAttraction.M, "Manege 2", 4);
            Attraction t1 = new Attraction("T0001", Attraction.TypeAttraction.T, "Toilette 1", 8);
            Attraction t2 = new Attraction("T0002", Attraction.TypeAttraction.T, "Toilette 2", 8);
            Parc.AjouterAttraction(m1);
            Parc.AjouterAttraction(m2);
            Parc.AjouterAttraction(m3);
            Parc.AjouterAttraction(r1);
            Parc.AjouterAttraction(r2);
            Parc.AjouterAttraction(t1);
            Parc.AjouterAttraction(t2);
            
            AffichageConsole.Afficher(Parc, Map, GestionVisiteurs);
            var visiteur1 = new Visiteur("Nom 1");
            TestEntrerVisiteur(visiteur1);
            var visiteur2 = new Visiteur("Nom 2");
            TestEntrerVisiteur(visiteur2);
            var visiteur3 = new Visiteur("Nom 3");
            TestEntrerVisiteur(visiteur3);
            var visiteur4 = new Visiteur("Nom 4");
            TestEntrerVisiteur(visiteur4);
            foreach (var t in GestionVisiteurs.VisiteursDansParc)
            {
                GestionVisiteurs.EntrerVisiteurDansAttraction("M0002", t,Parc );
             
                Afficher();
            }
            TestSortirVisiteur(visiteur3);
            TestSortirVisiteur(visiteur4);
            TestSortirVisiteur(visiteur2);
            TestSortirVisiteur(visiteur1);
           AffichageConsole.AfficherHistoriqueVisiteur(visiteur1);
        }
    }
}
