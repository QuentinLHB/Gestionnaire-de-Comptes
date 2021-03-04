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
    public partial class FrmDivisions : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        frmMain frmMain;
        AppData data;
        public FrmDivisions(AppData data, frmMain frmMain)
        {
            InitializeComponent();
            this.data = data;
            this.frmMain = frmMain;
            frmMain.loadDivisions(cboDivisions);
        }

        //____________________________AJOUTER ______________________________________
        private void btnAjouterRepartition_Click(object sender, EventArgs e)
        {
            string key = txtDividend.Text + " / " + txtDivider.Text;
            try
            {
                data.dctDivisions.Add(key, double.Parse(txtDividend.Text) / 100);
                frmMain.addDivision(key);
            }
            catch
            {
                MessageBox.Show(Const.MSG_ERR_ADDDIVISION, Const.ERROR, MessageBoxButtons.OK);
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
                txtDivider.Text = (100 - int.Parse(txtDividend.Text)).ToString();
            }

            catch
            {
                txtDivider.Text = "";
            }
        }

        // __________________________ SUPPRIMER ______________________________________
        private void btnSupprimerRepartition_Click(object sender, EventArgs e)
        {
            if (data.dctDivisions.Count != 1)
            {
                data.dctDivisions.Remove(cboDivisions.SelectedItem.ToString());
                frmMain.refreshCboDivisions();
            }

            else
            {
                MessageBox.Show(Const.MSG_ERR_ADDDIVISION2, Const.ERROR, MessageBoxButtons.OK);
            }
            frmMain.setFlagChange(true);
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
