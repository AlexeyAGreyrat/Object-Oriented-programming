using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Task4BankAccount
    {
        private int _number ;
        private int _account;
        private int _type;
        private double _balance;


        public int Number
        {
            get
            {
                return _number;    
            }
            set
            {
                _number = value;
            }
        }
        public int Account
        {
            get
            {
                return _account;    
            }
            set
            {
                _account = value; 
            }
        }
        public int Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }
    }
}
