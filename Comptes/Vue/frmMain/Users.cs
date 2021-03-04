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

        private void setFlagUserChange(bool change)
        {
            flagUserNameChange = change;
        }

        private void txtUserA_TextChanged(object sender, EventArgs e)
        {
            updateNomPers(Const.USER_A, txtUserA, lblUserA, lblNomTotalUserA, Const.DEFAULT_NAME_USER_A);

        }

        private void txtUserB_TextChanged(object sender, EventArgs e)
        {
            updateNomPers(Const.USER_B, txtUserB, lblUserB, lblNomTotalUserB, Const.DEFAULT_NAME_USER_B);
        }

        /// <summary>
        /// Modifie le nom de l'utilisateur dans tous les emplacements appropriés.
        /// </summary>
        /// <param name="user">Utilisateur concerne (A/B)</param>
        /// <param name="txtUser">Textbox concernée</param>
        /// <param name="lblUser">Label de la rubrique Compte concerné.</param>
        /// <param name="lblNomTotalUser">Label de la rubrique Total concerné.</param>
        /// <param name="nomDefaut">Nom par défaut à afficher si saisie nulle</param>
        private void updateNomPers(int userIndex, TextBox txtUser, Label lblUser, Label lblNomTotalUser, string nomDefaut)
        {
            if (txtUser.Text != string.Empty)
            {
                User.setName(userIndex, txtUser.Text);
            }

            else
            {
                User.setName(userIndex, nomDefaut);
            }

            lblUser.Text = User.displayName(userIndex);
            lblNomTotalUser.Text = User.displayDebts(userIndex);
            setFlagUserChange(change: true);
        }

        private void txtUserA_Leave(object sender, EventArgs e)
        {
            updateLstComptes();
        }

        private void txtUserB_Leave(object sender, EventArgs e)
        {
            updateLstComptes();
        }

        /// <summary>
        /// Rafraichit la liste des compte pour afficher le nouveau nom d'utilisateur.
        /// </summary>
        private void updateLstComptes()
        {
            if (flagUserNameChange)
            {
                //int k = 0;
                //foreach (Budget budget in data.allBudgets)
                //{
                //    lstAccounts.Items[k++] = budget.account;
                //}

                for (int i = 0; i < data.allBudgets.Count; i++)
                {
                    lstAccounts.Items[i] = data.allBudgets[i].account;
                }
                setFlagChange(change: true);
            }
            setFlagUserChange(change: false);
        }
    }
}
