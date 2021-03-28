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
        /// <summary>
        /// Retourne les dettes des deux utilisateurs.
        /// </summary>
        /// <returns>Un array de deux doubles des dettes des utilisateurs.</returns>
        public double[] getDebts()
        {
            Budget.calculateDebts(data.allBudgets);
            double[] usersDebts = { User.getDebts(Const.USER_A), User.getDebts(Const.USER_B) };
            return usersDebts;
            
        }
        /// <summary>
        /// Met à jour les totaux de dettes
        /// </summary>
        /// <returns> La valeur totale a afficher.</returns>
        public string updateTotals()
        {
            frmMain.refreshDebts();

            double result = User.getDebts(Const.USER_A) - User.getDebts(Const.USER_B);


            if (result > 0)
            {
                return Const.debtDisplay(User.getName(Const.USER_A), result);
            }

            else if (result < 0)
            {
                return Const.debtDisplay(User.getName(Const.USER_B), -result);
            }

            else
            {
                return Const.BALANCEDRESULT;
            }
        }

        public void finalizeMonth(List<MonthlySave> allMonthlySaves, int month, int year)
        {
            MonthlySave montlySave = new MonthlySave(
                month: month,
                year: year,
                allBudgets: data.allBudgets);

            allMonthlySaves.Add(montlySave);
            Serialise.Save(Const.FILE_MONTHLYRECAP, allMonthlySaves);

            saveData();
        }

        /// <summary>
        /// Enregistre les données du mois.
        /// </summary>
        /// <param name="month">Mois à sauvegarder.</param>
        /// <param name="year">Année à sauvegarder.</param>
        public void finalizeMonthDialogs(int month, int year)
        {
            // S'il n'y a pas de budget
            if (data.allBudgets.Count != 0)
            {
                if ((MessageBox.Show(Const.MSG_VALIDATIONMONYLYSAVE, Const.MSG_TITLE_VALIDATIONMONYLYSAVE, MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    List<MonthlySave> allMonthlySaves = (List<MonthlySave>)Serialise.Load(Const.FILE_MONTHLYRECAP);
                    if (allMonthlySaves == null)
                    {
                        allMonthlySaves = new List<MonthlySave>();
                    }

                    MonthlySave existingSave = MonthlySave.findMonthlySave(allMonthlySaves, month, year);
                    if (existingSave == null)
                    {
                        finalizeMonth(allMonthlySaves, month, year);
                    }

                    else //Si une save existe
                    {
                        // Si souhaite écraser
                        if (MessageBox.Show(Const.MSG_REPLACE, Const.ERROR, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            allMonthlySaves.Remove(existingSave);
                            finalizeMonth(allMonthlySaves, month, year);
                            MessageBox.Show(Const.MSG_REPLACE_YES, Const.MSG_TITLE_REPLACE, MessageBoxButtons.OK);
                        }

                        // Si ne souhaite pas écraser
                        else
                        {
                            MessageBox.Show(Const.MSG_REPLACE_NO, Const.MSG_TITLE_REPLACE, MessageBoxButtons.OK);
                        }
                    }

                }
            }

            else
            {
                MessageBox.Show(Const.MSG_ERR_FINALIZE, Const.ERROR, MessageBoxButtons.OK);
            }
        }
    }
}
