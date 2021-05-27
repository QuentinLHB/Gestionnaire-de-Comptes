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
        /// <summary>
        /// Instance unique d'AppData
        /// </summary>
        private static AppData instance;
        /// <summary>
        /// Noms des deux utilisateurs.
        /// </summary>
        public string[] usersNames { get; set; } = new string[2];
        /// <summary>
        /// Liste des budgets à afficher dans la vue.
        /// </summary>
        public List<Budget> allBudgets { get; set; } = new List<Budget>();
        /// <summary>
        /// Liste des comptes à afficher dans la vue.
        /// </summary>
        public List<Account> allAccounts { get; } = new List<Account>();
        /// <summary>
        /// Répartitions : Dans la clé, le texte, dans la valeur, la décimale
        /// </summary>
        /// <example>"20/80" - 0.2</example>
        public Dictionary<string, double> dctDivisions { get; } = new Dictionary<string, double>();

        /// <summary>
        /// Constructeur privé de la classe singleton AppData.
        /// </summary>
        private AppData()
        {
            usersNames[Const.USER_A] = Const.DEFAULT_NAME_USER_A;
            usersNames[Const.USER_B] = Const.DEFAULT_NAME_USER_B;
            initializeDivisions();
        }

        /// <summary>
        /// Récupère ou crée l'instance unique d'AppData.
        /// </summary>
        /// <returns></returns>
        public static AppData getAppData()
        {
            if(instance == null)
            {
                instance = new AppData();
            }

            return instance;
        }
        /// <summary>
        /// Réinitialise les répartitions par défaut, les noms d'utilisateurs par défaut, et efface les budgets et les comptes.
        /// </summary>
        public void Clear()
        {
            dctDivisions.Clear();
            initializeDivisions();
            User.setName(Const.USER_A, Const.DEFAULT_NAME_USER_A);
            User.setName(Const.USER_B, Const.DEFAULT_NAME_USER_B);
            allBudgets.Clear();
            allAccounts.Clear();
        }
        /// <summary>
        /// Initialise les répartitions dans le dictionnaire.
        /// </summary>
        private void initializeDivisions()
        {
            foreach (KeyValuePair<string, double> pair in Const.initialDivision)
            {
                dctDivisions.Add(pair.Key, pair.Value);
            }
        }

        /// <summary>
        /// Sauvegarde les noms enregistrés dans les objets User.
        /// </summary>
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
        /// <summary>
        /// Liste des budgets d'un mois.
        /// </summary>
        public List<Budget> allBudgets { get; set; }
        /// <summary>
        /// Mois et année concernés par la sauvegarde.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Constructeur d'une sauvegarde mensuelle.
        /// </summary>
        /// <param name="date">Date concernée par la sauvegarde.</param>
        /// <param name="allBudgets">Liste des budgets de la sauvegarde.</param>
        public MonthlySave(DateTime date, List<Budget> allBudgets)
        {
            this.Date = date;
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

        /// <summary>
        /// Détermine la date minimale de toutes les saves passées en paramètre.
        /// </summary>
        /// <param name="allSaves">Sauvegardes dans lequelles faire la recherche.</param>
        /// <returns>La date minimale.</returns>
        public static DateTime getMinDate(List<MonthlySave> allSaves)
        {
            DateTime min = DateTime.Today;

            foreach(MonthlySave save in allSaves)
            {
                if(save.Date.CompareTo(min) < 0)
                {
                    min = save.Date;
                }
            }
            return min;
        }

        /// <summary>
        /// Détermine la date maximale de toutes les saves passées en paramètre.
        /// </summary>
        /// <param name="allSaves">Sauvegardes dans lequelles faire la recherche.</param>
        /// <returns>La date maximale.</returns>
        public static DateTime getMaxDate(List<MonthlySave> allSaves)
        {
            DateTime max = new DateTime();

            foreach(MonthlySave save in allSaves)
            {
                if(save.Date.CompareTo(max) > 0)
                {
                    max = save.Date;
                }
            }
            return max;
        }

        public static MonthlySave getMostRecentSave(List<MonthlySave> allSaves)
        {
            MonthlySave mostRecentSave = null;

            foreach (MonthlySave save in allSaves)
            {
                if (save.Date.CompareTo(mostRecentSave.Date) > 0)
                {
                    mostRecentSave = save;
                }
            }
            return mostRecentSave;
        }

        /// <summary>
        /// Vérifie si une sauvegarde mensuelle est nulle.
        /// </summary>
        /// <param name="monthlySave">Sauvegarde à vérifier.</param>
        /// <returns>True si null, false sinon.</returns>
        public static bool isNull(MonthlySave monthlySave)
        {
            return (monthlySave == null);
        }

    }

    /// <summary>
    /// Classe conteneure des objets à entrer dans le tableau de chargement des sauvegardes mensuelles.
    /// Un objet = un budget = une ligne.
    /// </summary>
    public class DataMonthlySave
    {
        /// <summary>
        /// Nom du budget.
        /// </summary>
        public string accountName { get; set; }
        /// <summary>
        /// Nom de l'utilisateur A.
        /// </summary>
        public static string nameUserA { get; set; }
        /// <summary>
        /// Nom de l'utilisateur B.
        /// </summary>
        public static string nameUserB { get; set; }
        /// <summary>
        /// Dépenses de l'utilisateur A.
        /// </summary>
        public string expensesA { get; set; }
        /// <summary>
        /// Dépenses de l'utilisateur B.
        /// </summary>
        public string expensesB { get; set; }
        /// <summary>
        /// Dépenses totales.
        /// </summary>
        public string total { get; set; }
        /// <summary>
        /// Constructeur des données d'affichage
        /// </summary>
        /// <param name="accountName">Nom du budget</param>
        /// <param name="expensesA">Dépenses de l'utilisateur A.</param>
        /// <param name="expensesB">Dépenses de l'utilisateur B.</param>
        public DataMonthlySave(string accountName, double expensesA, double expensesB)
        {
            this.accountName = accountName;
            this.expensesA = expensesA + "€";
            this.expensesB = expensesB + "€";
            this.total = (expensesA + expensesB) + "€";
            DataMonthlySave.nameUserA = User.getName(Const.USER_A);
            DataMonthlySave.nameUserB = User.getName(Const.USER_B);
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

        /// <summary>
        /// Réinitialise les dépenses d'un budget.
        /// </summary>
        public static void Clear()
        {
            totalExpenses = 0;
        }

        /// <summary>
        /// Liste des budgets dont le nom est le même (dinstinct).
        /// </summary>
        public List<Budget> allMonths { get; }

        /// <summary>
        /// Nom du budget distinct.
        /// </summary>
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
        /// <returns>Nombre de mois où apparaît le budget.</returns>
        public int occurence()
        {
            return allMonths.Count;
        }

        /// <summary>
        /// Ajoute un budget à la liste des budgets.
        /// </summary>
        /// <param name="budget"></param>
        private void addBudget(Budget budget)
        {
            allMonths.Add(budget);
        }

        /// <summary>
        /// Dépenses totales de tous les budgets.
        /// </summary>
        private static double totalExpenses = 0;
        /// <summary>
        /// Détermine le total des dépenses de chaque budget distinct.
        /// </summary>
        private static void setTotalExpenses()
        {
            double somme = 0;
            foreach (DistinctBudget budget in sortedBudgets)
            {
                somme += budget.total();
            }
            totalExpenses = somme;
        }

        /// <summary>
        /// Retourne le total des dépenses de tous les budgets distincts cumulés.
        /// </summary>
        /// <returns></returns>
        public static double getTotalExpenses()
        {
            if (totalExpenses == 0) setTotalExpenses();
            return totalExpenses;
        }

        /// <summary>
        /// Evolution entre le mois en cours et la moyenne.
        /// </summary>
        /// <param name="average">Moyenne du budget</param>
        /// <param name="budget">Budget en question.</param>
        /// <example>Moyenne Budget : 100 ; Budget Mois N : 120 = ((120-100)/100)*100 = 20. </example>
        /// <returns>L'écart au budget, au format entier.</returns>
        public double calculateEvolution(double average, Budget budget)
        {
            double totalLastBudget = budget.account.userA.expenses + budget.account.userB.expenses;
            double evolution = ((totalLastBudget - average) / average) * 100;
            return Math.Round(evolution, 2);
        }


        public static double totalEvolution(double totalMonthRef, double totalAverage)
        {
            return Math.Round((totalMonthRef - totalAverage) / totalAverage * 100, 2) ;
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

