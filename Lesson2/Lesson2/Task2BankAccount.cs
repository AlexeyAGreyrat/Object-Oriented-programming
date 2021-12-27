using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Task2BankAccount
    {
        private static int _number=0;
        private int _account;
        private int _type;

        public void write(int account, int type)
        {
            increase();
            _account = account;
            _type = type;
        }
        public static void increase()
        {
            _number++;
        }
        public void reading()
        {
            Console.Write($"Номер счета: {_number}\nБаланс: {_account} \nТип банковского счета: {_type}\n");
        }
    }
}
