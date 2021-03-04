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
        /// <summary>
        /// Ajoute les dettes de chacune des personnes dans la liste des comptes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOKComptes_Click(object sender, EventArgs e)
        {
            Account account = getSelectedAccount();

            checkIfEmpty();
            displayExpenses(account);
            updateTotals();

            try { lstBudgets.SelectedIndex++; }
            catch { }
            resetAccountBox();
            setFlagChange(change: true);

        }

        /// <summary>
        /// Gère les textBox des montants si elles sont vides.
        /// </summary>
        private void checkIfEmpty()
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
        /// Affiche les dépenses entrées dans la listBox des Comptes.
        /// </summary>
        /// <param name="compte"></param>
        private void displayExpenses(Account compte)
        {
            try
            {
                compte.userA.expenses = Eval(txtAmountUserA.Text);
                compte.userB.expenses = Eval(txtAmountUserB.Text);
            }

            catch
            {
                MessageBox.Show(Const.MSG_ERR_WRONGINPUT, Const.MSG_TITRE_ERR_WRONGINPUT, MessageBoxButtons.OK);
            }

            updateAccountDislay(compte);
        }

        /// <summary>
        /// Met à jour l'affichage du compte sélectionné dans la liste.
        /// </summary>
        /// <param name="account"></param>
        private void updateAccountDislay(Account account)
        {
            lstAccounts.Items[lstAccounts.SelectedIndex] = account;

        }


        private void lstComptes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                emptyAccountData(lstAccounts.SelectedIndex);
                updateTotals();
            }
        }

        /// <summary>
        /// Réinitialise l'affichage par défaut d'un item spécifié de la liste des comptes.
        /// </summary>
        /// <param name="index">Index de la liste des comptes.</param>
        private void emptyAccountData(int index)
        {
            getSelectedAccount().reset();
            lstAccounts.Items[index] = data.allBudgets[index].name + " :";
        }

        private void lstComptes_DoubleClick(object sender, EventArgs e)
        {
            Account account = getSelectedAccount();
            txtAmountUserA.Text = account.userA.expenses.ToString();
            txtAmountUserB.Text = account.userB.expenses.ToString();
            txtAmountUserA.Focus();
        }

        /// <summary>
        /// Si la liste des budgets est vide, désactive le bouton Valider de la zone comptes.
        /// </summary>
        private void accessAddAccount()
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

        private Account getSelectedAccount()
        {
            return data.allBudgets[lstAccounts.SelectedIndex].account;
        }

        private void btnResetAccounts_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < data.allBudgets.Count; k++)
            {
                lstAccounts.SelectedIndex = k;
                emptyAccountData(k);
            }
            accessAddAccount();
            updateTotals();
        }
    }
}
