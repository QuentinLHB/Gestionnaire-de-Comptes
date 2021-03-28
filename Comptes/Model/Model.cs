using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Comptes.Control;
using Comptes.Constants;

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

    }



    [SerializableAttribute]
    public class Budget
    {
        private Account _account;
        private string _name;
        private double _division;

        public Budget(string name, double division)
        {
            this._name = name;
            this._division = division;
            _account = new Account(this);
        }

        public Account account { 
            get => _account;
            }

        public string name { get => _name ; set => _name = value; }

        public double division { get => _division; set => _division = value; }

        public override string ToString()
        {
            return name + " : " + (division * 100).ToString() + " / " + (100 - division * 100).ToString();
        }

        public string displayBudgetName()
        {
            return name + " : ";
        }

        /// <summary>
        /// Calcule les dettes totales et met à jour l'objet User.
        /// </summary>
        /// <param name="allBudgets"></param>
        public static void calculateDebts(List<Budget> allBudgets)
        {
            double totalDebtsUserA = 0;
            double totalDebtsUserB = 0;
            foreach (Budget budget in allBudgets)
            {
                totalDebtsUserA += budget.account.userB.expenses * budget.division;
                totalDebtsUserB += budget.account.userA.expenses * (1 - budget.division);
            }

            User.setDebts(Const.USER_A, Math.Round(totalDebtsUserA, 2));
            User.setDebts(Const.USER_B, Math.Round(totalDebtsUserB, 2));

            //double[] totalDebts = { Math.Round(totalDebtsUserA, 2), Math.Round(totalDebtsUserB, 2) };
            //return totalDebts;
        }

        
    }

    [SerializableAttribute]
    public class Account 
    {
        private User _userA;
        private User _userB;
        private Budget _budget;


        public Account(Budget budget)
        {
            this._budget = budget;
            this._userA = new User();
            this._userB = new User();
        }
        public User userA { get => _userA; }
        public User userB { get => _userB; }

        public Budget budget { get => _budget; }

        public override string ToString()
        {
            if (this.userA.expenses != 0 || this.userB.expenses != 0)
            {
                return ($"{_budget.name} : [{User.getName(Const.USER_A)} {_userA.expenses}] [{User.getName(Const.USER_B)} {_userB.expenses}]");
            }

            else
            {
                return _budget.name + " : ";
            }

        }

        public void reset()
        {
            _userA.expenses = 0;
            _userB.expenses= 0;
        }


    }

    [SerializableAttribute]
    public class User
    {
        private static string[] names = new string[2];
        private static double[] debts = new double[2];
        //private static string _name;
        private double _debts;
        private double _expenses;

        public static void initializeStaticData()
        {
            names[Const.USER_A] = Const.DEFAULT_NAME_USER_A;
            names[Const.USER_B] = Const.DEFAULT_NAME_USER_B;
            
        }

        public static void initializeNames(AppData data)
        {
            names[Const.USER_A] = data.userNames[Const.USER_A];
            names[Const.USER_B] = data.userNames[Const.USER_B];
        }

        public static void Clear()
        {

        }
        //public static string name { get => _name; set => _name = value; }

        public static string getName(int index)
        {
            return names[index];
        }

        public static void setName(int index, string name)
        {
            names[index] = name;
        }

        public static double getDebts(int index)
        {
            return debts[index];
        }

        public static void setDebts(int index, double debt)
        {
            debts[index] = debt;
        }

        public double expenses { get => _expenses; set => _expenses = value; }

        //public double debts { get => _debts; set => _debts = value; }

        public static string displayName(int index)
        {
            return names[index] + " : ";
        }

        public static string displayDebts(int index)
        {
            return ($"Total dettes {names[index]} :");
        }

        public User(string name = "")
        {
            //User._name = name;
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
            //this.nameUserB = nameUserB;
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

        public List<Budget> allMonthes;
        
        public string name { get; set; }

        /// <summary>
        /// Additionne les dépenses des comptes du même nom.
        /// </summary>
        /// <returns>Total</returns>
        public double getTotal()
        {
            double somme = 0;
            foreach(Budget budget in allMonthes)
            {
                somme += budget.account.userA.expenses + budget.account.userB.expenses;
            }
            return Math.Round(somme, 2);
        }

        public int getOccurence()
        {
            return allMonthes.Count;
        }

        public void addBudget(Budget budget)
        {
            allMonthes.Add(budget);
        }

        public static double getTotalExpenses()
        {
            double somme = 0;
            foreach (DistinctBudget budget in sortedBudgets)
            {
                somme += budget.getTotal();
            }
            return somme;
        }

        public Budget getLastBudget()
        {
            return allMonthes[allMonthes.Count-1];
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
        //private MonthlySave saveRef;
        public string budget { get; set; }

        public string expensesRef { get; set; }

        public string total { get; set; }
        public string average { get; set; }

        public string evolution { get; set; }
        public string proportion { get; set; }

        public DataAnalysis(DistinctBudget distinctBudget, MonthlySave saveRef = null)
        {
            //this.saveRef = saveRef;
            budget = distinctBudget.name;
            double total = distinctBudget.getTotal();
                   
            double avg = total / distinctBudget.getOccurence();
            avg = Math.Round(avg, 2);

            if(saveRef != null)
            {
                foreach (Budget budget in saveRef.allBudgets)
                {
                    if (budget.name.ToUpper() == distinctBudget.name.ToUpper())
                    {
                        expensesRef = budget.account.userA.expenses + budget.account.userB.expenses + "€";
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
