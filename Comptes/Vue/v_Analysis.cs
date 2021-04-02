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

namespace Comptes
{
    public partial class frmAnalysis : Form
    {
        frmMain frmMain;
        Controler controler;
        //List<DistinctBudget> sortedBudgets;

        public frmAnalysis(frmMain frmMain, Controler controler, FrmMonthlySave frmMonthlySave = null, int monthRef =-1, int yearRef =-1)
        {
            InitializeComponent();
            this.frmMain = frmMain;
            this.controler = controler;
            loadComponents(monthRef, yearRef);
            if(frmMonthlySave != null)
            {
                frmMonthlySave.Close();
            }
            this.ShowDialog();
        }

        private void loadComponents(int monthRef, int yearRef)
        {

            frmMain.loadCboMonth(cboMonthRef);
            
            

            frmMain.loadCboMonth(cboStartingMonth);
            cboStartingMonth.SelectedIndex = 0; //janvier

            frmMain.loadCboMonth(cboEndingMonth);
            cboEndingMonth.SelectedIndex = 11; //décembre

            frmMain.loadExistingYears(cboStartingYear);
            cboStartingYear.SelectedIndex = 0;
            foreach (int item in cboStartingYear.Items) 
            {
                cboYear.Items.Add(item);
                cboEndingYear.Items.Add(item);
                cboYearRef.Items.Add(item);
            }
            cboEndingYear.SelectedIndex = 0;
            cboYear.SelectedIndex = 0;
            
            if(monthRef != -1 && yearRef != -1)
            {
                cboMonthRef.SelectedIndex = monthRef;
                cboYearRef.SelectedItem = yearRef;
            }
            else
            {
                frmMain.selectCurrentMonth(cboMonthRef);
                cboYearRef.SelectedIndex = 0;
            }
            

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
            if (cboYear.Visible) cboYear.Visible = false;
            if(!panDates.Visible) panDates.Visible = true;
        }

        private void displayCompnents_allYear()
        {
            if (cboStartingMonth.Visible) panDates.Visible = false;
            if(!cboYear.Visible) cboYear.Visible = true;
        }

        private void displayCompnents_allTime()
        {
            if (cboStartingMonth.Visible) panDates.Visible = false;
            if (cboYear.Visible) cboYear.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataAnalysis.Clear();
            DistinctBudget.Clear();

            MonthlySave saveRef = null;
            if (chkMonthRef.Checked)
            {
                List<MonthlySave> allMonthlySaves = (List<MonthlySave>)Serialise.Load(Const.FILE_MONTHLYRECAP);
                saveRef = MonthlySave.findMonthlySave(allMonthlySaves, controler.monthNumber(cboMonthRef.SelectedIndex), (int)cboYearRef.SelectedItem);
            }
            switch (cboAnalysisMode.SelectedIndex)
            {
                case 0: controler.sortBudgets(
                    monthStart: controler.monthNumber(cboStartingMonth.SelectedIndex), 
                    yearStart: int.Parse(cboStartingYear.Text),
                    monthStop: controler.monthNumber(cboEndingMonth.SelectedIndex),
                    yearStop: int.Parse(cboEndingYear.Text)); 
                    break;
                case 1: controler.sortBudgets(year: int.Parse(cboYear.Text)); break;
                case 2: controler.sortBudgets(); ; break;
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
            grdBudgets.Columns[2].HeaderText = ($"{Const.MONTHLYEXPENSES_HEADER} {cboMonthRef.SelectedItem} {cboYearRef.SelectedItem}");

            
            
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
            cboMonthRef.Enabled = chkMonthRef.Checked;
            cboYearRef.Enabled = chkMonthRef.Checked;
        }
    }
}
