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
    public partial class frmPrincipal : Form
    {
        private void btnOKBudgets_Click(object sender, EventArgs e)
        {
            Budget nouveauBudget = creationNouveauBudget();
            lstComptes.Items.Add(nouveauBudget.afficheNomBudget());
            lstComptes.SelectedIndex = 0;
            resetBudget();
            accesAjoutCompte();
            flagChangement(changement:true);
        }

        /// <summary>
        /// Crée un budget et l'affiche.
        /// </summary>
        /// <returns></returns>
        private Budget creationNouveauBudget()
        {
            Budget nouveauBudget = new Budget(
                nom: txtNomBudget.Text,
                repartition: data.dctRepartitions[cboRepartition.SelectedItem.ToString()],
                data.lesUsers[Constantes.USER_A].nom, data.lesUsers[Constantes.USER_B].nom);

            data.lesBudgets.Add(nouveauBudget);
            lstBudgets.Items.Add(nouveauBudget);

            return nouveauBudget;
        }

        /// <summary>
        /// Réinitialise la cellule et le focus après la validation d'un bouton.
        /// </summary>
        private void resetBudget()
        {
            txtNomBudget.Text = "";
            txtNomBudget.Focus();
        }

        private void lstBudgets_DoubleClick(object sender, EventArgs e)
        {
            Budget BudgetSelectionne = getBudgetSelectionne(); ;
            txtNomBudget.Text = BudgetSelectionne.nom;
            cboRepartition.SelectedItem = BudgetSelectionne.repartition.ToString(); //ne fonctionne pas
            txtNomBudget.Focus();
            gérerModeEdition(modeEdition: true);

        }

        /// <summary>
        /// Retourne le budget sélectionné dans la liste.
        /// </summary>
        /// <returns></returns>
        private Budget getBudgetSelectionne()
        {
            return data.lesBudgets[lstBudgets.SelectedIndex];
        }

        /// <summary>
        /// Intervertit les boutons d'ajout et d'édition.
        /// </summary>
        /// <param name="modeEdition"></param>
        private void gérerModeEdition(bool modeEdition)
        {
            btnOKBudgets.Visible = !modeEdition;
            btnEdit.Visible = modeEdition;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Budget budgetSelectionne = getBudgetSelectionne();
            budgetSelectionne.nom = txtNomBudget.Text;
            budgetSelectionne.repartition = data.dctRepartitions[cboRepartition.SelectedItem.ToString()];

            lstBudgets.Items[lstBudgets.SelectedIndex] = budgetSelectionne;
            updateAffichageComptes(GetCompteSelectionne());
            gérerModeEdition(modeEdition: false);
            resetBudget();
        }

        private void lstBudgets_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                supprimerBudget();
            }
        }

        /// <summary>
        /// Supprime le budget sélectionné et le compte associé.
        /// </summary>
        private void supprimerBudget()
        {
            if (MessageBox.Show(Constantes.MSG_SUPPRBUDGET, Constantes.MSG_TITRE_SUPPRBUDGET, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int index = lstBudgets.SelectedIndex;

                data.lesBudgets.RemoveAt(index);

                lstBudgets.Items.RemoveAt(index);
                lstComptes.Items.RemoveAt(index);

                accesAjoutCompte();

                updateTotaux();
                updateResultat();

                txtNomBudget.Focus();
            }
        }

        private void btnResetBudget_Click(object sender, EventArgs e)
        {
            data.lesBudgets.Clear();
            lstBudgets.Items.Clear();
            lstComptes.Items.Clear();
        }
    }
}
