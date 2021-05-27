using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comptes.Constants;

namespace Comptes.Model
{

    [SerializableAttribute]
    public class User
    {
        private static string[] names = new string[2];
        private static double[] debts = new double[2];
        private double _expenses;

        public static void initializeDefaultNames()
        {
            names[Const.USER_A] = Const.DEFAULT_NAME_USER_A;
            names[Const.USER_B] = Const.DEFAULT_NAME_USER_B;

        }

        public static void initializeNames(AppData data)
        {
            names[Const.USER_A] = data.usersNames[Const.USER_A];
            names[Const.USER_B] = data.usersNames[Const.USER_B];
        }

        /// <summary>
        /// Retourne vrai si les noms sont tous les deux ceux par défaut.
        /// </summary>
        /// <returns></returns>
        public static bool areNamesDefault()
        {
            if (User.getName(Const.USER_A) != Const.DEFAULT_NAME_USER_A || (User.getName(Const.USER_B)) != Const.DEFAULT_NAME_USER_B)
            {
                return false;
            }
            return true;
        }

        public static bool isNameDefault(int userIndex)
        {
            string defaultName;
            if (userIndex == Const.USER_A) defaultName = Const.DEFAULT_NAME_USER_A;
            else defaultName = Const.DEFAULT_NAME_USER_B;

            if (User.getName(userIndex) != defaultName)
            {
                return false;
            }
            return true;
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
}
