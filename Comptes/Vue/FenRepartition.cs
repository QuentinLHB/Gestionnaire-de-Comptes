using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Comptes.Model;

namespace Comptes
{
    public partial class FrmRepartition : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        frmPrincipal frmPrincipal;
        AppData data;
        public FrmRepartition(AppData data, frmPrincipal frmPrincipal)
        {
            InitializeComponent();
            this.data = data;
            this.frmPrincipal = frmPrincipal;
            frmPrincipal.chargeRepartitions(cboRepartition);
        }

        //____________________________AJOUTER ______________________________________
        private void btnAjouterRepartition_Click(object sender, EventArgs e)
        {
            string cle = txtDividende.Text + " / " + txtDiviseur.Text;
            try
            {
                data.dctRepartitions.Add(cle, double.Parse(txtDividende.Text) / 100);
                frmPrincipal.ajouterRepartition(cle);
            }
            catch
            {
                MessageBox.Show(Constantes.MSG_ERR_AJOUTREPART, Constantes.ERREUR, MessageBoxButtons.OK);
            }

            this.Close();
        }

        /// <summary>
        /// Vérifie le caractère tapé pour ne garder que les chiffres et back.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDividende_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtDividende_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                txtDiviseur.Text = (100 - int.Parse(txtDividende.Text)).ToString();
            }

            catch
            {
                txtDiviseur.Text = "";
            }
        }

        // __________________________ SUPPRIMER ______________________________________
        private void btnSupprimerRepartition_Click(object sender, EventArgs e)
        {
            if (data.dctRepartitions.Count != 1)
            {
                data.dctRepartitions.Remove(cboRepartition.SelectedItem.ToString());
                frmPrincipal.refreshCboRepartitions();
            }

            else
            {
                MessageBox.Show(Constantes.MSG_ERR_AJOUTREPART2, Constantes.ERREUR, MessageBoxButtons.OK);
            }
            frmPrincipal.flagChangement(true);
            Close();
        }

        // _________________________ NAVIGATION _______________________________________
        private void menuStripRepartition_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void menuStripRepartition_MouseMove(object sender, MouseEventArgs e)
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


    }
}
