using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class BankAccount
    {
        private double _balance;
        private int _account;

        public BankAccount()
        {

        }
        public BankAccount(int account,int balance = 10000)
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
        public void Take(double balance)
        {
            if (balance > _balance)
            {
                Console.WriteLine("Снять не удалось");
            }
            else
            {
                _balance = _balance - balance;
                Console.WriteLine($"Снять удалось \nОстаток:{_balance}");
            }
        }

        private bool Check(double money)
        {
            if (money > _balance)
            {
                Console.WriteLine("Перевести не удалось недостаточно средств на счету");
                return false;
            }
            else
            {
                _balance = _balance - money;
                Console.WriteLine($"Перевод успешен \nОстаток:{_balance}");
                return true;
            }
        }
        public void Put(double balance)
        {
            Console.WriteLine($"Зачислено:{balance}");

            _balance = balance;
        }

        public void Transfer(BankAccount bank,double money)
        {
            if (bank.Check(money) == true)
            {
                _balance = _balance + money;
                Console.WriteLine($"Номер банка {bank._account} списано {money} Остаток: {bank._balance} ");
            }
        }
    }
}