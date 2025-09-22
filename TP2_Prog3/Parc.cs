using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Prog3
{
    internal class Parc
    {
        /** Utilisation d'une linked list**/
        LinkedList<Attraction> Park = new LinkedList<Attraction>();
        Attraction m1 = new Attraction("M0001", 0,"Manège 1",4);

        public void ajouterAttraction(Attraction a) {
            Park­.AddFirst(a);
        }
    }
}
