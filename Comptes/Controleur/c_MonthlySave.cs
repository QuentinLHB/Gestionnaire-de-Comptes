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
        public DateTime getMinDate()
        {
            return MonthlySave.getMinDate(getMonthlySaves());
        }

        /// <summary>
        /// Récupère la date de la save la plus récente.
        /// </summary>
        /// <returns></returns>
        public DateTime getMaxDate()
        {
            return MonthlySave.getMaxDate(getMonthlySaves());
        }

        /// <summary>
        /// Récupère la save la plus récente.
        /// </summary>
        /// <returns></returns>
        public MonthlySave getMostRecentSave()
        {
            return MonthlySave.getMostRecentSave(getMonthlySaves());
        }

        /// <summary>
        /// Enregistre les données du mois.
        /// </summary>
        /// <param name="month">Mois à sauvegarder.</param>
        /// <param name="year">Année à sauvegarder.</param>
        public void finalizeMonthDialogs(DateTime date)
        {
            List<MonthlySave> allMonthlySaves = getMonthlySaves();
            if (allMonthlySaves == null)
            {
                allMonthlySaves = new List<MonthlySave>();
            }

            MonthlySave existingSave = MonthlySave.findMonthlySave(allMonthlySaves, date);
            if (existingSave == null)
            {
                finalizeMonth(allMonthlySaves, date);
            }

            else //Si une save existe
            {
                // Si souhaite écraser
                if (MessageBox.Show(Const.MSG_REPLACE, Const.ERROR, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    allMonthlySaves.Remove(existingSave);
                    finalizeMonth(allMonthlySaves, date);
                    MessageBox.Show(Const.MSG_REPLACE_YES, Const.MSG_TITLE_REPLACE, MessageBoxButtons.OK);
                }

                // Si ne souhaite pas écraser
                else
                {
                    MessageBox.Show(Const.MSG_REPLACE_NO, Const.MSG_TITLE_REPLACE, MessageBoxButtons.OK);
                }
            }
        }

        /// <summary>
        /// Vérifie si une date existe.
        /// </summary>
        /// <returns>True si une date est trouvée, false sinon.</returns>
        public bool checkForASave(DateTime date)
        {
            date = formatDate(date);
            return (MonthlySave.findMonthlySave(getMonthlySaves(), date) != null);
        }


        public List<DataMonthlySave> dataMonthlySave(DateTime monthToLoad)
        {
            var allDataMonthlySave = new List<DataMonthlySave>();
            foreach (Budget budget in MonthlySave.findMonthlySave(getMonthlySaves(), monthToLoad).allBudgets)
            {
                allDataMonthlySave.Add(new DataMonthlySave(
                   accountName: budget.name,
                   expensesA: budget.account.userA.expenses,
                   expensesB: budget.account.userB.expenses));
            }

            return allDataMonthlySave;
        }

        public bool deleteMonthlySave(DateTime monthToDelete)
        {
            List<MonthlySave> allSaves = getMonthlySaves();
            MonthlySave monthlySave = MonthlySave.findMonthlySave(allSaves, formatDate(monthToDelete));
            bool ok = allSaves.Remove(monthlySave);
            Serialise.Save(Const.FILE_MONTHLYRECAP, allSaves);
            return ok;
        }
    }
}
