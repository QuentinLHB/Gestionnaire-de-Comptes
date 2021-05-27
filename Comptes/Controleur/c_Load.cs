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
using Comptes.Constants;
using Comptes.Vue;


namespace Comptes.Control
{
    public partial class Controler
    {
        private frmMain frmMain;
        private FrmDivisions frmDivisions;
        private FrmMonthlySave frmSummary;
        private frmUsersNames frmUsersNames;
        bool flagDataChange = false;
        bool flagUserNameChange = false;
        AppData data;

        /// <summary>
        /// Point d'entrée de l'application. Initialise les éléments et ouvre le formulaire approprié.
        /// </summary>
        public Controler()
        {
            Const.initializeDivisions();
            loadData();
            if (User.areNamesDefault())
            {
                loadUsersNamesForm();
            }
            else
            {
                loadMainForm();
            }
        }

        /// <summary>
        /// Charge le formulaire permettant de changer les noms d'utilisateurs.
        /// </summary>
        public void loadUsersNamesForm()
        {
            frmUsersNames = new frmUsersNames(this, frmMain);
        }

        /// <summary>
        /// Charge le formulaire principal.
        /// </summary>
        public void loadMainForm()
        {
            frmMain = new frmMain(this);

            frmMain.ShowDialog();
        }

        /// <summary>
        /// Récupère les répartitions sauvegardées.
        /// </summary>
        /// <returns>Dictionnaire contenant le texte des répartitions et la valeur décimale.</returns>
        public Dictionary<string, double> getDivisions()
        {
            return data.dctDivisions;
        }

        /// <summary>
        /// Charge les données enregistrées.
        /// Si aucun fichier enregistré, crée deux users.
        /// </summary>
        public void loadData()
        {            
            Object obj = Serialise.Load(Const.FILE_DATA);

            if (obj != null)
            {
                data = (AppData)obj;
                User.initializeNames(data);
            }

            else // fichier vide
            {
                data = new AppData();
                User.initializeDefaultNames();
            }

            setFlagUserChange(change: false);
        }

        /// <summary>
        /// Récupère les sauvegardes mensuelles sérialisées.
        /// </summary>
        /// <returns>Liste des sauvegardes mensuelles.</returns>
        public List<MonthlySave> getMonthlySaves()
        {
            return (List<MonthlySave>)Serialise.Load(Const.FILE_MONTHLYRECAP);
        }

        /// <summary>
        /// Charge les données dans le formulaire principal
        /// </summary>
        /// <param name="monthlySave"></param>
        public void loadMontlySave(DateTime dateToLoad)
        {
            MonthlySave monthlySave = MonthlySave.findMonthlySave(getMonthlySaves(), dateToLoad);
            data.allBudgets.Clear();
            data.allAccounts.Clear();
            foreach (Budget budget in monthlySave.allBudgets)
            {
                data.allBudgets.Add(budget);
                data.allAccounts.Add(budget.account);
            }
            frmMain.loadMonthlySave(monthlySave.Date);
        }

    }
}
