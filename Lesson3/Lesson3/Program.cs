using System;
using System.IO;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BankAccount bankA = new BankAccount(100);         
            BankAccount bankB = new BankAccount(200);
            bankA.Transfer(bankB, 100000);
            bankB.Transfer(bankA, 1000);
            Console.WriteLine($"\n{Palindromes.Palindrom("Program")}");
            string textFromFile;
            using (FileStream fstream = File.OpenRead(@"..\..\..\Text.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"Текст из файла: {textFromFile}");
            }
            string s = textFromFile;
            Console.WriteLine();
            Search.SearchMail(ref s);
            Console.WriteLine(s);

        }
    }
}
