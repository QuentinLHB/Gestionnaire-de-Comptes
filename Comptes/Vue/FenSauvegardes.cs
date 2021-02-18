using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comptes.Model;

namespace Comptes
{
    public partial class FenSauvegardes : Form
    {
        //List<Budget> lesBudgets;
        List<DataTableauMensuel> dataTableau;
        SaveMois saveMois;
        public FenSauvegardes(SaveMois save)
        {
            InitializeComponent();
            saveMois = save;
            dataTableau = LoadGridData();
            this.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            miseEnFormeTableau();

            grdBudgets.Show();
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

        private List<DataTableauMensuel> LoadGridData()
        {
            var tableauMensuel = new List<DataTableauMensuel>();
            foreach (Budget budget in saveMois.lesBudgets)
            {
                tableauMensuel.Add(new DataTableauMensuel(
                   nomCompte: budget.nom,
                   depensesA: budget.compte.userA.depenses,
                   nomUserA: budget.compte.userA.nom,
                   depensesB: budget.compte.userA.depenses,
                   nomUserB: budget.compte.userB.nom));
            }

            return tableauMensuel;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
