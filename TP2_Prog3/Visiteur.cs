using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Prog3
{
    internal class Visiteur
    {
        private string _nom;
        private LinkedList<string> _historique;

        public Visiteur(string nom, LinkedList<string> historique)
        {
            this._nom = nom;
            _historique = historique;
        }

        public void AjouterHistorique(string action)
        {
            _historique.AddLast(action);
        }

        public string GetNom()
        {
            return _nom;
        }
    }
}
