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
using System.Globalization;
using Comptes.Constants;
using Comptes.Model;

namespace Comptes
{

    // Contient les fonctions non-évènementielles.

    public partial class frmMain : Form
    {

        /// <summary>
        /// Charge les répartitions dans un combobox
        /// </summary>
        /// <param name="comboBox">Combobox dans lequel charger les répartitions.</param>
        public void loadDivisions(ComboBox comboBox)
        {
            foreach (KeyValuePair<string, double> pair in controler.getDivisions())
            {
                comboBox.Items.Add(pair.Key);
            }
            comboBox.SelectedIndex = 0;
        } 

        /// <summary>
        /// Affiche les dettes des utilisateurs.
        /// </summary>
        public void refreshDebts()
        {
            double[] debts = controler.getDebts();
            lblTotalUserA.Text = debts[Const.USER_A].ToString() + "€";
            lblTotalUserB.Text = debts[Const.USER_B].ToString()+ "€" ;
        }


        /// <summary>
        /// Met à jour les dettes et affiche le résultat final.
        /// </summary>
        public void refreshTotals()
        {
            lblResults.Text = controler.updateTotals();
        }

        /// <summary>
        /// Recharge les divisions dans le combo.
        /// </summary>
        public void refreshCboDivisions()
        {
            cboDivisions.Items.Clear();
            loadDivisions(cboDivisions);
        }


        /// <summary>
        /// Réinitialise la cellule et le focus après la validation d'un bouton.
        /// </summary>
        public void resetBudget(TextBox txtBudgetName)
        {
            txtBudgetName.Text = "";
            txtBudgetName.Focus();
        }

        /// <summary>
        /// Change les boutons (Ajout/Edit), et empêche le changement de lignes.
        /// </summary>
        /// <example>Mode edition true = Bouton Edit Visible, Bouton OK invisible.</example>
        /// <param name="modeEdition">True si édition, false si ajout.</param>
        public void switchMode(bool modeEdition)
        {
            btnOKBudgets.Visible = !modeEdition;
            btnEdit.Visible = modeEdition;
            lstBudgets.Enabled = !modeEdition;
            lstAccounts.Enabled = !modeEdition;
            btnResetBudget.Enabled = !modeEdition;
            btnResetComptes.Enabled = !modeEdition;


        }

        /// <summary>
        /// Si la liste des budgets est vide, désactive le bouton Valider de la zone comptes.
        /// </summary>
        public void accessAddAccount()
        {
            if (lstBudgets.Items.Count != 0)
            {
                btnOKAccount.Enabled = true;
                lstBudgets.SelectedIndex = 0;
            }

            else
            {
                btnOKAccount.Enabled = false;
            }
        }

        /// <summary>
        /// Gère les textBox des montants si elles sont vides.
        /// </summary>
        public void fillIfEmpty()
        {
            if (txtAmountUserA.Text.Equals(""))
            {
                txtAmountUserA.Text = "0";
            }

            if (txtAmountUserB.Text.Equals(""))
            {
                txtAmountUserB.Text = "0";
            }
        }

        /// <summary>
        /// Vide les TextBox liés aux comptes.
        /// </summary>
        public void resetAccountBox()
        {
            txtAmountUserA.Focus();
            txtAmountUserA.Text = "";
            txtAmountUserB.Text = "";
        }

        /// <summary>
        /// Affiche le nom des utilisateurs dans tous les emplacements.
        /// </summary>
        public void displayUsersNames()
        {
            lblUsersNames.Text = $"Comptes de {User.getName(Const.USER_A)} et {User.getName(Const.USER_B)} du mois de ";
            lblUserA.Text = controler.getUserNameDisplay(Const.USER_A);
            lblUserB.Text = controler.getUserNameDisplay(Const.USER_B);
            lblNomTotalUserA.Text = controler.getUserDebtsDisplay(Const.USER_A);
            lblNomTotalUserB.Text = controler.getUserDebtsDisplay(Const.USER_B);
        }

        /// <summary>
        /// Réinitialise les éléments de la vue : TextBox vides, combo initialisé sans ajout, 
        /// </summary>
        public void resetView()
        {
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                var textbox = control as TextBox;
                if (textbox != null)
                {
                    textbox.Text = string.Empty;
                }
                
                else 
                {
                    var groupbox = control as GroupBox;
                    if(groupbox != null)
                    foreach (System.Windows.Forms.Control subcontrol in groupbox.Controls)
                    {
                        var subTextbox = subcontrol as TextBox;
                        if (subTextbox != null)
                        {
                            subTextbox.Text = string.Empty;
                        }
                    }
                }
            }

            controler.setDefaultUsersNames();
            displayUsersNames();
            controler.resetAllBudgets();
            controler.resetAllAccounts();
            refreshLists();
            btnOKAccount.Enabled = false;
        }

        private void emptyAllAccounts()
        {
            for (int k = 0; k < lstAccounts.Items.Count; k++)
            {
                lstAccounts.SelectedIndex = k;
                controler.emptyAccountData((Account)lstAccounts.SelectedItem);
            }
        }

        public void addDivision(string division)
        {
            cboDivisions.Items.Add(division);
        }

        private void refreshAccountList()
        {
            bdgAccounts.ResetBindings();
        }

        private void refreshLists()
        {
            bdgBudgets.ResetBindings();
            refreshAccountList();
        }

        public void loadMonthlySave(DateTime monthYear)
        {
            refreshLists();
            dtpMonth.Value = monthYear;
            refreshTotals();
            accessAddAccount();
        }
    }
}
