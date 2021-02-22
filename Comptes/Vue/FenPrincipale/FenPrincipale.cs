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
    public partial class frmPrincipal : Form
    {


        bool flagChangementData = false;
        bool flagChangementNomUser = false;
        AppData data;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Constantes.initialiseRepartition();
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
                cboMois.SelectedIndex = Constantes.DECEMBRE;
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
            
            Object obj = Serialise.Recup(Constantes.FICHIER_DATA);

            if (obj != null)
            {
                data = (AppData)obj;

                // Si les noms enregistrés ne sont pas ceux par défaut
                if(data.lesUsers[Constantes.USER_A].nom != Constantes.NOM_DEFAUT_USER_A || data.lesUsers[Constantes.USER_B].nom != Constantes.NOM_DEFAUT_USER_B)
                {
                    txtUserA.Text = data.lesUsers[Constantes.USER_A].nom;
                    txtUserB.Text = data.lesUsers[Constantes.USER_B].nom;
                }

                else
                {
                    chargeNomDefaut();
                }

                chargeRepartitions(cboRepartition);

            }

            else // fichier vide
            {
                data = new AppData();

                data.lesUsers.Add(new User(Constantes.NOM_DEFAUT_USER_A));
                data.lesUsers.Add(new User(Constantes.NOM_DEFAUT_USER_B));
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

        private void chargeNomDefaut()
        {
            lblUserA.Text = Constantes.NOM_DEFAUT_USER_A + ":";
            lblUserB.Text = Constantes.NOM_DEFAUT_USER_B + ":";
            lblNomTotalUserA.Text = $"Total dettes {Constantes.NOM_DEFAUT_USER_A} :";
            lblNomTotalUserB.Text = $"Total dettes {Constantes.NOM_DEFAUT_USER_B} :";
        }

    }
}
