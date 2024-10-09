int a = 1;

baslangic:
Console.WriteLine(a++);
if (a < 10)
    goto baslangic;

Console.ReadKey();