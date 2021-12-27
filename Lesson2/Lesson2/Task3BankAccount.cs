using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3. В классе банковский счет удалить методы заполнения полей. Вместо этих методов создать конструкторы.
//Переопределить конструктор по умолчанию, создать конструктор для заполнения поля баланс, конструктор для заполнения поля тип банковского счета, конструктор для заполнения баланса и типа банковского счета.
//Каждый конструктор должен вызывать метод, генерирующий номер счета.

namespace Lesson2
{
    class Task3BankAccount
    {
        private static int _number = 0;
        private int _account;
        private int _type;
        private double _balance;

        //конструктор для заполнения поля баланс
        public Task3BankAccount(double balance)
        {
            increase();
            _balance = balance;
        }
        //конструктор для заполнения поля тип банковского счета
        public Task3BankAccount(int type)
        {
            increase();
            _type = type;
        }

        //конструктор для заполнения баланса и типа банковского счета
        public Task3BankAccount(double balance,int type)
        {
            increase();
            _balance = balance;
            _type = type;
        }

        public static void increase()
        {
            _number++;
        }
    }
}
