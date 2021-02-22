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

    public partial class frmPrincipal : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

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

        private void resetMenuCompte()
        {
            txtMontantUserA.Focus();
            txtMontantUserA.Text = "";
            txtMontantUserB.Text = "";
        }

        private void lstBudgets_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstComptes.SelectedIndex = lstBudgets.SelectedIndex;
        }

        static Double Eval(String expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expression, String.Empty));
        }

        private void lstComptes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBudgets.SelectedIndex = lstComptes.SelectedIndex;
        }

        public void flagChangement(bool changement)
        {
            this.flagChangementData = changement;
        }

        /// <summary>
        /// Propose la sauvegarde du fichier et l'annulation de la fermeture de l'application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmComptes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagChangementData)
            {
                DialogResult choix = MessageBox.Show(Constantes.MSG_SAUEGARDERAVANTQUITTER, Constantes.MSG_TITRE_SAUEGARDERAVANTQUITTER, MessageBoxButtons.YesNoCancel);
                if (choix == DialogResult.Yes)
                {
                    sauvegarderData();
                }

                else if (choix == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
