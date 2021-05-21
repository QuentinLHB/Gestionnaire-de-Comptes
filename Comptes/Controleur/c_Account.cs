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
        ///  Calcule les dépenses des utilisateurs et met à jour l'objet.
        /// </summary>
        /// <param name="acccount">Compte concerné.</param>
        /// <param name="amountUserA">Montant de l'utilisateur A.</param>
        /// <param name="amountUserB">Montant de l'utilisateur B.</param>
        public void updateAccount(Account acccount, string amountUserA, string amountUserB)
        {
            try
            {
                acccount.userA.expenses = Eval(amountUserA);
                acccount.userB.expenses = Eval(amountUserB);
            }

            catch
            {
                MessageBox.Show(Const.MSG_ERR_WRONGINPUT, Const.MSG_TITRE_ERR_WRONGINPUT, MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Supprime les données d'un compte.
        /// </summary>
        /// <param name="account">Compte concerné.</param>
        public void emptyAccountData(Account account)
        {
            account.reset();
        }

        public void resetAllAccounts()
        {
            data.allAccounts.Clear();
        }

        /// <summary>
        /// Récupère les dépenses des deux utilisateurs
        /// </summary>
        /// <returns>Une liste de deux doubles des dépenses utilisateurs.</returns>
        public double[] getUsersExpenses(Account account)
        {           
            double[] usersExpenses = { account.userA.expenses, account.userB.expenses };
            return usersExpenses;            
        }

    }
}
