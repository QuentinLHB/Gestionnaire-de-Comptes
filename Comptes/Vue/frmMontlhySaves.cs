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
    public partial class FenMonthlySave : Form
    {

        frmMain frmMain;
        List<DataMonthlyReport> dataTab;
        List<MonthlySave> allMonthlySaves;
        Controler controler;



        // ____________________________ CHARGEMENT & UTILITAIRES _______________________
        /// <summary>
        /// Récupère les sauvegardes mensuelles et initialise le formulaire.
        /// </summary>
        /// <param name="allMonthlySaves">Liste des sauvegardes mensuelles enregistrées.</param>
        public FenMonthlySave(frmMain frmMain, Controler controler)
        {           
            InitializeComponent();
            this.frmMain = frmMain;
            this.controler = controler;
            allMonthlySaves = (List<MonthlySave>)Serialise.Load(Const.FILE_MONTHLYRECAP);
            this.allMonthlySaves = allMonthlySaves;
            this.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmMain.loadExistingYears(cboYear);
            cboYear.SelectedIndex = 0;
            frmMain.loadCboMonth(cboMonth);
            frmMain.selectCurrentMonth(cboMonth);
            btnDelMonthlyReport.Enabled = false;
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            controler.dragWindow(this, e);
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            controler.focusMenuStrip((MenuStrip)sender);
        }
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
            MonthlySave monthlySave = MonthlySave.findMonthlySave(allMonthlySaves, controler.monthNumber(cboMonth.SelectedIndex), int.Parse(cboYear.Text));

            if (monthlySave != null)
            {
                loadGrid(monthlySave);
                grdBudgets.Show();
                btnDelMonthlyReport.Enabled = true;
            }

            else
            {
                MessageBox.Show($"{Const.MSG_ERR_WRONGSELECTION}\n{cboMonth.SelectedItem} {cboYear.SelectedItem}", Const.ERROR, MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Peuple la grille avec les données de la sauvegarde choisie.
        /// </summary>
        /// <param name="saveMensuelle">Sauvegarde à afficher.</param>
        private void loadGrid(MonthlySave saveMensuelle)
        {
            var tableauMensuel = new List<DataMonthlyReport>();
            foreach (Budget budget in saveMensuelle.allBudgets)
            {
                tableauMensuel.Add(new DataMonthlyReport(
                   accountName: budget.name,
                   expensesA: budget.account.userA.expenses,
                   expensesB: budget.account.userB.expenses));
            }


            //var data = tableauMensuel;
            grdBudgets.DataSource = tableauMensuel;

            grdBudgets.Columns[1].HeaderText = Const.EXPENSES(DataMonthlyReport.nameUserA);
            grdBudgets.Columns[2].HeaderText = Const.EXPENSES(DataMonthlyReport.nameUserB);

            grdBudgets.Visible = true;

        }

        private void btnDelMonthlyReport_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(Const.MSG_DELETEMONTLYSAVE, Const.MSG_TITLE_DELETE, MessageBoxButtons.YesNo) == DialogResult.Yes))
            {

                MonthlySave monthlySave = MonthlySave.findMonthlySave(allMonthlySaves, controler.monthNumber(cboMonth.SelectedIndex), int.Parse(cboYear.Text));
                allMonthlySaves.Remove(monthlySave);
                Serialise.Save(Const.FILE_MONTHLYRECAP, allMonthlySaves);
                grdBudgets.Visible = false;
                btnDelMonthlyReport.Enabled = false;
            }
        }

        //public void addToCboYear(string year)
        //{
        //    cboYear.Items.Add(year);
        //}
    }
}
