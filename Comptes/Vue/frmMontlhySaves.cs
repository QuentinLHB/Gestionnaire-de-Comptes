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

namespace Comptes
{
    public partial class FenSummary : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        List<DataMonthlyReport> dataTab;
        List<MonthlySave> allMonthlySaves;




        // ____________________________ CHARGEMENT & UTILITAIRES _______________________
        /// <summary>
        /// Récupère les sauvegardes mensuelles et initialise le formulaire.
        /// </summary>
        /// <param name="allMonthlySaves">Liste des sauvegardes mensuelles enregistrées.</param>
        public FenSummary(List<MonthlySave> allMonthlySaves)
        {
            InitializeComponent();
            this.allMonthlySaves = allMonthlySaves;
            this.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadCboMonth();
            chargeCboYear();
            btnDelMonthlyReport.Enabled = false;
        }

        /// <summary>
        /// Charge les mois de l'année dans un combobox.
        /// </summary>
        private void loadCboMonth()
        {
            var DateTimeFormatInfo = CultureInfo.GetCultureInfo("fr-FR").DateTimeFormat;

            for (int k = 1; k <= 12; k++)
            {
                cboMonth.Items.Add(DateTimeFormatInfo.CurrentInfo.GetMonthName(k));
            }
            cboMonth.SelectedIndex = 0;
        }

        /// <summary>
        /// Charge  dans un combobox les années pour lesquelles une sauvegarde mensuelle existe.
        /// </summary>
        private void chargeCboYear()
        {
            bool exists = false;
            foreach (MonthlySave save in allMonthlySaves)
            {
                foreach (string cboYearItem in cboYear.Items)
                {
                    if (save.year == cboYearItem)
                    {
                        exists = true;
                        break;
                    }
                }
                if (exists == false)
                {
                    cboYear.Items.Add(save.year);
                }
            }
            cboYear.SelectedIndex = 0;
        }
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Focused)
            {
                Focus();
            }
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
            MonthlySave monthlySave = MonthlySave.findMonthlySave(allMonthlySaves, cboMonth.Text, cboYear.Text);

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

            dataTab = tableauMensuel;

            var data = this.dataTab;
            grdBudgets.DataSource = data;

            grdBudgets.Columns[1].HeaderText = Const.EXPENSES(DataMonthlyReport.nameUserA);
            grdBudgets.Columns[2].HeaderText = Const.EXPENSES(DataMonthlyReport.nameUserB);

            grdBudgets.Visible = true;

        }

        private void btnDelMonthlyReport_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(Const.MSG_DELETEMONTLYSAVE, Const.MSG_TITLE_DELETE, MessageBoxButtons.YesNo) == DialogResult.Yes))
            {

                MonthlySave monthlySave = MonthlySave.findMonthlySave(allMonthlySaves, cboMonth.Text, cboYear.Text);
                allMonthlySaves.Remove(monthlySave);
                Serialise.Save(Const.FILE_MONTHLYRECAP, allMonthlySaves);
                grdBudgets.Visible = false;
                btnDelMonthlyReport.Enabled = false;
            }
        }
    }
}
