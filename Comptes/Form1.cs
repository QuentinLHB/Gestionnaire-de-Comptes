using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comptes
{
    public partial class frmComptes : Form
    {
        public Dictionary<string, double> dctRepartition = new Dictionary<string, double>();
        List<Budget> lesBudgets = new List<Budget>(); // Liste => BindingList <= ListBox 
        List<Compte> lesComptes = new List<Compte>();
        public string persA; public string persB;

        public frmComptes()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstBudgets.DataSource = new BindingList<Budget>(lesBudgets); // Binding

            dctRepartition.Add("50 / 50", 0.5);
            dctRepartition.Add("60 / 40", 0.6);
            dctRepartition.Add("70 / 30", 0.7);


            foreach (KeyValuePair<string, double> cle in dctRepartition)
            {
                cboRepartition.Items.Add(cle.Key);
                cboRepartition.SelectedIndex = 0;
            }

            enableCompte();

        }


// ______________________________ BUDGETS ____________________________________

        private void btnOKBudgets_Click(object sender, EventArgs e)
        {
            Budget nouveauBudget = new Budget(txtBudget.Text, dctRepartition[cboRepartition.SelectedItem.ToString()]);
            (lstBudgets.DataSource as BindingList<Budget>).Add(nouveauBudget);

            lesComptes.Add(new Compte(nouveauBudget));

            updateListeComptes(lstBudgets.Items.Count-1);

            txtBudget.Text = "";
            txtBudget.Focus();

            enableCompte();
        }

        private void enableCompte()
        {
            if (gpbComptes.Enabled == false && lstBudgets.Items.Count != 0)
            {
                gpbComptes.Enabled = true;
                lstBudgets.SelectedIndex = 0;
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
            Compte compte = lesComptes[lstBudgets.SelectedIndex];

            verifieSiVide();

            affichageDesDepenses(compte);
            updatTotaux();
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
            if(txtMontantPersA.Text.Equals(""))
            {
                txtMontantPersA.Text = "0";
            }

            if (txtMontantPersB.Text.Equals(""))
            {
                txtMontantPersB.Text = "0";
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
            compte.depensesPersA = Eval(txtMontantPersA.Text);
            compte.depensesPersB = Eval(txtMontantPersB.Text);
            }

            catch
            {
                MessageBox.Show("Ne saisir que des nombres ou des calculs.", "Erreur", MessageBoxButtons.OK);
            }
            lstComptes.Items [lstBudgets.SelectedIndex] =
                ($"{compte.budget.nom} : [{lblPersA.Text} {compte.depensesPersA}] [{lblPersB.Text} {compte.depensesPersB}]");

        }



// ________________________________ TOTAUX DES DETTES __________________________________________

        /// <summary>
        /// Met à jour les totaux de dettes
        /// </summary>
        /// <param name="compte"></param>
        private void updatTotaux()
        {

            //double repartitionBudget = compte.budget.repartition;

            //double detteA = compte.depensesPersB * repartitionBudget;
            //double detteB = compte.depensesPersA * (1-repartitionBudget);

            

            double totalDettesPersA = 0;
            double totalDettesPersB = 0;
            foreach (Compte compte in lesComptes)
            {
                totalDettesPersA += compte.depensesPersB * compte.budget.repartition;
                totalDettesPersB += compte.depensesPersA * (1 - compte.budget.repartition);
            }

            lblTotalPersA.Text = totalDettesPersA.ToString();
            lblTotalPersB.Text = totalDettesPersB.ToString();

        }

        /// <summary>
        /// Met à jour le grand total
        /// </summary>
        private void updateResultat()
        {
            double resultat = double.Parse(lblTotalPersA.Text) - double.Parse(lblTotalPersB.Text);
            if (resultat >= 0)
            {
                affichageResultat(txtPersA.Text, resultat);
            }
            else
            {
                affichageResultat(txtPersB.Text, -resultat);
            }
        }

        private void affichageResultat(string nom, double resultat)
        {
            lblResultat.Text = ($"{nom} doit {resultat}.");
        }

        // _________________________________ GESTION DES NOMS D'UTILISATEURS _________________________
        private void txtPersA_KeyUp(object sender, KeyEventArgs e)
        {
            persA = txtPersA.Text;
            updateNomPers(persA, lblPersA, lblNomTotalPersA);

        }

        private void txtPersB_TextChanged(object sender, EventArgs e)
        {
            persB = txtPersB.Text;
            updateNomPers(persB, lblPersB, lblNomTotalPersB);
        }

        private void updateNomPers(string personne, Label lblPers, Label lblNomTotalPers)
        {
            lblPers.Text = personne + " :";
            lblNomTotalPers.Text = ($"Total dettes {personne} :");
        }

        // ________________________________________ AJOUT DE REPATITIONS ___________________________________
        /// <summary>
        /// Ajoute la repartition entrée dans la textbox au combobox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOKRepartition_Click(object sender, EventArgs e)
        {
            string cle = txtDividende.Text + " / " + txtDiviseur.Text;
            dctRepartition.Add(cle, double.Parse(txtDividende.Text) / 100);
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

        private void resetMenuCompte()
        {
            txtMontantPersA.Focus();
            txtMontantPersA.Text = "";
            txtMontantPersB.Text = "";
        }

        /// <summary>
        /// Crée le miroir des budgets
        /// </summary>
        private void updateListeComptes(int index)
        {
            //lstBudgets.SelectedIndex++;
            lstComptes.Items.Add(lesBudgets[index].nom + " :");
            lstComptes.SelectedIndex = 0;
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

        private void lstBudgets_DoubleClick(object sender, EventArgs e)
        {
            Budget selectedBudget = lesBudgets[lstBudgets.SelectedIndex];
            txtBudget.Text = selectedBudget.nom;
            cboRepartition.SelectedItem = selectedBudget.repartition.ToString();
        }
    }
}
