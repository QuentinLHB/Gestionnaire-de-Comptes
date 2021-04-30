using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comptes.Constants;

namespace Comptes.Model
{
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
            _userB.expenses = 0;
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
}
