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
        private void menuAjouterRepartition_Click(object sender, EventArgs e)
        {
            FrmRepartition frmRepartition = new FrmRepartition(data, this);

            frmRepartition.ShowDialog();
        }

        public void ajouterRepartition(string repartition)
        {
            cboRepartition.Items.Add(repartition);
            flagChangement(changement: true);
        }


        private void menuSauvegarder_Click(object sender, EventArgs e)
        {
            sauvegarderData();
        }

        /// <summary>
        /// Sauvegarde les données affichées par sérialisation.
        /// </summary>
        private void sauvegarderData()
        {
            try
            {
                Serialise.Sauve(Constantes.FICHIER_DATA, data);
            }
            catch
            {
                MessageBox.Show(Constantes.MSG_ERR_SAUVEGARDE, Constantes.MSG_TITRE_ERR_SAUVEGARDE, MessageBoxButtons.OK);
            }
            flagChangement(changement: false);
        }


        /// <summary>
        /// Reinitialise les données de l'application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuReinitialiser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Constantes.MSG_REINITIALISER, Constantes.MSG_TITRE_REINITIALISER, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (File.Exists(Constantes.FICHIER_SAVEMENSUELLE))
                {
                    File.Delete(Constantes.FICHIER_SAVEMENSUELLE);
                }
                reinitialiserAffichage();

                MessageBox.Show(Constantes.MSG_REINITIALISATIONOK, Constantes.MSG_TITRE_REINITIALISER, MessageBoxButtons.OK);
                flagChangement(changement: true);
            }

        }

        /// <summary>
        /// Reinitialise le fichier data et les contrôles de l'application.
        /// </summary>
        private void reinitialiserAffichage()
        {
            if (File.Exists(Constantes.FICHIER_DATA))
            {
                File.Delete(Constantes.FICHIER_DATA);
            }

            data.reinitialiseData();
            refreshCboRepartitions();

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }

                else if (control is GroupBox)
                {
                    GroupBox groupbox = (GroupBox)control;
                    foreach (Control subcontrol in groupbox.Controls)
                    {
                        if (subcontrol is TextBox)
                        {
                            ((TextBox)subcontrol).Text = string.Empty;
                        }
                    }
                }
            }
            lstBudgets.Items.Clear();
            lstComptes.Items.Clear();
            btnOKComptes.Enabled = false;
            updateTotaux();
            updateResultat();
        }

        private void menuSauvegardes_Click(object sender, EventArgs e)
        {
            List<SaveMensuelle> lesSaves = (List<SaveMensuelle>)Serialise.Recup(Constantes.FICHIER_SAVEMENSUELLE);

            if (lesSaves != null)
            {
                FenSauvegardes fenSauvegardes = new FenSauvegardes(lesSaves);
            }
            else
            {
                MessageBox.Show(Constantes.MSG_ERR_PASDESAUVEGARDEMENSUELLE, Constantes.MSG_TITRE_ERR_PASDESAUVEGARDE, MessageBoxButtons.OK);
            }
        }

        private void menuResetAffichage_Click(object sender, EventArgs e)
        {
            reinitialiserAffichage();
        }
    }
}
