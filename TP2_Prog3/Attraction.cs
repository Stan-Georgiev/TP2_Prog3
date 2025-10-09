using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Prog3
{
    public class Attraction
    {
        public enum TypeAttraction
        {
            S = 0,
            I = 1,
            F = 2,
            T = 3,
            M = 4,
            R = 5
        }

        private string _id;
        private string _name;
        private int _capacity;
        public List<Visiteur> VisiteursEnligne = new List<Visiteur>();
        private TypeAttraction Type { get; }

        


        public Attraction(string id, TypeAttraction type, string name, int capacity) {
            this._id = id;
            this._name = name;
            this._capacity = capacity;
            this.Type = type;
        }

        public string GetId()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetCapacity()
        {
            return _capacity;
        }

        public TypeAttraction GetTypeAttraction()
        {
            return Type;
        }
    }
}
