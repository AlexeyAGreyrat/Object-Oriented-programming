using Lesson5;

Console.WriteLine("IsNan 2/0 ? " + new Rational(2, 0).IsNan);
Rational r35 = new Rational(1, 3);
Rational r36 = new Rational(3, 4);
//Умножаем рациональную дробь на число
Console.WriteLine("Умножаем рациональную дробь " + r35 + " на число 4\n" + r35 * 4);

//Складываем рациональные дроби
Rational sumdr = r35 + r36;
Console.WriteLine("Складываем рациональные дроби " + r35 + " и " + r36 + " \n" + sumdr);
Console.WriteLine(r35 % r36);
Console.WriteLine(""+ --r36);

Complex a = new Complex(1, 2);
Console.WriteLine("\n" + (a+a) +"\n" + (a+a-a));
Console.WriteLine("" + (a*a));
Console.WriteLine("" + (a/a));


