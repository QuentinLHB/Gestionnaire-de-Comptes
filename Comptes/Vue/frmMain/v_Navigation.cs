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
            if (controler.saveNotNullOrEmpty())
            {
                new FrmMonthlySave(this, controler);
            }

            else
            {
                MessageBox.Show(Const.MSG_ERR_NO_MONTHLYSAVE, Const.MSG_TITLE_ERR_NOSAVE, MessageBoxButtons.OK);
            }
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
            if (controler.saveNotNullOrEmpty())
            {
                new frmAnalysis(this, controler);
            }

            else
            {
                MessageBox.Show(Const.MSG_ERR_NO_MONTHLYSAVE, Const.MSG_TITLE_ERR_NOSAVE, MessageBoxButtons.OK);
            }
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

        private void menuRenameUsers_Click(object sender, EventArgs e)
        {
            controler.loadUsersNamesForm();
            displayUsersNames();
        }
    }
}
