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


namespace Comptes.Control
{
    public partial class Controler
    {
        private frmMain frmMain;
        private FrmDivisions frmDivisions;
        private FrmMonthlySave frmSummary;
        bool flagDataChange = false;
        bool flagUserNameChange = false;
        AppData data;

        public Controler(frmMain vue)
        {
            frmMain = vue;
        }

        public Dictionary<string, double> getDivisions()
        {
            return data.dctDivisions;
        }



        public List<int> getExistingYears()
        {
            List<MonthlySave> allMonthlySaves = (List<MonthlySave>)Serialise.Load(Const.FILE_MONTHLYRECAP);
            
            List<int> lstYears = new List<int>();
            foreach (MonthlySave save in allMonthlySaves)
            {
                bool exists = false;
                foreach (int item in lstYears)
                {
                    if (save.year == item)
                    {
                        exists = true;
                        break;
                    }
                }
                if (exists == false)
                {
                    lstYears.Add(save.year);
                }
            }
            return lstYears;
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
                // Si les noms enregistrés ne sont pas ceux par défaut
                if (User.getName(Const.USER_A) != Const.DEFAULT_NAME_USER_A || (User.getName(Const.USER_B)) != Const.DEFAULT_NAME_USER_B)
                {
                    frmMain.setUsersTextBox(User.getName(Const.USER_A), User.getName(Const.USER_B));
                }

                else
                {
                    frmMain.setDefaultName();
                }                

            }

            else // fichier vide
            {
                data = new AppData();
                User.initializeStaticData();
                frmMain.setDefaultName();
                //frmMain.loadDivisions()
                //getDivisions(cboDivisions);
                // Attention il y avait quelque chose ici que j'ai refactor mais je ne retrouve pas l'utilisation.
            }

            if (data.allBudgets != null)
            {
                foreach (Budget budget in data.allBudgets)
                {
                    frmMain.fillLists(budget.ToString(), budget.account.ToString());
                }
            }

            setFlagUserChange(change: false);

        }
    }
}
