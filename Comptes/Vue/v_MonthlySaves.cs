using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Comptes.Model;
using System.Globalization;
using Comptes.Constants;
using Comptes.Control;

namespace Comptes
{
    public partial class FrmMonthlySave : Form
    {

        frmMain frmMain;
        //List<MonthlySave> allMonthlySaves;
        Controler controler;



        // ____________________________ CHARGEMENT & UTILITAIRES _______________________
        /// <summary>
        /// Récupère les sauvegardes mensuelles et initialise le formulaire.
        /// </summary>
        /// <param name="allMonthlySaves">Liste des sauvegardes mensuelles enregistrées.</param>
        public FrmMonthlySave(frmMain frmMain, Controler controler)
        {           
            InitializeComponent();
            this.frmMain = frmMain;
            this.controler = controler;
            //allMonthlySaves = controler.getMonthlySaves();
            dtpMonthlySave.Value = controler.getMaxDate();
            this.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enableButtons(enable: false);
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            controler.dragWindow(this, e);
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            controler.focusMenuStrip((MenuStrip)sender);
        }

        /// <summary>
        /// Quitte le formuaire sur un clic sur le bouton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        //___________________ FONCTIONNALITES ______________________________

        /// <summary>
        /// Récupère la sauvegarde du mois et année indiqués par l'utilisateur et affiche les données.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpMonthlySave.Value;

            if (controler.checkForASave(selectedDate))
            {
                loadGrid(selectedDate);
                grdBudgets.Show();
                enableButtons(true);
            }

            else showDateError();
        }



        private void showDateError()
        {
            MessageBox.Show($"{Const.MSG_ERR_WRONGSELECTION}\n{dtpMonthlySave.Value.ToString("MMMM")} {dtpMonthlySave.Value.Year}", Const.ERROR, MessageBoxButtons.OK);
        }

        /// <summary>
        /// Peuple la grille avec les données de la sauvegarde choisie.
        /// </summary>
        /// <param name="saveMensuelle">Sauvegarde à afficher.</param>
        private void loadGrid(DateTime monthToLoad)
        {
            var dataMonthlySave = controler.dataMonthlySave(monthToLoad);
            grdBudgets.DataSource = dataMonthlySave;

            grdBudgets.Columns[1].HeaderText = Const.EXPENSES(DataMonthlySave.nameUserA);
            grdBudgets.Columns[2].HeaderText = Const.EXPENSES(DataMonthlySave.nameUserB);

            grdBudgets.Visible = true;

        }

        private void btnDelMonthlyReport_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(Const.MSG_DELETEMONTLYSAVE, Const.MSG_TITLE_DELETE, MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                controler.deleteMonthlySave(dtpMonthlySave.Value);
                grdBudgets.Visible = false;
                enableButtons(false);
            }
        }

        private void btnToAnalysis_Click(object sender, EventArgs e)
        {
            new frmAnalysis(frmMain, controler, controler.formatDate(dtpMonthlySave.Value), this);            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (controler.checkForASave(dtpMonthlySave.Value)) controler.loadMontlySave(dtpMonthlySave.Value);
            this.Close();
        }

        private void enableButtons(bool enable)
        {
            btnDelMonthlySave.Enabled = enable;
            btnEditMonthlySave.Enabled = enable;
            btnToAnalysis.Visible = enable;
        }
    }
}
