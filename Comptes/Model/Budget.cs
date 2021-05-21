using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comptes.Constants;

namespace Comptes.Model
{
    [SerializableAttribute]
    public class Budget
    {
        private Account _account;
        private string _name;
        private double _division;

        public Budget(string name, double division)
        {
            this._name = name;
            this._division = division;
            _account = new Account(this);
        }

        public Account account
        {
            get => _account;
        }

        public string name { get => _name; set => _name = value; }

        public double division { get => _division; set => _division = value; }

        public override string ToString()
        {
            return name + " : " + (division * 100).ToString() + " / " + (100 - division * 100).ToString();
        }

        public string displayBudgetName()
        {
            return name + " : ";
        }

        /// <summary>
        /// Calcule les dettes totales et met à jour l'objet User.
        /// </summary>
        /// <param name="allBudgets"></param>
        public static void calculateDebts(List<Budget> allBudgets)
        {
            double totalDebtsUserA = 0;
            double totalDebtsUserB = 0;
            foreach (Budget budget in allBudgets)
            {
                totalDebtsUserA += budget.account.userB.expenses * budget.division;
                totalDebtsUserB += budget.account.userA.expenses * (1 - budget.division);
            }

            User.setDebts(Const.USER_A, Math.Round(totalDebtsUserA, 2));
            User.setDebts(Const.USER_B, Math.Round(totalDebtsUserB, 2));
        }
    }
}
