using Lesson7;

ACoder coder = new ACoder();
BCoder coderB = new BCoder();


Console.WriteLine(coder.Encode("абвгдежзийклмнопрстуфхцчшщьыъэюя"));
Console.WriteLine(coder.Decode("бвгдежзийклмнопрстуфхцчшщьыъэюяа"));
Console.WriteLine(coderB.Encode("абвгдежзийклмнопрстуфхцчшщьыъэюя"));
Console.WriteLine(coderB.Decode("яюэъыьщшчцхфутсрпонмлкйизжедгвба"));


