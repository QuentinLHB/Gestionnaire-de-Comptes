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
    //public class Model
    //{
        
    //    public Model()
    //    {

    //    }


    [SerializableAttribute]
    public class AppData
    {
        public List<User> lesUsers { get; }
        public List<Budget> lesBudgets { get; }
        private string _mois;
        private Dictionary<string, double> _dctRepartitions;

        public AppData()
        {
            lesUsers = new List<User>();
            lesBudgets = new List<Budget>();
            _dctRepartitions = new Dictionary<string, double>();
            initialiseRepartitions();
        }

        public void reinitialiseData()
        {
            _dctRepartitions.Clear();
            initialiseRepartitions();
            lesUsers[Constantes.USER_A].nom = Constantes.NOM_DEFAUT_USER_A;
            lesUsers[Constantes.USER_B].nom = Constantes.NOM_DEFAUT_USER_B;
            lesBudgets.Clear();
            foreach (User user in lesUsers)
            {
                user.dettes = 0;
            }
        }

        private void initialiseRepartitions()
        {
            foreach (KeyValuePair<string, double> paire in Constantes.repartitionsInitiales)
            {
                _dctRepartitions.Add(paire.Key, paire.Value);
            }
        }

        public Dictionary<string, double> dctRepartitions { get => _dctRepartitions; }
        public string mois { get => _mois; set => _mois = value; }

    }

    [SerializableAttribute]
    public class SaveMensuelle
    {
        private List<User> _lesUsers;
        private List<Budget> _lesBudgets;

        private string _mois;
        private string _annee;

        public List<User> lesUsers { get => _lesUsers; set => _lesUsers = value; }
        public List<Budget> lesBudgets { get => _lesBudgets; set => _lesBudgets = value; }

        public SaveMensuelle(string mois, string annee, List<Budget> lesBudgets, List<User> lesUsers)
        {
            _mois = mois;
            _annee = annee;
            _lesBudgets = lesBudgets;
            _lesUsers = lesUsers;
        }

        public string annee { get => _annee; }
        public string mois { get => _mois; }
    }

        /// <summary>
        /// Stocke toutes les informations constantes d'affichage.
        /// </summary>
        public class Constantes
    {
        public const string BUDGET = "Budget";
        public const string TOTAL = "Total";
        public const int DECEMBRE = 11;

        public const String FICHIER_SAVEMENSUELLE = "SauvegardesMensuelles";
        public const String FICHIER_DATA = "appData";

        public const int USER_A = 0; public const int USER_B = 1;
        public const string NOM_DEFAUT_USER_A = "Utilisateur A";
        public const string NOM_DEFAUT_USER_B = "Utilisateur B";

        public static Dictionary<string, double> repartitionsInitiales = new Dictionary<string, double>();

        public const string EQUILIBRE = "Résultat équilibré.";

        // Contenu des MessageBox :
        public const string ERREUR = "Erreur";

        public const string MSG_TITRE_ERR_PASDESAUVEGARDE = "Action impossible";
        public const string MSG_ERR_PASDESAUVEGARDEMENSUELLE = "Aucune sauvegarde enregistrée.";

        public const string MSG_TITRE_VALIDATIONSAUVEGARDEMENSUELLE = "Cloturer le mois";
        public const string MSG_VALIDATIONSAUVEGARDEMENSUELLE = "Valider le mois ? Aucune modification ne pourra êttre apportée.";

        public const string MSG_TITRE_SAUEGARDERAVANTQUITTER = "Fermeture";
        public const string MSG_SAUEGARDERAVANTQUITTER = "Voulez-vous sauvegarder avant de quitter?";

        public const string MSG_TITRE_REINITIALISER = "Réinitialisation";
        public const string MSG_REINITIALISER = "Toutes les données seront effacées. Confirmer ?";
        public const string MSG_REINITIALISATIONOK = "L'application a été réinitialisée avec succès.";

        public const string MSG_TITRE_ERR_SAUVEGARDE = "Sauvegarde";
        public const string MSG_ERR_SAUVEGARDE = ERREUR;

        public const string MSG_TITRE_ERR_SAISIE = ERREUR;
        public const string MSG_ERR_SAISIE = "Ne saisir que des nombres ou des calculs.";

        public const string MSG_TITRE_SUPPRBUDGET = "Confirmation de suppression";
        public const string MSG_SUPPRBUDGET = "Voulez-vous vraiment supprimer le budget et son contenu ?";

        public const string MSG_ERR_AJOUTREPART = "La répartition n'a pas pu être ajoutée.";
        public const string MSG_ERR_AJOUTREPART2 = "Un minimum d'une répartition doit subsister.";

        public const string MSG_ERR_CLOTURE = "Ajouter au moins un budget.";

        public const string MSG_ERR_SELECTIONERRONNEE = "Aucune sauvegarde n'a été trouvée pour le mois suivant :";

        public const string MSG_TITRE_ECRASEMENT = "Ecrasement";
        public const string MSG_ECRASEMENT = "Une sauvegarde existe déjà pour ce mois. L'écraser ?";
        public const string MSG_ECRASEMENT_YES = "La sauvegarde mensuelle a été écrasée.";
        public const string MSG_ECRASEMENT_NO = "La sauvgarde n'a pas été effectuée.";

        private Constantes() {
            initialiseRepartition();
        }

        public static void initialiseRepartition()
        {
            repartitionsInitiales.Add("50 / 50", 0.5);
            repartitionsInitiales.Add("60 / 40", 0.6);
            repartitionsInitiales.Add("70 / 30", 0.7);
        }

        public static string DEPENSES(string user)
        {
            return $"Dépenses de {user}";
        }
    }

    [SerializableAttribute]
    public class Budget
    {
        private Compte _compte;
        private string _nom;
        private double _repartition;

        public Budget(string nom, double repartition, string nomUserA, string nomUserB)
        {
            this.nom = nom;
            this.repartition = repartition;
            _compte = new Compte(this, nomUserA, nomUserB);
        }

        public Compte compte { 
            get => _compte;
            }

        public string nom { get => _nom ; set => _nom = value; }

        public double repartition { get => _repartition; set => _repartition = value; }

        public override string ToString()
        {
            return nom + " : " + (repartition * 100).ToString() + " / " + (100 - repartition * 100).ToString();
        }

        public string afficheNomBudget()
        {
            return nom + " : ";
        }
    }

    [SerializableAttribute]
    public class Compte 
    {
        private User _userA;
        private User _userB;
        private Budget _budget;


        public Compte(Budget budget, string nomUserA, string nomUserB)
        {
            this._budget = budget;
            this._userA = new User(nomUserA);
            this._userB = new User(nomUserB);
        }
        public User userA { get => _userA; }
        public User userB { get => _userB; }

        public Budget budget { get => _budget; }

        public override string ToString()
        {
            if (this.userA.depenses != 0 || this.userB.depenses != 0)
            {
                return ($"{_budget.nom} : [{_userA.nom} {_userA.depenses}] [{_userB.nom} {_userB.depenses}]");
            }

            else
            {
                return _budget.nom + " : ";
            }

        }

        public void reset()
        {
            _userA.depenses = 0;
            _userB.depenses= 0;
        }


    }

    [SerializableAttribute]
    public class User
    {
        private string _nom;
        private double _dettes;
        private double _depenses;

        public string nom { get => _nom; set => _nom = value; }

        public double depenses { get => _depenses; set => _depenses = value; }

        public double dettes { get => _dettes; set => _dettes = value; }

        public string afficheNom()
        {
            return nom + " : ";
        }

        public User(string nom = "")
        {
            this.nom = nom;
        }

    }

    public class DataTableauMensuel
    {
        public string nomCompte { get; set; }
        public string nomUserA { get; set; }
        public string nomUserB { get; set; }
        public double depensesA { get; set; }
        public double depensesB { get; set; }
        public double total { get; set; }

        public DataTableauMensuel(string nomCompte, string nomUserA, double depensesA,  string nomUserB, double depensesB)
        {
            this.nomCompte = nomCompte;
            this.depensesA = depensesA;
            this.depensesB = depensesB;
            this.total = depensesA + depensesB;
            this.nomUserA = nomUserA;
            this.nomUserB = nomUserB;
        }

    }

    public abstract class Serialise
    {
        /// <summary>
        /// Sérialisation
        /// </summary>
        /// <param name="fichier">nom du fichier de sauvegarde</param>
        /// <param name="objet">objet à sérialiser</param>
        public static void Sauve(string fichier, Object objet)
        {
            // si le fichier existe, il faut le supprimer
            if (File.Exists(fichier))
            {
                File.Delete(fichier);
            }
            // création du flux pour l'écriture dans le fichier
            FileStream flux = new FileStream(fichier, FileMode.Create);
            // création d'un objet pour le formatage en binaire des informations
            BinaryFormatter fbinaire = new BinaryFormatter();
            // sérialisation des objets de la collection
            fbinaire.Serialize(flux, objet);
            // fermeture du flux
            flux.Close();
        }

        /// <summary>
        /// Désérialisation
        /// </summary>
        /// <param name="fichier">nom du fichier de sauvegarde</param>
        /// <returns>objet désérialisé</returns>
        public static Object Recup(string fichier)
        {
            // Contrôle de l'existance du fichier
            if (File.Exists(fichier))
            {
                // ouverture du flux pour la lecture dans le fichier
                FileStream flux = new FileStream(fichier, FileMode.Open);
                // création d'un objet pour le formatage en binaire des informations
                BinaryFormatter fbinaire = new BinaryFormatter();
                // récupération de l'objet sérialisé
                try
                {
                    Object objet = fbinaire.Deserialize(flux);
                    // fermeture du flux
                    flux.Close();
                    // retour de l'objet
                    return objet;
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
