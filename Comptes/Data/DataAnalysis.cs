using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comptes.Model;

namespace Comptes.Data
{

    public class DataAnalysis
    {
        // Champs

        public string budget { get; set; }
        public string expensesRef { get; set; }
        public string total { get; set; }
        public string average { get; set; }
        public string evolution { get; set; }
        public string proportion { get; set; }

        // Champs static
        public static List<DataAnalysis> Items = new List<DataAnalysis>();
        public static double expensesMonthRef = 0;

        // Constructeurs

        /// <summary>
        /// Constructeur des lignes pour liaison en datasource
        /// </summary>
        /// <param name="distinctBudget">Groupe de budgets du même nom. = Une ligne.</param>
        /// <param name="saveRef">Sauvegarde de référence si sélectionnée, sinon null.</param>
        public DataAnalysis(DistinctBudget distinctBudget, MonthlySave saveRef = null)
        {
            budget = distinctBudget.name;
            double total = distinctBudget.total();

            double avg = total / distinctBudget.occurence();
            avg = Math.Round(avg, 2);

            if (saveRef != null)
            {
                foreach (Budget budget in saveRef.allBudgets)
                {
                    if (budget.name.ToUpper() == distinctBudget.name.ToUpper())
                    {
                        double expenses = budget.account.userA.expenses + budget.account.userB.expenses;
                        expensesMonthRef += expenses;
                        expensesRef = expenses + "€";
                        evolution = distinctBudget.calculateEvolution(avg, budget).ToString() + "%";
                        break;
                    }
                }
                if (evolution == null) evolution = "-";
                if (expensesRef == null) expensesRef = "-";
            }

            average = avg + "€";
            proportion = Math.Round((total / DistinctBudget.getTotalExpenses()) * 100, 2).ToString() + "%";
            this.total = total + "€";
            Items.Add(this);
        }

        /// <summary>
        /// Constructeur de la ligne "total".
        /// </summary>
        public DataAnalysis()
        {
            budget = "TOTAL";
            total = DistinctBudget.getTotalExpenses().ToString() + "€";
            expensesRef = expensesMonthRef.ToString() + "€";
            double totalAverage = calculateTotalAverage();
            average = totalAverage.ToString() + "€";
            evolution = DistinctBudget.totalEvolution(DataAnalysis.expensesMonthRef, totalAverage).ToString() + "%";
            proportion = "100%";
        }

        private double calculateTotalAverage()
        {
            double totalAverage = 0;
            foreach (DataAnalysis row in DataAnalysis.Items)
            {
                totalAverage += double.Parse(row.average.Split('€')[0]);
            }
            return Math.Round(totalAverage, 2);
        }

        // Méthodes Static 

        public static void Clear()
        {
            Items.Clear();
            expensesMonthRef = 0;

        }

    }
}