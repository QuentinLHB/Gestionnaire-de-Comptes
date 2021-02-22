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

        private void changementUser(bool changement)
        {
            flagChangementNomUser = changement;
        }

        private void txtUserA_TextChanged(object sender, EventArgs e)
        {
            updateNomPers(data.lesUsers[Constantes.USER_A], txtUserA, lblUserA, lblNomTotalUserA, Constantes.NOM_DEFAUT_USER_A);

        }

        private void txtUserB_TextChanged(object sender, EventArgs e)
        {
            updateNomPers(data.lesUsers[Constantes.USER_B], txtUserB, lblUserB, lblNomTotalUserB, Constantes.NOM_DEFAUT_USER_B);
        }

        /// <summary>
        /// Modifie le nom de l'utilisateur dans tous les emplacements appropriés.
        /// </summary>
        /// <param name="user">Utilisateur concerne (A/B)</param>
        /// <param name="txtUser">Textbox concernée</param>
        /// <param name="lblUser">Label de la rubrique Compte concerné.</param>
        /// <param name="lblNomTotalUser">Label de la rubrique Total concerné.</param>
        /// <param name="nomDefaut">Nom par défaut à afficher si saisie nulle</param>
        private void updateNomPers(User user, TextBox txtUser, Label lblUser, Label lblNomTotalUser, string nomDefaut)
        {
            if (txtUser.Text != string.Empty)
            {
                user.nom = txtUser.Text;
            }

            else
            {
                user.nom = nomDefaut;
            }

            lblUser.Text = user.afficheNom();
            lblNomTotalUser.Text = ($"Total dettes {user.nom} :");
            flagChangementNomUser = true;
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
            if (flagChangementNomUser)
            {
                int k = 0;
                foreach (Budget budget in data.lesBudgets)
                {
                    budget.compte.userA.nom = txtUserA.Text;
                    budget.compte.userB.nom = txtUserB.Text;
                    lstComptes.Items[k++] = budget.compte;
                }
                flagChangement(changement: true);
            }
            flagChangementNomUser = false;
        }
    }
}
