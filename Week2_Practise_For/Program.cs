//10 kere yazdır.
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Ben bu yazılım işini hallederim!");
}
Console.WriteLine(" ");

//1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine(" ");

//1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

for (int i = 2; i <= 20; i += 2)
{
    Console.WriteLine(i);
}
Console.WriteLine(" ");

//50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

int toplam = 0;

for (int i = 50; i <= 150; i++)
{
    toplam += i;
}
Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı: {toplam} ");
Console.WriteLine(" ");

//1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int toplamTekSayilar = 0;
int toplamCiftSayilar = 0;

for (int i = 1; i <= 120; i += 2)
{
    toplamTekSayilar += i;
}
Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {toplamTekSayilar} ");
Console.WriteLine(" ");

for (int i = 2; i <= 120; i += 2)
{
    toplamCiftSayilar += i;
}
Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {toplamCiftSayilar} ");
Console.WriteLine(" ");
Console.ReadKey();