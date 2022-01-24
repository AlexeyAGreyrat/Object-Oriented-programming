using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class BankAccount
    {
        private double _balance;
        private int _account;

        public BankAccount()
        {

        }
        public BankAccount(int account, int balance = 10000)
        {
            _account = account;
            _balance = balance;
        }
        public int Account
        {
            get { return _account; }
            set { _account = value; }
        }
        public double Balance
        {
            get
            {
                return _balance;
            }
        }

        public static bool operator ==(BankAccount a,BankAccount b)
        {
            if (a.Account == b.Account)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(BankAccount a, BankAccount b)
        {
            if (a.Account != b.Account)
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(_account, _balance);
        }

        public override string ToString()
        {
            return String.Format("[BankAccount: {0} Balance: {1}]", this.Account, this.Balance);
        }

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                BankAccount p = (BankAccount)obj;
                return (_account == p.Account) && (_balance == p.Balance);
            }
        }

    }
}
