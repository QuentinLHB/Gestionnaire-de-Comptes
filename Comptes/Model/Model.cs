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
        static AffichageData affichage = new AffichageData();
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
            lesUsers[affichage.userA].nom = affichage.nomUserA;
            lesUsers[affichage.userB].nom = affichage.nomUserB;
            lesBudgets.Clear();
            foreach (User user in lesUsers)
            {
                user.dettes = 0;
            }
        }

        private void initialiseRepartitions()
        {
            foreach (KeyValuePair<string, double> paire in affichage.repartitionsInitiales)
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

        //public string mois { get => _mois; set => _mois = value; }
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
        //public string tag { get => _tag; }
    }

        /// <summary>
        /// Stocke toutes les informations constantes d'affichage.
        /// </summary>
        public class AffichageData
    {
        //public const string BUDGET = "Budget";
        private const int _DECEMBRE = 11;
        private const String _fichierSaveMois = "SauvegardesMensuelles";
        private const String _fichierData = "appData";
        private const int _userA = 0; public const int _userB = 1;
        private const string _nomUserA = "personne A";
        private const string _nomUserB = "personne B";
        private Dictionary<string, double> _repartitionsInitiales = new Dictionary<string, double>();

        public AffichageData() {
            initialiseRepartition();
        }

        public void initialiseRepartition()
        {
            repartitionsInitiales.Add("50 / 50", 0.5);
            repartitionsInitiales.Add("60 / 40", 0.6);
            repartitionsInitiales.Add("70 / 30", 0.7);
        }

        public string getFichierData()
        {
            return _fichierData;
        }
        public String fichierData { get => _fichierData; }
        public String fichierSaveMois { get => _fichierSaveMois; }
        public int userA { get => _userA; }
        public int userB { get => _userB; }
        public string nomUserA { get => _nomUserA; }
        public string nomUserB { get => _nomUserB; }
        public Dictionary<string, double> repartitionsInitiales { get => _repartitionsInitiales; }
        public int DECEMBRE { get => _DECEMBRE; }
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
    //}





}
