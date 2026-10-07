using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp3
{
    class monnaie
    {
        private string nom;
        private float change;

        public  monnaie (string unNom, float unChange)
        {
            nom = unNom;
            change = unChange;
        }

        public string getnom()
        {
            return nom;
        }

        public void setnom(string unNom)
        {
             nom = unNom;
        }

        public float getchange()
        {
            return change;
        }

        public void setchange(float unChange)
        {
            change = unChange;
        }

        public override string ToString()
        {
            return (" Monnaie : " + nom + "\n Taux change : " + change);
        }
    }
}
