using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comptes.Control;
using Comptes.Constants;
using Comptes.Vue;
using Comptes.Model;

namespace Comptes.Vue
{
    public partial class frmUsersNames : Form
    {
        public Controler controler;
        public frmMain frmMain;

        /// <summary>
        /// Constructeur du formulaire de changements de noms d'utilisateurs.
        /// </summary>
        /// <param name="controler">Controleur</param>
        /// <param name="frmMain">Formulaire principal.</param>
        public frmUsersNames(Controler controler, frmMain frmMain)
        {
            this.controler = controler;
            InitializeComponent();
            this.frmMain = frmMain;
            if (frmMain != null) fillUsersNames();
            this.ShowDialog();
        }

        private void fillUsersNames()
        {
            if (!User.isNameDefault(Const.USER_A)) txtUserA.Text = User.getName(Const.USER_A);
            if (!User.isNameDefault(Const.USER_B)) txtUserB.Text = User.getName(Const.USER_B);

        }

        /// <summary>
        /// Valide les noms d'utilisateurs entrés dans les champs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtUserA.Text == "" || txtUserB.Text == "")
            {
                if(txtUserA.Text == "") controler.setUserName(Const.USER_A, Const.DEFAULT_NAME_USER_A);
                if(txtUserB.Text == "") controler.setUserName(Const.USER_B, Const.DEFAULT_NAME_USER_B);
            }

            else
            {
                controler.setUserName(Const.USER_A, txtUserA.Text);
                controler.setUserName(Const.USER_B, txtUserB.Text);
            }

            this.Hide();
            if (frmMain == null)
            {
                controler.loadMainForm();
            }
            this.Close();
        }

        /// <summary>
        /// Gère le déplacement de la fenêtre par clic enfoncé sur le menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            controler.dragWindow(this, e);
        }

        /// <summary>
        /// Gère le éplacement de la fenêtre par un déplacement de la fenêtre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            controler.focusMenuStrip((MenuStrip)sender);
        }

        /// <summary>
        /// Demande confirmation si un texte est entré, ferme la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUserA.Text != "" || txtUserB.Text != "")
            {
                if (MessageBox.Show("Quitter sans enregistrer ?", "Quitter", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void txtUserA_KeyPress(object sender, KeyPressEventArgs e)
        {
            testLengthLimit(txtUserA, e);
        }

        private void txtUserB_KeyPress(object sender, KeyPressEventArgs e)
        {
            testLengthLimit(txtUserB, e);
        }

        private void testLengthLimit(TextBox txtUser, KeyPressEventArgs e)
        {
            if (txtUserA.Text.Length > Const.NAME_LENGTH_LIMIT)
            {
                e.Handled = true;
            }
        }
    }
}
