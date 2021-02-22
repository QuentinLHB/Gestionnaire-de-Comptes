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
        /// <summary>
        /// Ajoute les dettes de chacune des personnes dans la liste des comptes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOKComptes_Click(object sender, EventArgs e)
        {
            Compte compte = GetCompteSelectionne();

            verifieSiVide();
            affichageDesDepenses(compte);
            updateTotaux();
            updateResultat();

            try { lstBudgets.SelectedIndex++; }
            catch { }
            resetMenuCompte();
            flagChangement(changement: true);

        }

        /// <summary>
        /// Gère les textBox des montants si elles sont vides.
        /// </summary>
        private void verifieSiVide()
        {
            if (txtMontantUserA.Text.Equals(""))
            {
                txtMontantUserA.Text = "0";
            }

            if (txtMontantUserB.Text.Equals(""))
            {
                txtMontantUserB.Text = "0";
            }
        }

        /// <summary>
        /// Affiche les dépenses entrées dans la listBox des Comptes.
        /// </summary>
        /// <param name="compte"></param>
        private void affichageDesDepenses(Compte compte)
        {
            try
            {
                compte.userA.depenses = Eval(txtMontantUserA.Text);
                compte.userB.depenses = Eval(txtMontantUserB.Text);
            }

            catch
            {
                MessageBox.Show(Constantes.MSG_ERR_SAISIE, Constantes.MSG_TITRE_ERR_SAISIE, MessageBoxButtons.OK);
            }

            updateAffichageComptes(compte);
        }

        /// <summary>
        /// Met à jour l'affichage du compte sélectionné dans la liste.
        /// </summary>
        /// <param name="compte"></param>
        private void updateAffichageComptes(Compte compte)
        {
            lstComptes.Items[lstComptes.SelectedIndex] = compte;

        }


        private void lstComptes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                videCompte(lstComptes.SelectedIndex);
                updateTotaux();
                updateResultat();
            }
        }

        /// <summary>
        /// Réinitialise l'affichage par défaut d'un item spécifié de la liste des comptes.
        /// </summary>
        /// <param name="index">Index de la liste des comptes.</param>
        private void videCompte(int index)
        {
            GetCompteSelectionne().reset();
            lstComptes.Items[index] = data.lesBudgets[index].nom + " :";
        }

        private void lstComptes_DoubleClick(object sender, EventArgs e)
        {
            Compte compte = GetCompteSelectionne();
            txtMontantUserA.Text = compte.userA.depenses.ToString();
            txtMontantUserB.Text = compte.userB.depenses.ToString();
            txtMontantUserA.Focus();
        }

        /// <summary>
        /// Si la liste des budgets est vide, désactive le bouton Valider de la zone comptes.
        /// </summary>
        private void accesAjoutCompte()
        {
            if (lstBudgets.Items.Count != 0)
            {
                btnOKComptes.Enabled = true;
                lstBudgets.SelectedIndex = 0;
            }

            else
            {
                btnOKComptes.Enabled = false;
            }
        }

        private Compte GetCompteSelectionne()
        {
            return data.lesBudgets[lstComptes.SelectedIndex].compte;
        }

        private void btnResetComptes_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < data.lesBudgets.Count; k++)
            {
                lstComptes.SelectedIndex = k;
                videCompte(k);
            }
            accesAjoutCompte();
            updateTotaux();
            updateResultat();
        }
    }
}
