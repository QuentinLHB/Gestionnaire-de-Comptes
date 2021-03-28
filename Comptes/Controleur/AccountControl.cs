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
using Comptes.Constants;


namespace Comptes.Control
{
    public partial class Controler
    {


        /// <summary>
        ///  Calcule les dépenses des utilisateurs.
        /// </summary>
        /// <param name="compte">Compte concerné.</param>
        /// <param name="amountUserA">Montant de l'utilisateur A.</param>
        /// <param name="amountUserB">Montant de l'utilisateur B.</param>
        public void calculateExpenses(Account compte, string amountUserA, string amountUserB)
        {
            try
            {
                compte.userA.expenses = Eval(amountUserA);
                compte.userB.expenses = Eval(amountUserB);
            }

            catch
            {
                MessageBox.Show(Const.MSG_ERR_WRONGINPUT, Const.MSG_TITRE_ERR_WRONGINPUT, MessageBoxButtons.OK);
            }
        }

        ///// <summary>
        ///// Met à jour l'affichage du compte sélectionné dans la liste.
        ///// </summary>
        ///// <param name="account"></param>
        //public void updateAccountDislay(Account account, ListBox lstAccounts)
        //{
        //    lstAccounts.Items[frmMain.Sele] = account;
        //}

        /// <summary>
        /// Réinitialise l'affichage par défaut d'un item spécifié de la liste des comptes.
        /// </summary>
        /// <param name="index">Index de la liste des comptes.</param>
        public void emptyAccountData(int index)
        {
            getSelectedAccount().reset();
            frmMain.updateListBox(Const.ACCOUNT, data.allBudgets[index].displayBudgetName(), index);
        }

        /// <summary>
        /// Récupère les dépenses des deux utilisateurs
        /// </summary>
        /// <returns>Une liste de deux doubles des dépenses utilisateurs.</returns>
        public double[] getUsersExpenses()
        {
            Account account = getSelectedAccount();            
            double[] usersExpenses = { account.userA.expenses, account.userB.expenses };
            return usersExpenses;            
        }

        /// <summary>
        /// Retourne le compte lié à l'item sélectionné dans la liste.
        /// </summary>
        /// <param name="lstAccounts">La liste des comptes.</param>
        /// <returns></returns>
        public Account getSelectedAccount()
        {
            return data.allBudgets[frmMain.getSelectedIndex()].account;
        }
    }
}
