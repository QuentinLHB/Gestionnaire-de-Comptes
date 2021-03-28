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

        public frmAnalysis(frmMain frmMain, Controler controler, int monthRef =-1, int yearRef =-1)
        {
            InitializeComponent();
            this.frmMain = frmMain;
            this.controler = controler;
            loadComponents();
            
        }

        private void loadComponents()
        {

            frmMain.loadCboMonth(cboMonthRef);
            frmMain.selectCurrentMonth(cboMonthRef);

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
            cboYearRef.SelectedIndex = 0;

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
            grdBudgets.DataSource = gridData;
            grdBudgets.Visible = true;
            grdBudgets.Columns[2].Visible = chkMonthRef.Checked;
            grdBudgets.Columns[4].Visible = chkMonthRef.Checked;
        }


        private void chkMonthRef_CheckedChanged(object sender, EventArgs e)
        {
            cboMonthRef.Enabled = chkMonthRef.Checked;
            cboYearRef.Enabled = chkMonthRef.Checked;
        }
    }
}
