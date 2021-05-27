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
            DistinctBudget.sortBudgets(getMonthlySaves());
        }
        public void sortBudgets(int year)
        {
            DistinctBudget.sortBudgets(getMonthlySaves(), year);
        }
        public void sortBudgets(DateTime dateStart, DateTime dateStop)
        {
            DistinctBudget.sortBudgets(getMonthlySaves(), dateStart, dateStop);
        }

        public List<DistinctBudget> getSortedBudgets()
        {
            return DistinctBudget.getSortedBudget();
        }


    }
}
