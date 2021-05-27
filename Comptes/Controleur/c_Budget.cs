using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using Comptes.Model;
using System.Globalization;
using Comptes.Control;
using Comptes.Constants;


namespace Comptes.Control
{
    public partial class Controler
    {

        /// <summary>
        /// Crée et stocke le nouveau budget.
        /// </summary>
        /// <returns></returns>
        public void addBudget(string budgetName, string division)
        {
            Budget newBudget = new Budget(
                name: budgetName,
                division: data.dctDivisions[division]);

            data.allBudgets.Add(newBudget);
            data.allAccounts.Add(newBudget.account);
        }

        /// <summary>
        /// Edite un budget
        /// </summary>
        /// <param name="budget">Budget à éditer</param>
        /// <param name="budgetName">Nouveau nom du budget</param>
        /// <param name="division">Répartition au format "x/x"</param>
        public void updateBudget(Budget budget, string budgetName, string division)
        {
            budget.name = budgetName;
            budget.division = data.dctDivisions[division];
        }

        /// <summary>
        /// Supprime le budget des données.
        /// </summary>
        /// <param name="budget">Budget à supprimer.</param>
        public void deleteBudget(Budget budget)
        {
            data.allAccounts.Remove(budget.account);
            data.allBudgets.Remove(budget);
        }

        /// <summary>
        /// Supprime tous les budgets sauvegardés.
        /// </summary>
        public void resetAllBudgets()
        {
            data.allBudgets.Clear();
        }

        /// <summary>
        /// Retourne la liste des budgets enregistrés.
        /// </summary>
        /// <returns></returns>
        public List<Budget> getAllBudgets()
        {
            return data.allBudgets;
        }
        
        /// <summary>
        /// Retourne la liste des comptes enregistrés.
        /// </summary>
        /// <returns></returns>
        public List<Account> getAllAccounts()
        {
            return data.allAccounts;
        }
    }
}
