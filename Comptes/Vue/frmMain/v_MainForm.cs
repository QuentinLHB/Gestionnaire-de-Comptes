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
        BindingList<Budget> bdgBudgets;
        BindingList<Account> bdgAccounts;

        public frmMain(Controler controler) 
        { 
            this.controler = controler;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initBindings();
            displayUsersNames();
            loadDivisions(cboDivisions);
            refreshTotals();
            accessAddAccount();
        }

        private void initBindings()
        {
            bdgBudgets = new BindingList<Budget>(controler.getAllBudgets());
            lstBudgets.DataSource = bdgBudgets;

            bdgAccounts = new BindingList<Account>(controler.getAllAccounts());
            lstAccounts.DataSource = bdgAccounts;

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
            controler.updateAccount((Account)lstAccounts.SelectedItem, txtAmountUserA.Text, txtAmountUserB.Text);
            refreshAccountList();
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
                controler.emptyAccountData((Account)lstAccounts.SelectedItem);
                refreshAccountList();
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
            double[] usersExpenses = controler.getUsersExpenses((Account)lstAccounts.SelectedItem);
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
            emptyAllAccounts();
            refreshAccountList();
            accessAddAccount();
            refreshTotals();
        }

        private void btnOKBudgets_Click(object sender, EventArgs e)
        {
            controler.addBudget(txtBudgetName.Text, cboDivisions.SelectedItem.ToString());
            refreshLists();
            lstAccounts.SelectedIndex = 0;
            resetBudget(txtBudgetName);
            accessAddAccount();
            controler.setFlagChange(change: true);
        }

        private void lstBudgets_DoubleClick(object sender, EventArgs e)
        {
            Budget selectedBudget = (Budget)lstBudgets.SelectedItem;
            txtBudgetName.Text = selectedBudget.name;
            cboDivisions.SelectedItem = selectedBudget.division.ToString(); //ne fonctionne pas
            txtBudgetName.Focus();
            controler.handleEditionMode(modeEdition: true);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {            
            controler.updateBudget((Budget)lstBudgets.SelectedItem, txtBudgetName.Text, cboDivisions.SelectedItem.ToString());
            refreshLists();
            refreshTotals();
            controler.handleEditionMode(modeEdition: false);
            resetBudget(txtBudgetName);
        }

        /// <summary>
        /// Supprime le supprime le budget sélectionné après validation de l'utilisateur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstBudgets_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show(Const.MSG_DELETEBUDGET, Const.MSG_TITLE_DELETE, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Budget selectedBudget = (Budget)lstBudgets.SelectedItem;
                    controler.deleteBudget(selectedBudget);
                    refreshLists();
                    accessAddAccount();
                    refreshTotals();
                    txtBudgetName.Focus();
                }
            }
        }

        /// <summary>
        /// Supprime tous les budgets.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetBudget_Click(object sender, EventArgs e)
        {
            controler.resetAllBudgets();
            refreshLists();
            controler.saveData();
        }

        /// <summary>
        /// Ajoute au fichier correspondant une sauvegarde des données entrées dans l'application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloture_Click(object sender, EventArgs e)
        {
            controler.finalizeMonthDialogs(controler.formatDate(dtpMonth.Value.Date));
        }


    }
}
