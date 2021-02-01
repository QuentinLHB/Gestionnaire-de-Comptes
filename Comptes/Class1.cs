using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Comptes
{


    [SerializableAttribute]
    class AppData
    {
        static AffichageData affichage = new AffichageData();
        public List<User> lesUsers { get; }
        public List<Budget> lesBudgets { get; }

        private Dictionary<string, double> _dctRepartitions;

        public AppData()
        {
            lesUsers = new List<User>();
            lesBudgets = new List<Budget>();
            _dctRepartitions = new Dictionary<string, double>();
            foreach (KeyValuePair<string, double> paire in affichage.repartitionsInitiales)
            {
                _dctRepartitions.Add(paire.Key, paire.Value);
            }
        }
        public Dictionary<string, double> dctRepartitions { get => _dctRepartitions; }

    }

    /// <summary>
    /// Stocke toutes les informations constantes d'affichage.
    /// </summary>
    class AffichageData
    {
        private const String _fichierData = "appData";
        private const int _userA = 0; public const int _userB = 1;
        private const string _nomUserA = "personne A";
        private const string _nomUserB = "personne B";
        private Dictionary<string, double> _repartitionsInitiales = new Dictionary<string, double>();

        public AffichageData() {
            repartitionsInitiales.Add("50 / 50", 0.5);
            repartitionsInitiales.Add("60 / 40", 0.6);
            repartitionsInitiales.Add("70 / 30", 0.7);
        }

        public string getFichierData()
        {
            return _fichierData;
        }
        public String fichierData { get => _fichierData; }
        public int userA { get => _userA; }
        public int userB { get => _userB; }
        public string nomUserA { get => _nomUserA; }
        public string nomUserB { get => _nomUserB; }
        public Dictionary<string, double> repartitionsInitiales { get => _repartitionsInitiales; }
    }

    [SerializableAttribute]
    class Budget
    {
        private Compte _compte;
        private string _nom;
        private double _repartition;

        public Budget(string nom, double repartition, User userA, User userB)
        {
            this.nom = nom;
            this.repartition = repartition;
            _compte = new Compte(this, userA, userB);
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
    class Compte 
    {
        static AffichageData affichage = new AffichageData();
        private User _userA;
        private User _userB;
        private Budget _budget;
        private double _depensesUserA;
        private double _depensesUserB;


        public Compte(Budget budget, User userA, User userB)
        {
            this._budget = budget;
            this._userA = userA;
            this._userB = userB;
        }
        public User userA { get => _userA; }
        public User userB { get => _userB; }

        public Budget budget { get => _budget; }

        public double depensesUserA { get => _depensesUserA; set => _depensesUserA = value; }

        public double depensesUserB { get => _depensesUserB; set => _depensesUserB = value; }

        public override string ToString()
        {
            if (this.depensesUserA != 0 || this.depensesUserB != 0)
            {
                return ($"{_budget.nom} : [{_userA.nom} {_depensesUserA}] [{_userB.nom} {_depensesUserB}]");
            }

            else
            {
                return _budget.nom + " : ";
            }

        }

        public void reset()
        {
            depensesUserA = 0;
            depensesUserB = 0;
        }


    }

    [SerializableAttribute]
    class User
    {
        private string _nom;
        private double _dettes;

        public string nom { get => _nom; set => _nom = value; }

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

    abstract class Serialise
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
