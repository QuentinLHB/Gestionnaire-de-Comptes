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
        /// Met à jour les totaux de dettes
        /// </summary>
        /// <param name="compte"></param>
        private void updateTotaux()
        {
            double totalDettesPersA = 0;
            double totalDettesPersB = 0;
            foreach (Budget budget in data.lesBudgets)
            {
                totalDettesPersA += budget.compte.userB.depenses * budget.repartition;
                totalDettesPersB += budget.compte.userA.depenses * (1 - budget.repartition);
            }

            data.lesUsers[Constantes.USER_A].dettes = totalDettesPersA;
            data.lesUsers[Constantes.USER_B].dettes = totalDettesPersB;
            lblTotalPersA.Text = data.lesUsers[Constantes.USER_A].dettes.ToString();
            lblTotalPersB.Text = data.lesUsers[Constantes.USER_B].dettes.ToString();

        }

        /// <summary>
        /// Met à jour le grand total
        /// </summary>
        private void updateResultat()
        {
            double resultat = data.lesUsers[Constantes.USER_A].dettes - data.lesUsers[Constantes.USER_B].dettes;


            if (resultat > 0)
            {
                affichageResultat(data.lesUsers[Constantes.USER_A].nom, resultat);
            }

            else if (resultat < 0)
            {
                affichageResultat(data.lesUsers[Constantes.USER_B].nom, -resultat);
            }

            else
            {
                lblResultat.Text = Constantes.EQUILIBRE;
            }
        }

        private void affichageResultat(string nom, double resultat)
        {
            lblResultat.Text = ($"{nom} doit {resultat}.");
        }

        /// <summary>
        /// Ajoute au fichier correspondant une sauvegarde des données entrées dans l'application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloture_Click(object sender, EventArgs e)
        {
            // S'il n'y a pas de budget
            if (data.lesBudgets.Count != 0) 
            {

                if ((MessageBox.Show(Constantes.MSG_VALIDATIONSAUVEGARDEMENSUELLE, Constantes.MSG_TITRE_VALIDATIONSAUVEGARDEMENSUELLE, MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    List<SaveMensuelle> lesSaves = (List<SaveMensuelle>)Serialise.Recup(Constantes.FICHIER_SAVEMENSUELLE);
                    if (lesSaves == null)
                    {
                        lesSaves = new List<SaveMensuelle>();
                    }

                    SaveMensuelle saveExistante = verifieSiExisteDeja(lesSaves);
                    if (saveExistante == null)
                    {
                        sauvegarderMois(lesSaves);
                    }

                    else //Si une save existte
                    {
                        // Si souhaite écraser
                        if (MessageBox.Show(Constantes.MSG_ECRASEMENT, Constantes.ERREUR, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            lesSaves.Remove(saveExistante);
                           sauvegarderMois(lesSaves);
                            MessageBox.Show(Constantes.MSG_ECRASEMENT_YES, Constantes.MSG_TITRE_ECRASEMENT, MessageBoxButtons.OK);
                        }

                        // Si ne souhaite pas écraser
                        else
                        {
                            MessageBox.Show(Constantes.MSG_ECRASEMENT_NO, Constantes.MSG_TITRE_ECRASEMENT, MessageBoxButtons.OK);
                        }
                    }

                }
            }

            else
            {
                MessageBox.Show(Constantes.MSG_ERR_CLOTURE, Constantes.ERREUR, MessageBoxButtons.OK);
            }

        }

        //public void 

        private void sauvegarderMois(List<SaveMensuelle> lesSaves)
        {
            SaveMensuelle saveMois = new SaveMensuelle(
                mois: cboMois.SelectedItem.ToString(),
                annee: cboAnnee.SelectedItem.ToString(),
                lesBudgets: data.lesBudgets,
                lesUsers: data.lesUsers);

            lesSaves.Add(saveMois);
            Serialise.Sauve(Constantes.FICHIER_SAVEMENSUELLE, lesSaves);

            btnResetComptes_Click(null, null);
        }

        private SaveMensuelle verifieSiExisteDeja(List<SaveMensuelle> lesSaves)
        {
            SaveMensuelle saveExistante = null;
            foreach (SaveMensuelle save in lesSaves)
            {
                if (save.mois == cboMois.Text & save.annee == cboAnnee.Text)
                {
                    saveExistante = save;
                    break;
                }

            }
            return saveExistante;
        }
    }
}
