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


}
