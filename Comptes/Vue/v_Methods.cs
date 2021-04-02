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

namespace Comptes
{

    // Contient les fonctions non-évènementielles.

    public partial class frmMain : Form
    {


        public void loadDivisions(ComboBox comboBox)
        {
            foreach (KeyValuePair<string, double> pair in controler.getDivisions())
            {
                comboBox.Items.Add(pair.Key);
            }
            comboBox.SelectedIndex = 0;
        }

        public void loadCboMonth(ComboBox cboMonth)
        {   
            var DateTimeFormatInfo = CultureInfo.GetCultureInfo("fr-FR").DateTimeFormat;

            for (int k = 1; k <= 12; k++)
            {
                cboMonth.Items.Add(DateTimeFormatInfo.CurrentInfo.GetMonthName(k));
            }


        }

        public void selectCurrentMonth(ComboBox cboMonth)
        {
            DateTime date = DateTime.Now;

            if (date.Month != 1)
            {
                cboMonth.SelectedIndex = date.Month - 2;
            }
            else
            {
                cboMonth.SelectedIndex = Const.DECEMBER;
            }
        }

        public void loadThreeYears(ComboBox cboYear)
        {
            DateTime date = DateTime.Now;
            for (int year = date.Year - 1; year < (date.Year + 2); year++)
            {
                cboYear.Items.Add(year);
            }
            cboYear.SelectedIndex = 1;
        }

        /// <summary>
        /// Charge les années déjà sauvegardées dans un combo.
        /// </summary>
        /// <param name="cboYear"></param>
        public void loadExistingYears(ComboBox cboYear)
        {
            List<int> lstExistingYears = controler.getExistingYears();
            foreach (int year in lstExistingYears)
            {
                cboYear.Items.Add(year);
            }
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

        public void refreshCboDivisions()
        {
            cboDivisions.Items.Clear();
            loadDivisions(cboDivisions);
        }

        public void addToLstAccount(string list, string item) {

            ListBox listBox = lstBudgets;
            switch (list)
            {
                case Const.ACCOUNT: listBox = lstAccounts; break;
                case Const.BUDGET: listBox = lstBudgets; break;
            }

            listBox.Items.Add(item);
        }

        /// <summary>
        /// Modifie un élément de la liste.
        /// </summary>
        /// <param name="list">Liste à ajouter. Utiliser les constantes BUDGET ou ACCOUNT.</param>
        /// <param name="item">Element à ajouter</param>
        /// <param name="index">Index auquel l'ajouter. S'il n'est pas spécifié, ajoute à l'index sélectionné.</param>
        public void updateListBox(string list, string item, int index = -1)
        {
            ListBox listBox = lstBudgets;
            switch (list)
            {
                case Const.ACCOUNT: listBox = lstAccounts; break;
                case Const.BUDGET: listBox = lstBudgets; break;
            }

            if (index != -1)
            {
                listBox.Items[index] = item;
            }
            else
            {
                listBox.Items[lstBudgets.SelectedIndex] = item;
            }
        }

        /// <summary>
        /// Réinitialise la cellule et le focus après la validation d'un bouton.
        /// </summary>
        public void resetBudget(TextBox txtBudgetName)
        {
            txtBudgetName.Text = "";
            txtBudgetName.Focus();
        }

        public void switchMode(bool modeEdition)
        {
            btnOKBudgets.Visible = !modeEdition;
            btnEdit.Visible = modeEdition;
        }

        public int getSelectedIndex()
        {
            return lstBudgets.SelectedIndex;
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
        public void resetAccountBox()
        {
            txtAmountUserA.Focus();
            txtAmountUserA.Text = "";
            txtAmountUserB.Text = "";
        }

        public void setUsersTextBox(string nameUserA, string nameUserB)
        {
            txtUserA.Text = nameUserA;
            txtUserB.Text = nameUserB;
        }

        public void setDefaultName() //TODO A AMELIORER
        {
            lblUserA.Text = Const.DEFAULT_NAME_USER_A + ":";
            lblUserB.Text = Const.DEFAULT_NAME_USER_B + ":";
            lblNomTotalUserA.Text = $"Total dettes {Const.DEFAULT_NAME_USER_A} :";
            lblNomTotalUserB.Text = $"Total dettes {Const.DEFAULT_NAME_USER_B} :";
        }

        public void fillLists(string budget, string account)
        {
            lstBudgets.Items.Add(budget);
            lstAccounts.Items.Add(account);
        }

        public void resetView()
        {
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }

                else if (control is GroupBox)
                {
                    GroupBox groupbox = (GroupBox)control;
                    foreach (System.Windows.Forms.Control subcontrol in groupbox.Controls)
                    {
                        if (subcontrol is TextBox)
                        {
                            ((TextBox)subcontrol).Text = string.Empty;
                        }
                    }
                }
            }
            lstBudgets.Items.Clear();
            lstAccounts.Items.Clear();
            btnOKAccount.Enabled = false;
        }

        public void addDivision(string division)
        {
            cboDivisions.Items.Add(division);
        }
    }
}
