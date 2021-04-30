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
        //public static List<DistinctBudget> sortedBudgets { get; set; }

        public string[] userNames = new string[2];
        public List<Budget> allBudgets { get; }
        private string _month;
        private Dictionary<string, double> _dctDivisions;

        public AppData()
        {
            allBudgets = new List<Budget>();
            //sortedBudgets = new List<DistinctBudget>();
            _dctDivisions = new Dictionary<string, double>();
            initializeDivisions();
        }

        public void resetData()
        {
            _dctDivisions.Clear();
            initializeDivisions();
            User.setName(Const.USER_A, Const.DEFAULT_NAME_USER_A);
            User.setName(Const.USER_B, Const.DEFAULT_NAME_USER_B);
            allBudgets.Clear();
        }

        private void initializeDivisions()
        {
            foreach (KeyValuePair<string, double> pair in Const.initialDivision)
            {
                _dctDivisions.Add(pair.Key, pair.Value);
            }
        }

        public Dictionary<string, double> dctDivisions { get => _dctDivisions; }
        public string month { get => _month; set => _month = value; }

        public void storeUserData()
        {
            for (int userIndex = 0; userIndex < 2; userIndex++)
            {
                this.userNames[userIndex] = User.getName(userIndex);
            }
        }
    }

    [SerializableAttribute]
    public class MonthlySave
    {
        //private List<User> _allUsers;
        private List<Budget> _allBudgets;

        private int _month;
        private int _year;

        //public List<User> allUsers { get => _allUsers; set => _allUsers = value; }
        public List<Budget> allBudgets { get => _allBudgets; set => _allBudgets = value; }

        public MonthlySave(int month, int year, List<Budget> allBudgets)
        {
            _month = month;
            _year = year;
            _allBudgets = allBudgets;
            //_allUsers = allUsers;
        }

        public int year { get => _year; }

        public int month { get => _month; }

        /// <summary>
        /// Vérifie si une sauvegarde existe déjà parmi les existantes.
        /// </summary>
        /// <param name="allSaves">Liste des sauvegardes mensuelles.</param>
        /// <param name="selectedMonth">Numéro du mois sélectionné (1-12).</param>
        /// <param name="selectedYear">Année sélectionnée.</param>
        /// <returns></returns>
        public static MonthlySave findMonthlySave(List<MonthlySave> allSaves, int selectedMonth, int selectedYear)
            {
            MonthlySave existingSave = null;
            foreach (MonthlySave save in allSaves)
            {
                if (save.month == selectedMonth & save.year == selectedYear)
                {
                    existingSave = save;
                    break;
                }

            }
            return existingSave;
        }
        
        public static bool isNull(MonthlySave monthlySave)
        {
            if(monthlySave == null)
            {
                return true;
            }
            return false;
        }

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
            allMonthes = new List<Budget>();
            this.name = name;
        }

        public static void Clear()
        {
            totalExpenses = 0;

        }

        public List<Budget> allMonthes;
        
        public string name { get; set; }

        /// <summary>
        /// Additionne les dépenses des comptes du même nom.
        /// </summary>
        /// <returns>Total</returns>
        public double total()
        {
            double somme = 0;
            foreach(Budget budget in allMonthes)
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
            return allMonthes.Count;
        }

        private void addBudget(Budget budget)
        {
            allMonthes.Add(budget);
        }

        private static double totalExpenses = 0;
        private static void setTotalExpenses()
        {
            double somme = 0;
            foreach (DistinctBudget budget in sortedBudgets)
            {
                somme += budget.total();
            }
            totalExpenses= somme;
        }
        public static double getTotalExpenses()
        {
            if (totalExpenses == 0) setTotalExpenses();
            return totalExpenses;
        }

        //private static double totalAverage = 0;
        //public static void setTotalAverage(int count)
        //{
        //    totalAverage = getTotalExpenses() / count;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Retourne la moyenne des moyennes. Retourne -1 si la moyenne n'a pas été calculée.</returns>
        //public static double getTotalAverage()
        //{
        //    if (totalAverage == 0) return -1;
        //    return totalAverage;
            
        //}

        public static double totalEvolution(double totalMonthRef, double totalAverage)
        {
            return Math.Round((totalMonthRef - totalAverage) / totalAverage * 100, 2);
        }

        //public Budget getLastBudget()
        //{
        //    return allMonthes[allMonthes.Count-1];
        //}

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
                if(monthlySave.year == year)
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
        public static void sortBudgets(List<MonthlySave> allMonthlySaves, int monthStart, int yearStart, int monthStop, int yearStop)
        {
            if (yearStart > yearStop)
            {
                int temp = yearStop;
                yearStop = yearStart;
                yearStart = temp;
            }
            sortedBudgets.Clear();
            foreach (MonthlySave monthlySave in allMonthlySaves)
            {
                if (monthlySave.year >= yearStart && monthlySave.year <= yearStop)
                {
                    if(yearStart == yearStop)
                    {
                        if(monthlySave.month >= monthStart && monthlySave.month <= monthStop)
                        {
                            comparesBudgets(monthlySave);
                        }
                    }
                    else if (monthlySave.year == yearStart)
                    {
                        if (monthlySave.month >= monthStart)
                        {
                            comparesBudgets(monthlySave);
                        }
                    }
                    
                    else if(monthlySave.year == yearStop)
                    {
                        if(monthlySave.month <= monthStop)
                        {
                            comparesBudgets(monthlySave);
                        }
                    }

                    else
                    {
                        comparesBudgets(monthlySave);
                    }
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
                if (!exists) {
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

            if(saveRef != null)
            {
                foreach (Budget budget in saveRef.allBudgets)
                {
                    if (budget.name.ToUpper() == distinctBudget.name.ToUpper())
                    {
                        double expenses = budget.account.userA.expenses + budget.account.userB.expenses;
                        expensesMonthRef += expenses;
                        expensesRef  = expenses + "€";
                        evolution = distinctBudget.calculateEvolution(avg, budget).ToString() + "%";
                        break;
                    }
                }
                if (evolution == null) evolution = "-";
                if (expensesRef == null) expensesRef = "-";
            }

            average = avg + "€";
            proportion = Math.Round((total / DistinctBudget.getTotalExpenses())*100, 2).ToString() + "%";
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
                //row.average.Split('%')
            }
            return Math.Round((totalAverage / DataAnalysis.Items.Count),2);
        }

        // Méthodes Static 

        public static void Clear()
        {
            Items.Clear();
            expensesMonthRef = 0;

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

