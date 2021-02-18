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

        AppData data;
        AffichageData constantes;


        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            constantes = new AffichageData();
            chargeCboDates();
            chargeData();
            updateTotaux();
            updateResultat();
            accesAjoutCompte();

        }

        public void chargeRepartitions(ComboBox comboBox)
        {
            foreach (KeyValuePair<string, double> paire in data.dctRepartitions)
            {
                comboBox.Items.Add(paire.Key);
            }
            comboBox.SelectedIndex = 0;
        }

        private void chargeCboDates()
        {
            DateTime date = DateTime.Now;
            for (int annee=date.Year-1; annee < (date.Year + 2); annee++)
            {
                cboAnnee.Items.Add(annee);
            }
            cboAnnee.SelectedIndex = 1;

            var DateTimeFormatInfo = CultureInfo.GetCultureInfo("fr-FR").DateTimeFormat;

            for (int k = 1; k <= 12; k++)
            {
                cboMois.Items.Add(DateTimeFormatInfo.CurrentInfo.GetMonthName(k));
            }
            
            if(date.Month != 1)
            {
                cboMois.SelectedIndex = date.Month - 2;
            }
            else
            {
                cboMois.SelectedIndex = constantes.DECEMBRE;
            }
            

        }

        public void refreshCboRepartitions()
        {
            cboRepartition.Items.Clear();
            chargeRepartitions(cboRepartition);
        }

        /// <summary>
        /// Charge les données enregistrées.
        /// Si aucun fichier enregistré, crée deux users.
        /// </summary>
        private void chargeData()
        {
            
            Object obj = Serialise.Recup(constantes.fichierData);

            if (obj != null)
            {
                data = (AppData)obj;

                if(data.lesUsers[constantes.userA].nom != constantes.nomUserA & data.lesUsers[constantes.userB].nom != constantes.nomUserB)
                {
                    txtUserA.Text = data.lesUsers[constantes.userA].nom;
                    txtUserB.Text = data.lesUsers[constantes.userB].nom;
                }

                chargeRepartitions(cboRepartition);

            }

            else
            {
                data = new AppData();

                data.lesUsers.Add(new User(constantes.nomUserA));
                data.lesUsers.Add(new User(constantes.nomUserB));
                chargeRepartitions(cboRepartition);
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
            accesAjoutCompte();
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
                data.lesUsers[constantes.userA].nom, data.lesUsers[constantes.userB].nom);

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

                accesAjoutCompte();

                updateTotaux();
                updateResultat();

                txtNomBudget.Focus();
            }
        }

        private void btnResetBudget_Click(object sender, EventArgs e)
        {
            data.lesBudgets.Clear();
            lstBudgets.Items.Clear();
            lstComptes.Items.Clear();
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
            compte.userA.depenses = Eval(txtMontantUserA.Text);
            compte.userB.depenses = Eval(txtMontantUserB.Text);
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
                videCompte(lstComptes.SelectedIndex);
                updateTotaux();
                updateResultat();
            }
        }


        private void videCompte(int index)
        {
            GetCompteSelectionne().reset();
            lstComptes.Items[index] = data.lesBudgets[index].nom + " :";
        }

        private void lstComptes_DoubleClick(object sender, EventArgs e)
        {
            Compte compte = GetCompteSelectionne();
            txtMontantUserA.Text = compte.userA.depenses.ToString();
            txtMontantUserB.Text = compte.userB.depenses.ToString();
            txtMontantUserA.Focus();
        }

        /// <summary>
        /// Si la liste des budgets est vide, désactive le bouton Valider de la zone comptes.
        /// </summary>
        private void accesAjoutCompte()
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

        private void btnResetComptes_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < data.lesBudgets.Count; k++)
            {
                lstComptes.SelectedIndex = k;
                videCompte(k);
            }
            accesAjoutCompte();
            updateTotaux();
            updateResultat();
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
                totalDettesPersA += budget.compte.userB.depenses * budget.repartition;
                totalDettesPersB += budget.compte.userA.depenses * (1 - budget.repartition);
            }

            data.lesUsers[constantes.userA].dettes = totalDettesPersA;
            data.lesUsers[constantes.userB].dettes = totalDettesPersB;
            lblTotalPersA.Text = data.lesUsers[constantes.userA].dettes.ToString();
            lblTotalPersB.Text = data.lesUsers[constantes.userB].dettes.ToString();

        }

        /// <summary>
        /// Met à jour le grand total
        /// </summary>
        private void updateResultat()
        {
            double resultat = data.lesUsers[constantes.userA].dettes - data.lesUsers[constantes.userB].dettes;


            if (resultat > 0)
            {
                affichageResultat(data.lesUsers[constantes.userA].nom, resultat);
            }

            else if (resultat < 0)
            {
                affichageResultat(data.lesUsers[constantes.userB].nom, -resultat);
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
            updateNomPers(data.lesUsers[constantes.userA], txtUserA, lblUserA, lblNomTotalUserA, constantes.nomUserA);
        }

        private void txtUserB_TextChanged(object sender, EventArgs e)
        {
            updateNomPers(data.lesUsers[constantes.userB], txtUserB, lblUserB, lblNomTotalUserB, constantes.nomUserB);
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
        private void menuAjouterRepartition_Click(object sender, EventArgs e)
        {
            FrmRepartition frmRepartition = new FrmRepartition(data, this);

            frmRepartition.ShowDialog();
            //A terminer (ajout OU NON de répartition)
        }

        public void ajouterRepartition(string repartition)
        {
            cboRepartition.Items.Add(repartition);
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
                Serialise.Sauve(constantes.fichierData, data);
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
                if (File.Exists(constantes.fichierData))
                {
                    File.Delete(constantes.fichierData);
                }

                data.reinitialiseData();
                refreshCboRepartitions();

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

        private void btnCloture_Click(object sender, EventArgs e)
        {
            List<SaveMois> lesSaves = (List<SaveMois>) Serialise.Recup(constantes.fichierSaveMois);
            if (lesSaves == null)
            {
                lesSaves = new List<SaveMois>();
            }
            if ((MessageBox.Show("Valider le mois ? Aucune modification ne pourra êttre appotée", "Cloturer le mois", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {                
                SaveMois saveMois = new SaveMois(
                    mois: cboMois.SelectedItem.ToString(),
                    annee: cboAnnee.SelectedItem.ToString(),
                    lesBudgets: data.lesBudgets,
                    lesUsers: data.lesUsers);

                lesSaves.Add(saveMois);

                Serialise.Sauve(constantes.fichierSaveMois, lesSaves);
            }
        }

        private void menuSauvegardes_Click(object sender, EventArgs e)
        {
            List<SaveMois> lesSaves = (List<SaveMois>)Serialise.Recup(constantes.fichierSaveMois);

            FenSauvegardes fenSauvegardes = new FenSauvegardes(lesSaves[0]); // TODO A changer, c'est pour le test
        }
    }
}
