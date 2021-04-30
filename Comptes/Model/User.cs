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
}
