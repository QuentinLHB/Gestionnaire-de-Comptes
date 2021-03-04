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
using Comptes.Model; //A enlever 
using System.Globalization;

namespace Comptes
{
    public partial class frmMain : Form
    {
        private void btnOKBudgets_Click(object sender, EventArgs e)
        {
            Budget newBudget = createNewBudget();
            lstAccounts.Items.Add(newBudget.displayBudgetName());
            lstAccounts.SelectedIndex = 0;
            resetBudget();
            accessAddAccount();
            setFlagChange(change:true);
        }

        /// <summary>
        /// Crée un budget et l'affiche.
        /// </summary>
        /// <returns></returns>
        private Budget createNewBudget()
        {
            Budget newBudget = new Budget(
                name: txtBudgetName.Text,
                division: data.dctDivisions[cboDivisions.SelectedItem.ToString()]);

            data.allBudgets.Add(newBudget);
            lstBudgets.Items.Add(newBudget);

            return newBudget;
        }

        /// <summary>
        /// Réinitialise la cellule et le focus après la validation d'un bouton.
        /// </summary>
        private void resetBudget()
        {
            txtBudgetName.Text = "";
            txtBudgetName.Focus();
        }

        private void lstBudgets_DoubleClick(object sender, EventArgs e)
        {
            Budget selectedBudget = getSelectedBudget(); ;
            txtBudgetName.Text = selectedBudget.name;
            cboDivisions.SelectedItem = selectedBudget.division.ToString(); //ne fonctionne pas
            txtBudgetName.Focus();
            gererModeEdition(modeEdition: true);

        }

        /// <summary>
        /// Retourne le budget sélectionné dans la liste.
        /// </summary>
        /// <returns></returns>
        private Budget getSelectedBudget()
        {
            return data.allBudgets[lstBudgets.SelectedIndex];
        }

        /// <summary>
        /// Intervertit les boutons d'ajout et d'édition.
        /// </summary>
        /// <param name="modeEdition"></param>
        private void gererModeEdition(bool modeEdition)
        {
            btnOKBudgets.Visible = !modeEdition;
            btnEdit.Visible = modeEdition;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Budget selectedBudget = getSelectedBudget();
            selectedBudget.name = txtBudgetName.Text;
            selectedBudget.division = data.dctDivisions[cboDivisions.SelectedItem.ToString()];

            lstBudgets.Items[lstBudgets.SelectedIndex] = selectedBudget;
            updateAccountDislay(getSelectedAccount());
            updateTotals();
            gererModeEdition(modeEdition: false);
            resetBudget();
        }

        private void lstBudgets_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteBudget();
            }
        }

        /// <summary>
        /// Supprime le budget sélectionné et le compte associé.
        /// </summary>
        private void deleteBudget()
        {
            if (MessageBox.Show(Const.MSG_DELETEBUDGET, Const.MSG_TITLE_DELETE, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int index = lstBudgets.SelectedIndex;

                data.allBudgets.RemoveAt(index);

                lstBudgets.Items.RemoveAt(index);
                lstAccounts.Items.RemoveAt(index);

                accessAddAccount();

                updateTotals();

                txtBudgetName.Focus();
            }
        }

        private void btnResetBudget_Click(object sender, EventArgs e)
        {
            data.allBudgets.Clear();
            lstBudgets.Items.Clear();
            lstAccounts.Items.Clear();
        }
    }
}
