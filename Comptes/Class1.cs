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
    class appData
    {
        public List<User> lesUsers { get; }
        public List<Budget> lesBudgets { get; }

        public appData()
        {
            lesUsers = new List<User>();
            lesBudgets = new List<Budget>();
        }
        
    }

    [SerializableAttribute]
    class Budget
    {
        public Budget(string nom, double repartition, User userA, User userB)
        {
            this.nom = nom;
            this.repartition = repartition;
            compte = new Compte(this, userA, userB);
        }

        public Compte compte { get; }

        public string nom { get; set; }

        public double repartition { get; set; }

        public int index { get; set; }

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
        public User userA { get; }
        public User userB { get; }

        public Compte(Budget budget, User userA, User userB)
        {
            this.budget = budget;
            this.userA = userA;
            this.userB = userB;
        }

        public Budget budget { get; }

        public double depensesUsersA { get; set; }

        public double depensesUserB { get; set; }

        public override string ToString()
        {
            if (this.depensesUsersA != 0 || this.depensesUserB != 0)
            {
                return ($"{budget.nom} : [{userA.nom} {depensesUsersA}] [{userB.nom} {depensesUserB}]");
            }

            else
            {
                return budget.nom + " : ";
            }

        }

        public void reset()
        {
            depensesUsersA = 0;
            depensesUserB = 0;
        }


    }

    [SerializableAttribute]
    class User
    {


        public string nom { get; set; }

        public double dettes { get; set; }

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
