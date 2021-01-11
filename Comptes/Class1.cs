using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comptes
{
    class Budget
    {
        public Budget(string nom, double repartition)
        {
            this.nom = nom;
            this.repartition = repartition;
        }

        public string nom { get; set; }

        public double repartition { get; set; }



        public int index { get; set; }

        private string affichage()
        {
            return nom + " : " + (repartition * 100).ToString() + " / " + (100 - repartition * 100).ToString();
        }

        public override string ToString()
        {
            return affichage();
        }


    }
    class Compte
    {
        public Budget budget { get; }

        public double depensesPersA { get; set; }

        public double depensesPersB { get; set; }

        public Compte(Budget budget)
        {
            this.budget = budget;
        }

        public override string ToString()
        {
            return budget.nom + " : " + depensesPersA.ToString() + " / " + depensesPersB.ToString();
        }


    }
}
