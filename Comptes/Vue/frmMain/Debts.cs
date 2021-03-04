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
        /// <summary>
        /// Met à jour les totaux de dettes
        /// </summary>
        /// <param name="compte"></param>
        private void updateTotals()
        {
            Budget.calculateDebts(data.allBudgets);

            lblTotalUserA.Text = User.getDebts(Const.USER_A).ToString();
            lblTotalUserB.Text = User.getDebts(Const.USER_B).ToString();


            double result = User.getDebts(Const.USER_A) - User.getDebts(Const.USER_B);


            if (result > 0)
            {
                lblResults.Text = Const.debtDisplay(User.getName(Const.USER_A), result);
            }

            else if (result < 0)
            {
                lblResults.Text = Const.debtDisplay(User.getName(Const.USER_B), -result);
            }

            else
            {
                lblResults.Text = Const.BALANCEDRESULT;
            }
        }

        /// <summary>
        /// Ajoute au fichier correspondant une sauvegarde des données entrées dans l'application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloture_Click(object sender, EventArgs e)
        {
            // S'il n'y a pas de budget
            if (data.allBudgets.Count != 0) 
            {

                if ((MessageBox.Show(Const.MSG_VALIDATIONMONYLYSAVE, Const.MSG_TITLE_VALIDATIONMONYLYSAVE, MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    List<MonthlySave> allMonthlySaves = (List<MonthlySave>)Serialise.Load(Const.FILE_MONTHLYRECAP);
                    if (allMonthlySaves == null)
                    {
                        allMonthlySaves = new List<MonthlySave>();
                    }

                    MonthlySave existingSave = MonthlySave.findMonthlySave(allMonthlySaves, cboMonth.Text, cboYear.Text);
                    if (existingSave == null)
                    {
                        finalizeMonth(allMonthlySaves);
                    }

                    else //Si une save existte
                    {
                        // Si souhaite écraser
                        if (MessageBox.Show(Const.MSG_REPLACE, Const.ERROR, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            allMonthlySaves.Remove(existingSave);
                           finalizeMonth(allMonthlySaves);
                            MessageBox.Show(Const.MSG_REPLACE_YES, Const.MSG_TITLE_REPLACE, MessageBoxButtons.OK);
                        }

                        // Si ne souhaite pas écraser
                        else
                        {
                            MessageBox.Show(Const.MSG_REPLACE_NO, Const.MSG_TITLE_REPLACE, MessageBoxButtons.OK);
                        }
                    }

                }
            }

            else
            {
                MessageBox.Show(Const.MSG_ERR_FINALIZE, Const.ERROR, MessageBoxButtons.OK);
            }

        }

        //public void 

        private void finalizeMonth(List<MonthlySave> allMonthlySaves)
        {
            MonthlySave montlySave = new MonthlySave(
                month: cboMonth.SelectedItem.ToString(),
                year: cboYear.SelectedItem.ToString(),
                allBudgets: data.allBudgets);

            allMonthlySaves.Add(montlySave);
            Serialise.Save(Const.FILE_MONTHLYRECAP, allMonthlySaves);

            btnResetAccounts_Click(null, null);
        }
    }
}
