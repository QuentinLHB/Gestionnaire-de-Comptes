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
        //frmMain frmMain;
        Controler controler;

        public frmAnalysis(frmMain frmMain, Controler controler, FrmMonthlySave frmMonthlySave = null)
        {
            InitializeComponent();
            //this.frmMain = frmMain;
            this.controler = controler;
            loadComponents();
            if(frmMonthlySave != null)
            {
                frmMonthlySave.Close();
            }
            //dtpDateRef.
            this.ShowDialog();
        }

        private void loadComponents()
        {
            dtpDateRef.CustomFormat = Const.MONTH_YEAR_FORMAT;
            dtpDateStart.CustomFormat = Const.MONTH_YEAR_FORMAT;
            dtpDateEnd.CustomFormat = Const.MONTH_YEAR_FORMAT;
            cboAnalysisMode.SelectedIndex = 0;               
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

        private void cboAnalysisMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboAnalysisMode.SelectedIndex;
            switch (index)
            {
                case 0: displayCompnents_betweenTwoDates(); break;
                case 1: displayCompnents_allYear(); break;
                case 2: displayCompnents_allTime(); break;
            }
        }

        private void displayCompnents_betweenTwoDates()
        {
            if (dtpYear.Visible) dtpYear.Visible = false;
            if(!panDates.Visible) panDates.Visible = true;
        }

        private void displayCompnents_allYear()
        {
            if (dtpDateStart.Visible) panDates.Visible = false;
            if(!dtpYear.Visible) dtpYear.Visible = true;
        }

        private void displayCompnents_allTime()
        {
            if (dtpDateStart.Visible) panDates.Visible = false;
            if (dtpYear.Visible) dtpYear.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataAnalysis.Clear();
            DistinctBudget.Clear();

            MonthlySave saveRef = null;
            if (chkMonthRef.Checked)
            {
                List<MonthlySave> allMonthlySaves = (List<MonthlySave>)Serialise.Load(Const.FILE_MONTHLYRECAP);
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
            grdBudgets.Columns[2].HeaderText = ($"{Const.MONTHLYEXPENSES_HEADER} {dtpDateRef.Value.Date}");

            
            
        }

        //private string[] calculateTotal()
        //{
        //    string[] rowTotal = new string[6];
        //    rowTotal[0] = "TOTAL";
        //    rowTotal[1] = DistinctBudget.getTotalExpenses().ToString(); //Total de tous les budgets
        //    double totalMonthRef = DataAnalysis.expensesMonthRef;
        //    rowTotal[2] = totalMonthRef.ToString() + "€"; // total du mois de ref
        //    DistinctBudget.setTotalAverage(DataAnalysis.Items.Count);
        //    rowTotal[3] = DistinctBudget.getTotalAverage().ToString() + "€"; // Moyenne des moyennes
        //    rowTotal[4] = DistinctBudget.totalEvolution(totalMonthRef).ToString() + "€"; // Ecart du mois à la moyenne
        //    rowTotal[5] = "100%"; // La somme des % arrive tjr à 100

        //    return rowTotal;
        //}


        private void chkMonthRef_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateRef.Enabled = chkMonthRef.Checked;
        }
    }
}
