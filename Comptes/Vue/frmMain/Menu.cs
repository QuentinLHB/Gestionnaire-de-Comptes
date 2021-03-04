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
        private void menuEditDivisions_Click(object sender, EventArgs e)
        {
            FrmDivisions frmDivisions = new FrmDivisions(data, this);

            frmDivisions.ShowDialog();
        }

        public void addDivision(string division)
        {
            cboDivisions.Items.Add(division);
            setFlagChange(change: true);
        }


        private void menuSave_Click(object sender, EventArgs e)
        {
            saveData();
        }

        /// <summary>
        /// Sauvegarde les données affichées par sérialisation.
        /// </summary>
        private void saveData()
        {
            try
            {
                data.storeUserData();
                Serialise.Save(Const.FILE_DATA, data);
            }
            catch
            {
                MessageBox.Show(Const.MSG_ERR_SAVE, Const.MSG_TITRE_ERR_SAVE, MessageBoxButtons.OK);
            }
            setFlagChange(change: false);
        }


        /// <summary>
        /// Reinitialise les données de l'application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuResetApp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Const.MSG_RESET, Const.MSG_TITLE_RESET, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (File.Exists(Const.FILE_MONTHLYRECAP))
                {
                    File.Delete(Const.FILE_MONTHLYRECAP);
                }
                resetView();

                MessageBox.Show(Const.MSG_RESETOK, Const.MSG_TITLE_RESET, MessageBoxButtons.OK);
                setFlagChange(change: true);
            }

        }

        /// <summary>
        /// Reinitialise le fichier data et les contrôles de l'application.
        /// </summary>
        private void resetView()
        {
            if (File.Exists(Const.FILE_DATA))
            {
                File.Delete(Const.FILE_DATA);
            }

            data.resetData();
            refreshCboDivisions();

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
            lstAccounts.Items.Clear();
            btnOKAccount.Enabled = false;
            updateTotals();
        }

        private void menuMonthlySaves_Click(object sender, EventArgs e)
        {
            List<MonthlySave> allSaves = (List<MonthlySave>)Serialise.Load(Const.FILE_MONTHLYRECAP);

            if (allSaves != null && allSaves.Count != 0)
            {
                new FenSummary(allSaves);
            }
            else
            {
                MessageBox.Show(Const.MSG_ERR_NO_MONTHLYSAVE, Const.MSG_TITLE_ERR_NOSAVE, MessageBoxButtons.OK);
            }
        }

        private void menuResetDisplay_Click(object sender, EventArgs e)
        {
            resetView();
        }
    }
}
