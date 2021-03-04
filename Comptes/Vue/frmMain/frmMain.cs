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

/** Gestionnaire de comptes
 * Gère les comptes mensuels de deux utilisateur.
 * @author QuentinLHB
 */

namespace Comptes
{
    public partial class frmMain : Form
    {


        bool flagDataChange = false;
        bool flagUserNameChange = false;
        AppData data;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Const.initializDivisions();
            loadCboDistribution();
            loadData();
            updateTotals();
            accessAddAccount();


        }

        public void loadDivisions(ComboBox comboBox)
        {
            foreach (KeyValuePair<string, double> pair in data.dctDivisions)
            {
                comboBox.Items.Add(pair.Key);
            }
            comboBox.SelectedIndex = 0;
        }

        private void loadCboDistribution()
        {
            DateTime date = DateTime.Now;
            for (int year=date.Year-1; year < (date.Year + 2); year++)
            {
                cboYear.Items.Add(year);
            }
            cboYear.SelectedIndex = 1;

            var DateTimeFormatInfo = CultureInfo.GetCultureInfo("fr-FR").DateTimeFormat;

            for (int k = 1; k <= 12; k++)
            {
                cboMonth.Items.Add(DateTimeFormatInfo.CurrentInfo.GetMonthName(k));
            }
            
            if(date.Month != 1)
            {
                cboMonth.SelectedIndex = date.Month - 2;
            }
            else
            {
                cboMonth.SelectedIndex = Const.DECEMBER;
            }
            

        }

        public void refreshCboDivisions()
        {
            cboDivisions.Items.Clear();
            loadDivisions(cboDivisions);
        }

        /// <summary>
        /// Charge les données enregistrées.
        /// Si aucun fichier enregistré, crée deux users.
        /// </summary>
        private void loadData()
        {
            
            Object obj = Serialise.Load(Const.FILE_DATA);

            if (obj != null)
            {
                data = (AppData)obj;
                User.initializeNames(data);
                // Si les noms enregistrés ne sont pas ceux par défaut
                if(User.getName(Const.USER_A) != Const.DEFAULT_NAME_USER_A || (User.getName(Const.USER_B)) != Const.DEFAULT_NAME_USER_B)
                {  
                    txtUserA.Text = User.getName(Const.USER_A);
                    txtUserB.Text = User.getName(Const.USER_B);
                }

                else
                {
                    loadDefaultName();
                }

                loadDivisions(cboDivisions);

            }

            else // fichier vide
            {
                data = new AppData();
                User.initializeStaticData();
                loadDefaultName();
                loadDivisions(cboDivisions);
            }

            if (data.allBudgets != null)
            {
                foreach (Budget budget in data.allBudgets)
                {
                    lstBudgets.Items.Add(budget);
                    lstAccounts.Items.Add(budget.account);
                }
            }

            setFlagUserChange(change: false);

        }

        private void loadDefaultName()
        {
            lblUserA.Text = Const.DEFAULT_NAME_USER_A + ":";
            lblUserB.Text = Const.DEFAULT_NAME_USER_B + ":";
            lblNomTotalUserA.Text = $"Total dettes {Const.DEFAULT_NAME_USER_A} :";
            lblNomTotalUserB.Text = $"Total dettes {Const.DEFAULT_NAME_USER_B} :";
        }



        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
