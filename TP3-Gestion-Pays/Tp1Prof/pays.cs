using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp3
{
    class pays
    {
        private string nom;
        private int habitant;
        private monnaie samonnaie;

        public pays(string unNom, int unHabitant, monnaie uneMonnaie)
        {
            nom = unNom;
            habitant = unHabitant;
            samonnaie = uneMonnaie;
        }

        public string getnom()
        {
            return nom;
        }

        public void setnom(string unNom)
        {
            nom = unNom;
        }

        public int gethabitant()
        {
            return habitant;
        }

        public void sethabitant(int unHabitant)
        {
            habitant = unHabitant;
        }

        public monnaie getsamonnaie()
        {
            return samonnaie;
        }
        
        public override string ToString()
        {
            return ("Pays : " + nom + samonnaie.ToString() + "\n Habitants : " + habitant);
        }
        
    }
}
