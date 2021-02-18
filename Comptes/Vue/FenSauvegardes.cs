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
    public partial class FenSauvegardes : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        List<DataTableauMensuel> dataTableau;
        List<SaveMensuelle> lesSavesMensuelles;


        /// <summary>
        /// Récupère les sauvegardes mensuelles et initialise le formulaire.
        /// </summary>
        /// <param name="lesSavesMensuelles">Liste des sauvegardes mensuelles enregistrées.</param>
        public FenSauvegardes(List<SaveMensuelle> lesSavesMensuelles)
        {
            InitializeComponent();
            this.lesSavesMensuelles = lesSavesMensuelles;
            this.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chargeCboMois();
            chargeCboAnnee();

        }

        /// <summary>
        /// Charge les mois de l'année dans un combobox.
        /// </summary>
        private void chargeCboMois()
        {
            var DateTimeFormatInfo = CultureInfo.GetCultureInfo("fr-FR").DateTimeFormat;

            for (int k = 1; k <= 12; k++)
            {
                cboMois.Items.Add(DateTimeFormatInfo.CurrentInfo.GetMonthName(k));
            }
            cboMois.SelectedIndex = 0;


        }

        /// <summary>
        /// Charge  dans un combobox les années pour lesquelles une sauvegarde mensuelle existe.
        /// </summary>
        private void chargeCboAnnee()
        {
            bool existe = false;
            foreach (SaveMensuelle save in lesSavesMensuelles)
            {

                foreach (string cboAnneeItem in cboAnnee.Items)
                {
                    if (save.annee == cboAnneeItem)
                    {
                        existe = true;
                        break;
                    }

                }
                if (existe == false)
                {
                    cboAnnee.Items.Add(save.annee);
                }
            }
            cboAnnee.SelectedIndex = 0;
        }

        private void miseEnFormeTableau()
        {
            var data = this.dataTableau;
            grdBudgets.DataSource = data;

            grdBudgets.Columns[0].HeaderText = "Budget";
            grdBudgets.Columns[1].HeaderText = $"Dépenses de {dataTableau[0].nomUserA}";
            grdBudgets.Columns[2].HeaderText = $"Dépenses de {dataTableau[0].nomUserB}";
            grdBudgets.Columns[3].HeaderText = "Total";
        }

        private List<DataTableauMensuel> chargeGrille(SaveMensuelle saveMensuelle)
        {
            var tableauMensuel = new List<DataTableauMensuel>();
            foreach (Budget budget in saveMensuelle.lesBudgets)
            {
                tableauMensuel.Add(new DataTableauMensuel(
                   nomCompte: budget.nom,
                   depensesA: budget.compte.userA.depenses,
                   nomUserA: budget.compte.userA.nom,
                   depensesB: budget.compte.userB.depenses,
                   nomUserB: budget.compte.userB.nom));
            }
            grdBudgets.Visible = true;
            return tableauMensuel;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveMensuelle saveMensuelle = null;
            foreach(SaveMensuelle save in lesSavesMensuelles)
            {
                if (save.annee == (string)cboAnnee.SelectedItem & save.mois == (string)cboMois.SelectedItem)
                {
                    saveMensuelle = save;
                    break;
                }
            }

            if (saveMensuelle != null)
            {
                dataTableau = chargeGrille(saveMensuelle);
                miseEnFormeTableau();
                grdBudgets.Show();
            }

            else
            {
                MessageBox.Show($"Aucune sauvegarde n'a été trouvé pour le mois suivante :\n{cboMois.SelectedItem} {cboAnnee.SelectedItem}");
            }
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
    }
}
