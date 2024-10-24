
//10 adet tam sayı verisi alacak bir dizi tanımlıyoruz
int[] sayilar = new int[10];

for (int i = 0; i < sayilar.Length; i++)
{
    sayilar[i] = i + 1;
}
foreach (var item in sayilar) //1 2 3 ....
{
    Console.WriteLine(item);
}
Console.WriteLine("Deger giriniz:");
int deger = Convert.ToInt32(Console.ReadLine());

int[] sayilar2 = new int[11];

for (int i = 0; i < sayilar.Length; i++) //ilk dizinin elemanlarını ikinci diziye tanımlama
{
    sayilar2[i] = sayilar[i];
}

sayilar2[10] = deger;
var siraliDizi = sayilar2.OrderByDescending(x => x); //büyükten küçüğe sıralama

foreach (var item in siraliDizi)
{
    Console.Write(item + ">");
}


Console.ReadKey();

