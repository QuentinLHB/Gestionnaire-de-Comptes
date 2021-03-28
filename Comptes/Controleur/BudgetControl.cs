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
        /// Crée un budget et l'affiche.
        /// </summary>
        /// <returns></returns>
        public void createNewBudget(string budgetName, string division)
        {
            Budget newBudget = new Budget(
                name: budgetName,
                division: data.dctDivisions[division]);

            data.allBudgets.Add(newBudget);

            frmMain.addToLstAccount(Const.BUDGET, newBudget.displayBudgetName());
            frmMain.addToLstAccount(Const.ACCOUNT, newBudget.displayBudgetName());

        }

        /// <summary>
        /// Retourne le budget à l'index spécifié..
        /// </summary>
        /// <param name="index">Index de la liste des budgets.</param>
        /// <returns>L'objet Budget sélectionné.</returns>
        public Budget getSelectedBudget()
        {
            return data.allBudgets[frmMain.getSelectedIndex()];
        }

        /// <summary>
        /// Intervertit les boutons d'ajout et d'édition.
        /// </summary>
        /// <param name="modeEdition"></param>
        public void handleEditionMode(bool modeEdition)
        {
            frmMain.switchMode(modeEdition);
        }


        /// <summary>
        /// Update le Budget sélectionné après édition.
        /// </summary>
        public void updateBudget(string budgetName, string division)
        {
            Budget selectedBudget = getSelectedBudget();
            selectedBudget.name = budgetName;
            selectedBudget.division = data.dctDivisions[division];
        }

        /// <summary>
        /// Demande confirmation et supprime le budget sélectionné et le compte associé.
        /// </summary>
        /// <param name="index">Index du budget à supprimer.</param>
        /// <returns>True si l'utilisateur a validé.
        /// False Si l'utilisateur a annulé. </returns>
        public bool deleteBudget(int index)
        {
            if (MessageBox.Show(Const.MSG_DELETEBUDGET, Const.MSG_TITLE_DELETE, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                data.allBudgets.RemoveAt(index);
                frmMain.accessAddAccount();
                frmMain.refreshResult();
                return true;
            }
            return false;
        }

        public void resetAllBudgets()
        {
            data.allBudgets.Clear();
        }
    }
}
