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

    // Contient les évènements secondaires : Gestion du menu strip, des utilisateurs, de navigation.

    public partial class frmMain : Form
    {
        private void menuEditDivisions_Click(object sender, EventArgs e)
        {
            FrmDivisions frmDivisions = new FrmDivisions(this, controler);

            frmDivisions.ShowDialog();
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            controler.saveData();
        }

        /// <summary>
        /// Reinitialise les données de l'application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuResetApp_Click(object sender, EventArgs e)
        {
            controler.fullReset();
            refreshCboDivisions();
        }

        /// <summary>
        /// Ouvre la fenêtre des rapports mensuels.
        /// </summary>
        /// <param name="sender">Menu rapport mensuel.</param>
        /// <param name="e">Clic</param>
        private void menuMonthlySaves_Click(object sender, EventArgs e)
        {
            controler.newMonthlySaveWindow();
        }

        /// <summary>
        /// Réinitialise l'affichage de l'application.
        /// </summary>
        /// <param name="sender">Menu réinitialiser affichage.</param>
        /// <param name="e">Clic</param>
        private void menuResetDisplay_Click(object sender, EventArgs e)
        {
            controler.resetView();
            refreshTotals();
        }

        private void menuAnalysis_Click(object sender, EventArgs e)
        {
            controler.newAnalysisWindow();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            controler.dragWindow(this, e);
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            controler.focusMenuStrip((MenuStrip)sender);
        }

        private void lstBudgets_SelectedIndexChanged(object sender, EventArgs e)
        {
            controler.listBoxIndexLink((ListBox)sender, lstAccounts);
        }

        private void lstComptes_SelectedIndexChanged(object sender, EventArgs e)
        {
            controler.listBoxIndexLink((ListBox)sender, lstBudgets);
        }

        /// <summary>
        /// Propose la sauvegarde du fichier et l'annulation de la fermeture de l'application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmComptes_FormClosing(object sender, FormClosingEventArgs e)
        {
            controler.closingRequest(e);

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserA_TextChanged(object sender, EventArgs e)
        {
            controler.updateNomPers(Const.USER_A, txtUserA, lblUserA, lblNomTotalUserA, Const.DEFAULT_NAME_USER_A);

        }

        private void txtUserB_TextChanged(object sender, EventArgs e)
        {
            controler.updateNomPers(Const.USER_B, txtUserB, lblUserB, lblNomTotalUserB, Const.DEFAULT_NAME_USER_B);
        }

        private void txtUserA_Leave(object sender, EventArgs e)
        {
            controler.updateLstComptes(lstAccounts);
        }

        private void txtUserB_Leave(object sender, EventArgs e)
        {
            controler.updateLstComptes(lstAccounts);
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

                controler.setUserName(userIndex, txtUser.Text);
            }

            else
            {
                controler.setUserName(userIndex, nomDefaut);
            }

            lblUser.Text = controler.getUserNameDisplay(userIndex);
            lblNomTotalUser.Text = controler.getUserDebtsDisplay(userIndex);
            controler.setFlagUserChange(change: true);
        }

    }
}
