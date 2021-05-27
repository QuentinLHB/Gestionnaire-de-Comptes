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

        public void finalizeMonth(List<MonthlySave> allMonthlySaves, DateTime date)
        {
            MonthlySave montlySave = new MonthlySave(date, data.allBudgets);
            allMonthlySaves.Add(montlySave);
            Serialise.Save(Const.FILE_MONTHLYRECAP, allMonthlySaves);
            saveData();
        }



        
    }
}
