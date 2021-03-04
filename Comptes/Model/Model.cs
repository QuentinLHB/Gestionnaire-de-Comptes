using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Comptes.Controleur;

namespace Comptes.Model
{
    [SerializableAttribute]
    public class AppData
    {
        public string[] userNames = new string[2];
        //public string[] userDebts = new string[2];
        public List<Budget> allBudgets { get; }
        private string _month;
        private Dictionary<string, double> _dctDivisions;

        public AppData()
        {
            //allUsers = new List<User>();
            allBudgets = new List<Budget>();
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

        private string _month;
        private string _year;

        //public List<User> allUsers { get => _allUsers; set => _allUsers = value; }
        public List<Budget> allBudgets { get => _allBudgets; set => _allBudgets = value; }

        public MonthlySave(string month, string year, List<Budget> allBudgets)
        {
            _month = month;
            _year = year;
            _allBudgets = allBudgets;
            //_allUsers = allUsers;
        }

        public string year { get => _year; }
        public string month { get => _month; }

        /// <summary>
        /// Vérifie si une sauvegarde existe déjà parmi les existantes.
        /// </summary>
        /// <param name="allSaves">Liste des sauvegardes mensuelles.</param>
        /// <param name="selectedMonth">Mois sélectionné.</param>
        /// <param name="selectedYear">Année sélectionnée.</param>
        /// <returns></returns>
        public static MonthlySave findMonthlySave(List<MonthlySave> allSaves, string selectedMonth, string selectedYear)
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

        /// <summary>
        /// Stocke toutes les informations constantes d'affichage.
        /// </summary>
        public class Const
    {
        public const string BUDGET = "Budget";
        public const string TOTAL = "Total";
        public const int DECEMBER = 11;

        public const String FILE_MONTHLYRECAP = "SauvegardesMensuelles";
        public const String FILE_DATA = "appData";

        public const int USER_A = 0; public const int USER_B = 1;
        public const string DEFAULT_NAME_USER_A = "Utilisateur A";
        public const string DEFAULT_NAME_USER_B = "Utilisateur B";

        public static Dictionary<string, double> initialDivision = new Dictionary<string, double>();

        public const string BALANCEDRESULT = "Résultat équilibré.";
        
        public static string debtDisplay(string name, double result)
        {
            return ($"{name} doit {result}€.");

        }

        // Contenu des MessageBox :
        public const string ERROR = "Erreur";

        public const string MSG_TITLE_ERR_NOSAVE = "Action impossible";
        public const string MSG_ERR_NO_MONTHLYSAVE = "Aucune sauvegarde enregistrée.";

        public const string MSG_TITLE_VALIDATIONMONYLYSAVE = "Cloturer le mois";
        public const string MSG_VALIDATIONMONYLYSAVE = "Valider le mois ? Aucune modification ne pourra êttre apportée.";

        public const string MSG_TITLE_SAVEBEFOREQUIT = "Fermeture";
        public const string MSG_SAVEBEFOREQUIT = "Voulez-vous sauvegarder avant de quitter?";

        public const string MSG_TITLE_RESET = "Réinitialisation";
        public const string MSG_RESET = "Toutes les données seront effacées. Confirmer ?";
        public const string MSG_RESETOK = "L'application a été réinitialisée avec succès.";

        public const string MSG_TITRE_ERR_SAVE = "Sauvegarde";
        public const string MSG_ERR_SAVE = ERROR;

        public const string MSG_TITRE_ERR_WRONGINPUT = ERROR;
        public const string MSG_ERR_WRONGINPUT = "Ne saisir que des nombres ou des calculs.";

        public const string MSG_TITLE_DELETE = "Confirmation de suppression";
        public const string MSG_DELETEBUDGET = "Voulez-vous vraiment supprimer le budget et son contenu ?";
        public const string MSG_DELETEMONTLYSAVE = "Voulez-vous vraiment supprimer cette sauvegarde mensuelle de manière permanente ?";

        public const string MSG_ERR_ADDDIVISION = "La répartition n'a pas pu être ajoutée.";
        public const string MSG_ERR_ADDDIVISION2 = "Un minimum d'une répartition doit subsister.";

        public const string MSG_ERR_FINALIZE = "Ajouter au moins un budget.";

        public const string MSG_ERR_WRONGSELECTION = "Aucune sauvegarde n'a été trouvée pour le mois suivant :";

        public const string MSG_TITLE_REPLACE = "Ecrasement";
        public const string MSG_REPLACE = "Une sauvegarde existe déjà pour ce mois. L'écraser ?";
        public const string MSG_REPLACE_YES = "La sauvegarde mensuelle a été écrasée.";
        public const string MSG_REPLACE_NO = "La sauvgarde n'a pas été effectuée.";

        private Const() {
            initializDivisions();
        }

        public static void initializDivisions()
        {
            initialDivision.Add("50 / 50", 0.5);
            initialDivision.Add("60 / 40", 0.6);
            initialDivision.Add("70 / 30", 0.7);
        }

        public static string EXPENSES(string user)
        {
            return $"Dépenses de {user}";
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
        public double expensesA { get; set; }
        public double expensesB { get; set; }
        public double total { get; set; }

        public DataMonthlyReport(string accountName, double expensesA, double expensesB)
        {
            this.accountName = accountName;
            this.expensesA = expensesA;
            this.expensesB = expensesB;
            this.total = expensesA + expensesB;
            DataMonthlyReport.nameUserA = User.getName(Const.USER_A);
            DataMonthlyReport.nameUserB = User.getName(Const.USER_B);
            //this.nameUserB = nameUserB;
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
