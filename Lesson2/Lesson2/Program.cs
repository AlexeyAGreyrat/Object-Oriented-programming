using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1BankAccount bank = new Task1BankAccount();
            bank.write(1, 1, 1);
            bank.reading();

            Task2BankAccount bank1 = new Task2BankAccount();
            bank1.write(1, 1);
            bank1.reading();

            Task2BankAccount bank2 = new Task2BankAccount();
            bank2.write(2, 2);
            bank2.reading();

            Task4BankAccount bank4 = new Task4BankAccount();
            for (int i = 0; i < 10; i++)
            { 
                bank4.Number = i;
                Console.WriteLine(bank4.Number);
            }
            Task5BankAccount bank5 = new Task5BankAccount();
            bank5.Put(10000);
            bank5.Take(11000);
            bank5.Take(9999);

        }
    }
}
