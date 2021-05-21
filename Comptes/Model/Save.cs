using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Comptes.Control;
using Comptes.Constants;
using Comptes.Model;

namespace Comptes.Model
{
    [SerializableAttribute]
    public class AppData
    {
        public string[] usersNames { get; set; } = new string[2];
        public List<Budget> allBudgets { get; } = new List<Budget>();

        public List<Account> allAccounts { get; } = new List<Account>();
        public Dictionary<string, double> dctDivisions { get; } = new Dictionary<string, double>();

        public AppData()
        {
            usersNames[Const.USER_A] = Const.DEFAULT_NAME_USER_A;
            usersNames[Const.USER_B] = Const.DEFAULT_NAME_USER_B;
            initializeDivisions();
        }

        public void resetData()
        {
            dctDivisions.Clear();
            initializeDivisions();
            User.setName(Const.USER_A, Const.DEFAULT_NAME_USER_A);
            User.setName(Const.USER_B, Const.DEFAULT_NAME_USER_B);
            allBudgets.Clear();
        }

        private void initializeDivisions()
        {
            foreach (KeyValuePair<string, double> pair in Const.initialDivision)
            {
                dctDivisions.Add(pair.Key, pair.Value);
            }
        }


        public void storeUserData()
        {
            for (int userIndex = 0; userIndex < 2; userIndex++)
            {
                this.usersNames[userIndex] = User.getName(userIndex);
            }
        }

        
    }

    [SerializableAttribute]
    public class MonthlySave
    {
        public List<Budget> allBudgets { get; set; }
        public DateTime Date { get; set; }

        public MonthlySave(DateTime date, List<Budget> allBudgets)
        {
            Date = date;
            this.allBudgets = allBudgets;
        }


        /// <summary>
        /// Vérifie si une sauvegarde existe déjà parmi les existantes.
        /// </summary>
        /// <param name="allSaves">Liste des sauvegardes mensuelles.</param>
        /// <param name="selectedMonth">Numéro du mois sélectionné (1-12).</param>
        /// <param name="selectedYear">Année sélectionnée.</param>
        /// <returns></returns>
        public static MonthlySave findMonthlySave(List<MonthlySave> allSaves, DateTime monthToFind)
        {
            return allSaves.Find(o => o.Date.Equals(monthToFind));
        }

        public static bool isNull(MonthlySave monthlySave)
        {
            if (monthlySave == null)
            {
                return true;
            }
            return false;
        }

    }

    public class DataMonthlyReport
    {
        public string accountName { get; set; }
        public static string nameUserA { get; set; }
        public static string nameUserB { get; set; }
        public string expensesA { get; set; }
        public string expensesB { get; set; }
        public string total { get; set; }

        public DataMonthlyReport(string accountName, double expensesA, double expensesB)
        {
            this.accountName = accountName;
            this.expensesA = expensesA + "€";
            this.expensesB = expensesB + "€";
            this.total = (expensesA + expensesB) + "€";
            DataMonthlyReport.nameUserA = User.getName(Const.USER_A);
            DataMonthlyReport.nameUserB = User.getName(Const.USER_B);
        }
    }






    /// <summary>
    /// Entité regroupant les données de tous les objets "Budget" portant le même nom.
    /// </summary>
    public class DistinctBudget
    {
        /// <summary>
        /// CONSTRUCTEUR
        /// </summary>
        /// <param name="name">Nom du budget</param>
        /// <param name="initialValue">Première valeur à ajouter au total du budget de ce nom.</param>
        public DistinctBudget(string name)
        {
            allMonths = new List<Budget>();
            this.name = name;
        }

        public static void Clear()
        {
            totalExpenses = 0;

        }

        public List<Budget> allMonths { get; }

        public string name { get; set; }

        /// <summary>
        /// Additionne les dépenses des comptes du même nom.
        /// </summary>
        /// <returns>Total</returns>
        public double total()
        {
            double somme = 0;
            foreach (Budget budget in allMonths)
            {
                somme += budget.account.userA.expenses + budget.account.userB.expenses;
            }
            return Math.Round(somme, 2);
        }

        /// <summary>
        /// Compte le nombre de fois où apparaît le budget.
        /// </summary>
        /// <returns></returns>
        public int occurence()
        {
            return allMonths.Count;
        }

        private void addBudget(Budget budget)
        {
            allMonths.Add(budget);
        }

        private static double totalExpenses = 0;
        private static void setTotalExpenses()
        {
            double somme = 0;
            foreach (DistinctBudget budget in sortedBudgets)
            {
                somme += budget.total();
            }
            totalExpenses = somme;
        }
        public static double getTotalExpenses()
        {
            if (totalExpenses == 0) setTotalExpenses();
            return totalExpenses;
        }

        public static double totalEvolution(double totalMonthRef, double totalAverage)
        {
            return Math.Round((totalMonthRef - totalAverage) / totalAverage * 100, 2);
        }

        public double calculateEvolution(double average, Budget budget)
        {

            double totalLastBudget = budget.account.userA.expenses + budget.account.userB.expenses;
            double evolution = ((totalLastBudget - average) / average) * 100;
            return Math.Round(evolution, 2);
        }

        /// <summary>
        /// Trie tous les budgets des sauvegardes.
        /// </summary>
        /// <param name="allMonthlySaves">Liste des sauvegardes mensuelles</param>
        public static void sortBudgets(List<MonthlySave> allMonthlySaves)
        {
            sortedBudgets.Clear();
            foreach (MonthlySave monthlySave in allMonthlySaves)
            {
                comparesBudgets(monthlySave);
            }
        }

        /// <summary>
        /// Trie les budgets selon une année.
        /// </summary>
        /// <param name="allMonthlySaves">Liste des sauvegardes mensuelles</param>
        /// <param name="year">Année sur laquelle doit s'opérer le tri.</param>
        public static void sortBudgets(List<MonthlySave> allMonthlySaves, int year)
        {
            sortedBudgets.Clear();
            foreach (MonthlySave monthlySave in allMonthlySaves)
            {
                if (monthlySave.Date.Year == year)
                {
                    comparesBudgets(monthlySave);
                }
            }
        }

        /// <summary>
        /// Trie les budgets selon deux dates
        /// </summary>
        /// <param name="allMonthlySaves">Liste des sauvegardes mensuelles</param>
        /// <param name="monthStart">Mois à partir duquel commencer</param>
        /// <param name="yearStart">Année à partir de laquelle commencer</param>
        /// <param name="monthStop">Mois auquel arrêter</param>
        /// <param name="yearStop">Année à laquelle arrêter</param>
        public static void sortBudgets(List<MonthlySave> allMonthlySaves, DateTime start, DateTime stop)
        {
            if (DateTime.Compare(start, stop) > 0)
            {
                DateTime temp = stop;
                stop = start;
                start = temp;
            }
            sortedBudgets.Clear();
            foreach (MonthlySave monthlySave in allMonthlySaves)
            {
                if (DateTime.Compare(monthlySave.Date, start.Date) >= 0 && DateTime.Compare(monthlySave.Date, stop) <= 0)
                {
                    comparesBudgets(monthlySave);
                }
            }
        }

        private static void comparesBudgets(MonthlySave monthlySave)
        {
            bool exists;
            foreach (Budget budget in monthlySave.allBudgets)
            {
                exists = false;
                foreach (DistinctBudget distinctBudget in sortedBudgets)
                {
                    if (budget.name.ToUpper() == distinctBudget.name.ToUpper())
                    {
                        exists = true;
                        distinctBudget.addBudget(budget);
                    }

                }
                if (!exists)
                {
                    DistinctBudget distinctBudget = new DistinctBudget(budget.name);
                    distinctBudget.addBudget(budget);
                    sortedBudgets.Add(distinctBudget);

                }
            }
        }

        public static List<DistinctBudget> sortedBudgets = new List<DistinctBudget>();
        public static List<DistinctBudget> getSortedBudget()
        {
            return sortedBudgets;
        }
    }



    public abstract class Serialise
    {
        /// <summary>
        /// Sérialisation
        /// </summary>
        /// <param name="file">nom du fichier de sauvegarde</param>
        /// <param name="obj">objet à sérialiser</param>
        public static void Save(string file, Object obj)
        {
            // si le fichier existe, il faut le supprimer
            if (File.Exists(file))
            {
                File.Delete(file);
            }
            // création du flux pour l'écriture dans le fichier
            FileStream flux = new FileStream(file, FileMode.Create);
            // création d'un objet pour le formatage en binaire des informations
            BinaryFormatter fbinaire = new BinaryFormatter();
            // sérialisation des objets de la collection
            fbinaire.Serialize(flux, obj);
            // fermeture du flux
            flux.Close();
        }

        /// <summary>
        /// Désérialisation
        /// </summary>
        /// <param name="file">nom du fichier de sauvegarde</param>
        /// <returns>objet désérialisé</returns>
        public static Object Load(string file)
        {
            // Contrôle de l'existance du fichier
            if (File.Exists(file))
            {
                // ouverture du flux pour la lecture dans le fichier
                FileStream flux = new FileStream(file, FileMode.Open);
                // création d'un objet pour le formatage en binaire des informations
                BinaryFormatter fbinaire = new BinaryFormatter();
                // récupération de l'objet sérialisé
                try
                {
                    Object obj = fbinaire.Deserialize(flux);
                    // fermeture du flux
                    flux.Close();
                    // retour de l'objet
                    return obj;
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}

