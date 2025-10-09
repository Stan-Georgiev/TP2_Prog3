using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Prog3
{
    public class Visiteur
    {
        private string _nom;
        private LinkedList<string> _historique = new LinkedList<string>();

        public Visiteur(string nom)
        {
            this._nom = nom;
        }

        public void AjouterHistorique(string action)
        {
            _historique.AddLast(action);
        }

        public LinkedList<string> GetHistorique()
        {
            return _historique;
        }

        public string GetNom()
        {
            return _nom;
        }
    }
}
