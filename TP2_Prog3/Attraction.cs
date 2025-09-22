using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Prog3
{
    internal class Attraction
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
        private TypeAttraction _type { get; }

        


        public Attraction(string id, TypeAttraction type, string name, int capacity) {
            this._id = id;
            this._name = name;
            this._capacity = capacity;
            this._type = type;
        }

        public string getId()
        {
            return _id;
        }

        public string getName()
        {
            return _name;
        }

        public int getCapacity()
        {
            return _capacity;
        }

        public TypeAttraction getType()
        {
            return _type;
        }
    }
}
