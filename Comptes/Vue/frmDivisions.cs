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
using Comptes.Control;
using Comptes.Constants;

namespace Comptes
{
    public partial class FrmDivisions : Form
    {
        //public const int WM_NCLBUTTONDOWN = 0xA1;
        //public const int HT_CAPTION = 0x2;

        //[DllImportAttribute("user32.dll")]
        //private static extern int SendMessage(IntPtr hWnd,
        //                 int Msg, int wParam, int lParam);
        //[DllImportAttribute("user32.dll")]
        //private static extern bool ReleaseCapture();

        frmMain frmMain;
        //AppData data;
        Controler controler;


        public FrmDivisions(frmMain frmMain, Controler controler)
        {
            this.controler = controler;
            this.frmMain = frmMain;
            InitializeComponent();
            frmMain.loadDivisions(cboDivisions);
        }

        private void btnAjouterRepartition_Click(object sender, EventArgs e)
        {
            try
            {
                string division = controler.createNewDivision(txtDividend.Text, txtDivider.Text);
                cboDivisions.Items.Add(division);
            }
            catch
            {
                MessageBox.Show(Const.MSG_ERR_ADDDIVISION, Const.ERROR, MessageBoxButtons.OK);
            }

            controler.setFlagChange(change: true);
            Close();
        }

        /// <summary>
        /// Vérifie le caractère tapé.
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
            txtDivider.Text = controler.getDivider(txtDividend.Text);
        }

        private void btnSupprimerRepartition_Click(object sender, EventArgs e)
        {
            controler.deleteDivision(cboDivisions.SelectedItem.ToString());
            controler.setFlagChange(true);
            Close();
        }

       
        private void menuStripRepartition_MouseDown(object sender, MouseEventArgs e)
        {
            controler.dragWindow(this, e);
        }

        private void menuStripRepartition_MouseMove(object sender, MouseEventArgs e)
        {
            controler.focusMenuStrip((MenuStrip)sender);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void refreshCboDivisions()
        {
            cboDivisions.Items.Clear();
            frmMain.loadDivisions(cboDivisions);
        }

    }
}
