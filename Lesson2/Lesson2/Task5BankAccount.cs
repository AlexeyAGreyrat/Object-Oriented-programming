using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Task5BankAccount
    {
        private double _balance;
        public double Balance
        {
            get
            {
                return _balance;
            }            
        }
        public void Take(double balance)
        {
            if(balance>_balance)
            {
                Console.WriteLine("Снять не удалось");
            }
            else
            {
                _balance = _balance - balance;
                Console.WriteLine($"Снять удалось \nОстаток:{_balance}");
            }
        }
        public void Put(double balance)
        {
            Console.WriteLine($"Зачислено:{balance}");

            _balance = balance;
        }
    }
}
