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
//using Comptes.Model; //A enlever 
using System.Globalization;
using Comptes.Control;
using Comptes.Constants;

/** Gestionnaire de comptes
 * Gère les comptes mensuels de deux utilisateur.
 * @author QuentinLHB
 * Date de création : 05/01/2021
 * Dernière mise à jour : 14/03/2021
 */

namespace Comptes
{
    public partial class frmMain : Form
    {

        Controler controler;

        public frmMain() 
        { 
            controler = new Controler(this);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Const.initializeDivisions();
            loadCboMonth(cboMonth);
            selectCurrentMonth(cboMonth);
            loadThreeYears(cboYear);
            controler.loadData();
            loadDivisions(cboDivisions);
            refreshTotals();
            accessAddAccount();
            dtpMonth.CustomFormat = "MMMM / dddd";

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            controler.minimizeWindow(this);
        }

        /// <summary>
        /// Ajoute les dettes de chacune des personnes dans la liste des comptes.
        /// </summary>
        /// <param name="sender">Boutton validant un compte.</param>
        /// <param name="e">Clic</param>
        private void btnOKComptes_Click(object sender, EventArgs e)
        {

            fillIfEmpty();
            controler.calculateExpenses(controler.getSelectedAccount(), txtAmountUserA.Text, txtAmountUserB.Text);
            updateListBox(list: Const.ACCOUNT, item: controler.getSelectedAccount().ToString());
            refreshTotals();
            try { lstBudgets.SelectedIndex++; }
            catch { }
            resetAccountBox();
            controler.setFlagChange(change: true);
        }

        /// <summary>
        /// Supprime le compte sélectionné si la touche Suppr est pressée.
        /// </summary>
        /// <param name="sender">Liste des comptes.</param>
        /// <param name="e">Touche levée.</param>
        private void lstComptes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                controler.emptyAccountData(lstAccounts.SelectedIndex);
                refreshTotals();
            }
        }

        /// <summary>
        /// Affiche les données d'un compte double-cliqué dans les zones adaptées.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Double clic</param>
        private void lstComptes_DoubleClick(object sender, EventArgs e)
        {
            double[] usersExpenses = controler.getUsersExpenses();
            txtAmountUserA.Text = usersExpenses[Const.USER_A].ToString();
            txtAmountUserB.Text = usersExpenses[Const.USER_B].ToString();
            txtAmountUserA.Focus();
        }

        /// <summary>
        /// Réinitialise chaque compte et affiche la valeur par défaut.
        /// </summary>
        /// <param name="sender">Bouton réinitialisant les comptes.</param>
        /// <param name="e">Clic</param>
        public void btnResetAccounts_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < lstAccounts.Items.Count; k++)
            {
                lstAccounts.SelectedIndex = k;
                controler.emptyAccountData(k);
            }
            accessAddAccount();
            refreshTotals();
        }

        private void btnOKBudgets_Click(object sender, EventArgs e)
        {
            controler.createNewBudget(txtBudgetName.Text, cboDivisions.SelectedItem.ToString());
            lstAccounts.SelectedIndex = 0;
            resetBudget(txtBudgetName);
            accessAddAccount();
            controler.setFlagChange(change: true);
        }



        private void lstBudgets_DoubleClick(object sender, EventArgs e)
        {
            //controler.displayClickedBudget(lstBudgets, txtBudgetName, cboDivisions);
            txtBudgetName.Text = controler.getSelectedBudget().name;
            cboDivisions.SelectedItem = controler.getSelectedBudget().division.ToString(); //ne fonctionne pas
            txtBudgetName.Focus();
            controler.handleEditionMode(modeEdition: true);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            controler.updateBudget(txtBudgetName.Text, cboDivisions.SelectedItem.ToString());
            updateListBox(Const.BUDGET, controler.getSelectedBudget().ToString());
            updateListBox(Const.ACCOUNT, controler.getSelectedAccount().ToString());
            //controler.updateAccountDislay(controler.getSelectedAccount(lstAccounts), lstAccounts);
            refreshTotals();
            controler.handleEditionMode(modeEdition: false);
            resetBudget(txtBudgetName);
        }

        private void lstBudgets_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int index = getSelectedIndex();
                if (controler.deleteBudget(index))
                {
                    lstBudgets.Items.RemoveAt(index);
                    lstAccounts.Items.RemoveAt(index);

                    txtBudgetName.Focus();
                }
            }
        }

        private void btnResetBudget_Click(object sender, EventArgs e)
        {
            controler.resetAllBudgets();
            lstBudgets.Items.Clear();
            lstAccounts.Items.Clear();
            controler.saveData();
        }

        /// <summary>
        /// Ajoute au fichier correspondant une sauvegarde des données entrées dans l'application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloture_Click(object sender, EventArgs e)
        {
            controler.finalizeMonthDialogs(controler.monthNumber(cboMonth.SelectedIndex), int.Parse(cboYear.Text));
        }
    }
}
