using Lesson6;

BankAccount bank = new BankAccount(1,200000);
BankAccount bank2 = new BankAccount(2,100000);

Console.WriteLine($"{bank} \n{bank2}");
Console.WriteLine($"{bank.GetHashCode()}");
Console.WriteLine($"{bank2.GetHashCode()}");
Console.WriteLine(bank.Equals(bank));
Console.WriteLine(bank.Equals(bank2));
Console.WriteLine(bank != bank2);
Console.WriteLine(bank == bank2);
Console.WriteLine(bank == bank);

