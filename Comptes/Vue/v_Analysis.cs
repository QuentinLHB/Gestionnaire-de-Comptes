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
using Comptes.Control;
using Comptes.Constants;
using Comptes.Data;

namespace Comptes
{
    public partial class frmAnalysis : Form
    {
        DateTime dateRef;
        Controler controler;

        public frmAnalysis(frmMain frmMain, Controler controler, DateTime dateRef, FrmMonthlySave frmMonthlySave = null)
        {
            InitializeComponent();
            this.controler = controler;
            this.dateRef = dateRef;
            loadComponents();
            if (frmMonthlySave != null)
            {
                frmMonthlySave.Close();
            }
            
            this.ShowDialog();
        }

        private void loadComponents()
        {
            cboAnalysisMode.SelectedIndex = 0;
            dtpDateStart.Value = controler.getMinDate();
            dtpDateEnd.Value = controler.getMaxDate();
            dtpDateRef.Value = dateRef;
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
            this.Close();
        }

        // ______________ FONCTIONNALITES _________________________

        /// <summary>
        /// Change l'affichage en fonction de l'item sélectionné dans le combobox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboAnalysisMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboAnalysisMode.SelectedIndex;
            switch (index)
            {
                case 0: displayComponents_betweenTwoDates(); break;
                case 1: displayComponents_allYear(); break;
                case 2: displayComponents_allTime(); break;
            }
        }

        /// <summary>
        /// Affichage de l'option "Entre deux dates" : DateTimePicker de début et de fin.
        /// </summary>
        private void displayComponents_betweenTwoDates()
        {
            if (dtpYear.Visible) dtpYear.Visible = false;
            if(!panDates.Visible) panDates.Visible = true;
        }

        /// <summary>
        /// Affichage de l'otion "Année" : DateTime n'affichant qu'une année.
        /// </summary>
        private void displayComponents_allYear()
        {
            if (panDates.Visible) panDates.Visible = false;
            if(!dtpYear.Visible) dtpYear.Visible = true;
        }

        /// <summary>
        /// Affichage de l'option "Depuis toujours" : Aucun objet à afficher.
        /// </summary>
        private void displayComponents_allTime()
        {
            if (dtpDateStart.Visible) panDates.Visible = false;
            if (dtpYear.Visible) dtpYear.Visible = false;
        }

        /// <summary>
        /// Affiche la grille en fonction de l'option sélectionnée.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            DataAnalysis.Clear();
            DistinctBudget.Clear();

            MonthlySave saveRef = null;
            if (chkMonthRef.Checked)
            {
                List<MonthlySave> allMonthlySaves = controler.getMonthlySaves();
                saveRef = MonthlySave.findMonthlySave(allMonthlySaves, controler.formatDate(dtpDateRef.Value));
            }
            switch (cboAnalysisMode.SelectedIndex)
            {
                case 0: controler.sortBudgets(controler.formatDate(dtpDateStart.Value), controler.formatDate(dtpDateEnd.Value)); break;
                case 1: controler.sortBudgets(year: dtpYear.Value.Year); break;
                case 2: controler.sortBudgets(); break;
            }
            displayGrid(saveRef);
        }


        /// <summary>
        /// Crée les objets d'affichage pour l'affichage de la grille.
        /// </summary>
        /// <param name="saveRef"></param>
        private void displayGrid(MonthlySave saveRef = null)
        {
            var gridData = new List<DataAnalysis>();
            foreach (DistinctBudget budget in controler.getSortedBudgets())
            {
                gridData.Add(new DataAnalysis(budget, saveRef));
            }            
            DataAnalysis totalRow = new DataAnalysis();
            gridData.Add(totalRow);
            grdBudgets.DataSource = gridData;
            grdBudgets.Visible = true;

            bool isNull = MonthlySave.isNull(saveRef);
            grdBudgets.Columns[2].Visible = !isNull; // mois de ref
            grdBudgets.Columns[4].Visible = !isNull; // Evolution
            grdBudgets.Columns[2].HeaderText = ($"{Const.MONTHLYEXPENSES_HEADER} {dtpDateRef.Value.ToString("MMMM")} {dtpDateRef.Value.ToString("yyyy")}");

            setHoverText();
        }

        /// <summary>
        /// Définit le texte affiché lorsque l'on passe la souris sur les headers des colonnes.
        /// </summary>
        private void setHoverText()
        {
            grdBudgets.Columns[0].ToolTipText = Const.TOOLTIP_BUDGET;
            grdBudgets.Columns[1].ToolTipText = Const.TOOLTIP_EXPENSES ;
            grdBudgets.Columns[2].ToolTipText = Const.TOOLTIP_EXPENSESREF;
            grdBudgets.Columns[3].ToolTipText = Const.TOOLTIP_AVERAGE;
            grdBudgets.Columns[4].ToolTipText = Const.TOOLTIP_EVOLUTION;
            grdBudgets.Columns[5].ToolTipText = Const.TOOLTIP_PROPORTION;
        }

        /// <summary>
        /// Désactive le choix d'une date de référence selon la coche de la case.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMonthRef_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateRef.Enabled = chkMonthRef.Checked;
        }
    }
}
