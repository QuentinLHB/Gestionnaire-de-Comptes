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
        /// Récupère la liste des sauvegardes mensuelles, les trie et les stocke.
        /// </summary>
        public void sortBudgets()
        {
            DistinctBudget.sortBudgets((List<MonthlySave>)Serialise.Load(Const.FILE_MONTHLYRECAP));
        }
        public void sortBudgets(int year)
        {
            DistinctBudget.sortBudgets((List<MonthlySave>)Serialise.Load(Const.FILE_MONTHLYRECAP), year);
        }
        public void sortBudgets(int monthStart, int yearStart, int monthStop, int yearStop)
        {
            DistinctBudget.sortBudgets((List<MonthlySave>)Serialise.Load(Const.FILE_MONTHLYRECAP), monthStart, yearStart, monthStop, yearStop);
        }


        public List<DistinctBudget> getSortedBudgets()
        {
            return DistinctBudget.getSortedBudget();
        }

        /// <summary>
        /// Convertit l'index des combobox de mois en le numéro de mois de 1 à 12.
        /// </summary>
        /// <param name="monthIndex"></param>
        public int monthNumber(int monthIndex)
        {
            monthIndex = (monthIndex + 1) % 12;
            if (monthIndex == 0) monthIndex = 12;
            return monthIndex;
        }
    }
}
