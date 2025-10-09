using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Prog3
{
    public class Parc
    {
        /** Utilisation d'une linked list**/
        //Hash//
        private HashSet<Attraction> _attractions = new HashSet<Attraction>();
    

        public void AjouterAttraction(Attraction a) {
            _attractions.Add(a);
        }

        public HashSet<Attraction> GetAttractions() => _attractions;
    }
    
}
