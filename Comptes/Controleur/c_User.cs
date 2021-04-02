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


        public void setFlagUserChange(bool change)
        {
            flagUserNameChange = change;
        }

        /// <summary>
        /// Modifie le nom de l'utilisateur dans tous les emplacements appropriés.
        /// </summary>
        /// <param name="user">Utilisateur concerne (A/B)</param>
        /// <param name="txtUser">Textbox concernée</param>
        /// <param name="lblUser">Label de la rubrique Compte concerné.</param>
        /// <param name="lblNomTotalUser">Label de la rubrique Total concerné.</param>
        /// <param name="nomDefaut">Nom par défaut à afficher si saisie nulle</param>
        public void updateNomPers(int userIndex, TextBox txtUser, Label lblUser, Label lblNomTotalUser, string nomDefaut)
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

        /// <summary>
        /// Envoie au modèle les informations de l'utilisateur pour mise à jour.
        /// </summary>
        /// <param name="userIndex">Index de l'utilisateur (constante utilisateur A ou B.)</param>
        /// <param name="name"></param>
        public void setUserName(int userIndex, string name)
        {
            User.setName(userIndex, name);
        }

        /// <summary>
        /// Récupère l'affichage du nom.
        /// </summary>
        /// <param name="userIndex">Index de l'utilisateur (constante utilisateur A ou B.)</param>
        /// <returns>Affichage du nom.</returns>
        public string getUserNameDisplay(int userIndex)
        {
            return User.displayName(userIndex);
        }

        /// <summary>
        /// Récupère l'affichage des dettes.
        /// </summary>
        /// <param name="userIndex">Index de l'utilisateur (constante utilisateur A ou B.)</param>
        /// <returns></returns>
        public string getUserDebtsDisplay(int userIndex)
        {
            return User.displayDebts(userIndex);
        }

        /// <summary>
        /// Rafraichit la liste des compte pour afficher le nouveau nom d'utilisateur.
        /// </summary>
        public void updateLstComptes(ListBox lstAccounts)
        {
            if (flagUserNameChange)
            {
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
