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



namespace Comptes
{
    public partial class frmComptes : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();



        
        AppData data;
        AffichageData affichage;


        public frmComptes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            affichage = new AffichageData();
            chargeData();
            updateTotaux();
            updateResultat();
            AccesGpbComptes();

        }

        private void chargeRepartitions()
        {
            foreach (KeyValuePair<string, double> paire in data.dctRepartitions)
            {
                cboRepartition.Items.Add(paire.Key);
            }
            cboRepartition.SelectedIndex = 0;

        }

        /// <summary>
        /// Charge les données enregistrées.
        /// Si aucun fichier enregistré, crée deux users.
        /// </summary>
        private void chargeData()
        {
            
            Object obj = Serialise.Recup(affichage.fichierData);

            if (obj != null)
            {
                data = (AppData)obj;

                if(data.lesUsers[affichage.userA].nom != affichage.nomUserA & data.lesUsers[affichage.userB].nom != affichage.nomUserB)
                {
                    txtUserA.Text = data.lesUsers[affichage.userA].nom;
                    txtUserB.Text = data.lesUsers[affichage.userB].nom;
                }

                chargeRepartitions();

            }

            else
            {
                data = new AppData();

                data.lesUsers.Add(new User(affichage.nomUserA));
                data.lesUsers.Add(new User(affichage.nomUserB));
                chargeRepartitions();
            }

            if (data.lesBudgets != null)
            {
                foreach (Budget budget in data.lesBudgets)
                {
                    lstBudgets.Items.Add(budget);
                    lstComptes.Items.Add(budget.compte);
                }
            }

        }


        // ______________________________ BUDGETS ____________________________________

        private void btnOKBudgets_Click(object sender, EventArgs e)
        {
            Budget nouveauBudget = creationNouveauBudget();
            lstComptes.Items.Add(nouveauBudget.afficheNomBudget());
            lstComptes.SelectedIndex = 0;
            resetBudget();
            AccesGpbComptes();
        }

        /// <summary>
        /// Crée un budget et l'affiche.
        /// </summary>
        /// <returns></returns>
        private Budget creationNouveauBudget()
        {
            Budget nouveauBudget = new Budget(
                nom: txtNomBudget.Text,
                repartition: data.dctRepartitions[cboRepartition.SelectedItem.ToString()],
                data.lesUsers[affichage.userA], data.lesUsers[affichage.userB]);

            data.lesBudgets.Add(nouveauBudget);
            lstBudgets.Items.Add(nouveauBudget);

            return nouveauBudget;
        }



        /// <summary>
        /// Réinitialise la cellule et le focus après la validation d'un bouton.
        /// </summary>
        private void resetBudget()
        {
            txtNomBudget.Text = "";
            txtNomBudget.Focus();
        }

        private void lstBudgets_DoubleClick(object sender, EventArgs e)
        {
            Budget BudgetSelectionne = getBudgetSelectionne(); ;
            txtNomBudget.Text = BudgetSelectionne.nom;
            cboRepartition.SelectedItem = BudgetSelectionne.repartition.ToString(); //ne fonctionne pas
            txtNomBudget.Focus();
            gérerModeEdition(modeEdition: true);

        }

        /// <summary>
        /// Retourne le budget sélectionné dans la liste.
        /// </summary>
        /// <returns></returns>
        private Budget getBudgetSelectionne()
        {
            return data.lesBudgets[lstBudgets.SelectedIndex];
        }

        /// <summary>
        /// Intervertit les boutons d'ajout et d'édition.
        /// </summary>
        /// <param name="modeEdition"></param>
        private void gérerModeEdition(bool modeEdition)
        {
            btnOKBudgets.Visible = !modeEdition;
            btnEdit.Visible = modeEdition;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Budget budgetSelectionne = getBudgetSelectionne();
            budgetSelectionne.nom = txtNomBudget.Text;
            budgetSelectionne.repartition = data.dctRepartitions[cboRepartition.SelectedItem.ToString()];
            
            lstBudgets.Items[lstBudgets.SelectedIndex] = budgetSelectionne;
            updateAffichageComptes(GetCompteSelectionne());
            gérerModeEdition(modeEdition: false);
            resetBudget();
        }



        private void lstBudgets_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                supprimerBudget();
            }
        }

        /// <summary>
        /// Supprime le budget sélectionné et le compte associé.
        /// </summary>
        private void supprimerBudget()
        {
            if (MessageBox.Show("Voulez-vous vraiment supprimer le budget et son contenu ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int index = lstBudgets.SelectedIndex;

                data.lesBudgets.RemoveAt(index);

                lstBudgets.Items.RemoveAt(index);
                lstComptes.Items.RemoveAt(index);

                AccesGpbComptes();

                updateTotaux();
                updateResultat();

                txtNomBudget.Focus();
            }
        }

        // ____________________________ COMPTES ______________________________________
        /// <summary>
        /// Ajoute les dettes de chacune des personnes dans la liste des comptes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOKComptes_Click(object sender, EventArgs e)
        {
            Compte compte = GetCompteSelectionne();

            verifieSiVide();
            affichageDesDepenses(compte);
            updateTotaux();
            updateResultat();

            try { lstBudgets.SelectedIndex++; }
            catch { }
            resetMenuCompte();

        }

        /// <summary>
        /// Gère les textBox des montants si elles sont vides.
        /// </summary>
        private void verifieSiVide()
        {
            if(txtMontantUserA.Text.Equals(""))
            {
                txtMontantUserA.Text = "0";
            }

            if (txtMontantUserB.Text.Equals(""))
            {
                txtMontantUserB.Text = "0";
            }
        }
        
        /// <summary>
        /// Affiche les dépenses entrées dans la listBox des Comptes.
        /// </summary>
        /// <param name="compte"></param>
        private void affichageDesDepenses(Compte compte)
        {
            try 
            { 
            compte.depensesUserA = Eval(txtMontantUserA.Text);
            compte.depensesUserB = Eval(txtMontantUserB.Text);
            }

            catch
            {
                MessageBox.Show("Ne saisir que des nombres ou des calculs.", "Erreur", MessageBoxButtons.OK);
            }

            updateAffichageComptes(compte);
        }

        /// <summary>
        /// Met à jour l'affichage du compte sélectionné dans la liste.
        /// </summary>
        /// <param name="compte"></param>
        private void updateAffichageComptes(Compte compte)
        {
            lstComptes.Items[lstComptes.SelectedIndex] = compte;

        }


        private void lstComptes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                videCompte();
                updateTotaux();
                updateResultat();
            }
        }


        private void videCompte()
        {
            int index = lstComptes.SelectedIndex;
            GetCompteSelectionne().reset();
            lstComptes.Items[index] = data.lesBudgets[index].nom + " :";
        }

        private void lstComptes_DoubleClick(object sender, EventArgs e)
        {
            Compte compte = GetCompteSelectionne();
            txtMontantUserA.Text = compte.depensesUserA.ToString();
            txtMontantUserB.Text = compte.depensesUserB.ToString();
            txtMontantUserA.Focus();
        }

        /// <summary>
        /// Si la liste des budgets est vide, désactive le bouton Valider de la zone comptes.
        /// </summary>
        private void AccesGpbComptes()
        {
            if (lstBudgets.Items.Count != 0)
            {
                btnOKComptes.Enabled = true;
                lstBudgets.SelectedIndex = 0;
            }

            else
            {
                btnOKComptes.Enabled = false;
            }
        }

        private Compte GetCompteSelectionne()
        {
            return data.lesBudgets[lstComptes.SelectedIndex].compte;
        }

        // ________________________________ TOTAUX DES DETTES __________________________________________

        /// <summary>
        /// Met à jour les totaux de dettes
        /// </summary>
        /// <param name="compte"></param>
        private void updateTotaux()
        {
            double totalDettesPersA = 0;
            double totalDettesPersB = 0;
            foreach (Budget budget in data.lesBudgets)
            {
                totalDettesPersA += budget.compte.depensesUserB * budget.repartition;
                totalDettesPersB += budget.compte.depensesUserA * (1 - budget.repartition);
            }

            data.lesUsers[affichage.userA].dettes = totalDettesPersA;
            data.lesUsers[affichage.userB].dettes = totalDettesPersB;
            lblTotalPersA.Text = data.lesUsers[affichage.userA].dettes.ToString();
            lblTotalPersB.Text = data.lesUsers[affichage.userB].dettes.ToString();

        }

        /// <summary>
        /// Met à jour le grand total
        /// </summary>
        private void updateResultat()
        {
            double resultat = data.lesUsers[affichage.userA].dettes - data.lesUsers[affichage.userB].dettes;


            if (resultat > 0)
            {
                affichageResultat(data.lesUsers[affichage.userA].nom, resultat);
            }

            else if (resultat < 0)
            {
                affichageResultat(data.lesUsers[affichage.userB].nom, -resultat);
            }

            else
            {
                lblResultat.Text = "Résultat équilibré.";
            }
        }



        private void affichageResultat(string nom, double resultat)
        {
            lblResultat.Text = ($"{nom} doit {resultat}.");
        }


        // ___________________________ GESTION DES UTILISATEURS __________________________

        private void txtUserA_TextChanged(object sender, EventArgs e)
        {
            updateNomPers(data.lesUsers[affichage.userA], txtUserA, lblUserA, lblNomTotalUserA, affichage.nomUserA);
        }

        private void txtUserB_TextChanged(object sender, EventArgs e)
        {
            updateNomPers(data.lesUsers[affichage.userB], txtUserB, lblUserB, lblNomTotalUserB, affichage.nomUserB);
        }

        /// <summary>
        /// Modifie le nom de l'utilisateur dans tous les emplacements appropriés.
        /// </summary>
        /// <param name="user">Utilisateur concerne (A/B)</param>
        /// <param name="txtUser">Textbox concernée</param>
        /// <param name="lblUser">Label de la rubrique Compte concerné.</param>
        /// <param name="lblNomTotalUser">Label de la rubrique Total concerné.</param>
        /// <param name="nomDefaut">Nom par défaut à afficher si saisie nulle</param>
        private void updateNomPers(User user, TextBox txtUser, Label lblUser, Label lblNomTotalUser, string nomDefaut)
        {
            if(txtUser.Text != string.Empty)
            {
                user.nom = txtUser.Text;
            }

            else
            {
                user.nom = nomDefaut;
            }

            lblUser.Text = user.afficheNom();
            lblNomTotalUser.Text = ($"Total dettes {user.nom} :");
        }

        private void txtUserA_Leave(object sender, EventArgs e)
        {
            updateLstComptes();
            
        }

        private void txtUserB_Leave(object sender, EventArgs e)
        {
            updateLstComptes();
        }

        /// <summary>
        /// Rafraichit la liste des compte pour afficher le nouveau nom d'utilisateur.
        /// </summary>
        private void updateLstComptes()
        {
            int k = 0;
            foreach (Budget budget in data.lesBudgets)
            {
                lstComptes.Items[k++] = budget.compte;
            }
        }

        // ________________________________________ AJOUT DE REPARTITIONS ___________________________________
        /// <summary>
        /// Ajoute la repartition entrée dans la textbox au combobox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOKRepartition_Click(object sender, EventArgs e)
        {
            string cle = txtDividende.Text + " / " + txtDiviseur.Text;
            data.dctRepartitions.Add(cle, double.Parse(txtDividende.Text) / 100);
            cboRepartition.Items.Add(cle);

            txtDividende.Text = "";
            txtDiviseur.Text = "";
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

        // _____________________________ NAVIGATION _______________________________________

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



        private void menuSauvegarder_Click(object sender, EventArgs e)
        {
            sauvegarderData();
        }

        private void sauvegarderData()
        {
            try
            {
                Serialise.Sauve(affichage.fichierData, data);
            }
            catch
            {
                MessageBox.Show("Erreur.", "Sauvegarde", MessageBoxButtons.OK);
            }
        }


        private void menuReinitialiser_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Toutes les données seront effacées. Confirmer ?", "Réinitialisation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (File.Exists(affichage.fichierData))
                {
                    File.Delete(affichage.fichierData);
                }

            data.lesUsers[affichage.userA].nom = affichage.nomUserA;
            data.lesUsers[affichage.userB].nom = affichage.nomUserB;

            foreach (User user in data.lesUsers)
            {
                user.dettes = 0;
            }

            data.lesBudgets.Clear();

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }

                lstBudgets.Items.Clear();
                lstComptes.Items.Clear();
            }

            updateTotaux();
            updateResultat();

            MessageBox.Show("L'application a été réinitialisée avec succès.", "Réinitialisation", MessageBoxButtons.OK);
        }

        }

        /// <summary>
        /// Propose la sauvegarde du fichier et l'annulation de la fermeture de l'application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmComptes_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult choix = MessageBox.Show("Voulez-vous sauvegarder avant de quitter?", "Fermeture", MessageBoxButtons.YesNoCancel);
            if (choix == DialogResult.Yes)
            {
                sauvegarderData();
            }

            else if (choix == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
