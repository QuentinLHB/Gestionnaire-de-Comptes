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
using Comptes.Model;
using System.Globalization;
using Comptes.Control;
using Comptes.Constants;


namespace Comptes.Control
{
    public partial class Controler
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();



        static Double Eval(String expression)
        {
            DataTable table = new DataTable();
            return Convert.ToDouble(table.Compute(expression, String.Empty));
        }

        public void setFlagChange(bool change)
        {
            this.flagDataChange = change;
        }

        public void dragWindow(Form form, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(form.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /// <summary>
        /// Focus le Menustrip.
        /// </summary>
        /// <param name="menuStrip"></param>
        public void focusMenuStrip(MenuStrip menuStrip)
        {
            if (!menuStrip.Focused)
            {
                menuStrip.Focus();
            }
        }

        /// <summary>
        /// Propose la sauvegarde des données avant la fermeture.
        /// </summary>
        /// <param name="e">Action de fermeture du formulaire.</param>
        public void closingRequest(FormClosingEventArgs e)
        {
            if (flagDataChange)
            {
                DialogResult choice = MessageBox.Show(Const.MSG_SAVEBEFOREQUIT, Const.MSG_TITLE_SAVEBEFOREQUIT, MessageBoxButtons.YesNoCancel);
                if (choice == DialogResult.Yes)
                {
                    saveData();
                }

                else if (choice == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Etablie le lien entre les index de deux listBox. Quand l'une change, l'autre aussi.
        /// </summary>
        /// <param name="listChanged">Liste dont l'index a changé.</param>
        /// <param name="listToChange">Liste dont l'index doit changer.</param>
        public void listBoxIndexLink(ListBox listChanged, ListBox listToChange)
        {
            try
            {
                listToChange.SelectedIndex = listChanged.SelectedIndex;
            }
            catch { }
            
        }

        public void minimizeWindow(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }

        public DateTime formatDate(DateTime date)
        {
            return date.AddDays(-(date.Day - 1)).Date;
        }
    }
}
