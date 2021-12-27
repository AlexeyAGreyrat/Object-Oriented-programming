using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета (использовать перечислимый тип).
//Предусмотреть методы для доступа к данным – заполнения и чтения. Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать.

namespace Lesson2
{
    class Task1BankAccount
    {
        private int _number;
        private int _account;
        private int _type;

        public void write(int number,int account,int type)
        {
            _number = number;
            _account = account;
            _type = type;
        }

        public void reading()
        {
            Console.Write($"Номер счета: {_number}\nБаланс: {_account} \nТип банковского счета: {_type}\n");
        }
    }
}
