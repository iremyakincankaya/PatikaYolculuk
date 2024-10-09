//[erişim_belirleyici] [geri_dönüş_türü] [metot_adı] ([parametre_listesi])
//Geriye Değer Döndürmeyen Bir void metot. Ekrana sevdiğiniz bir şarkı sözünü yazdırsın. 

using System.Reflection.Metadata;

static void Sarkisozu()
{
    Console.WriteLine("Gözler gizler niyetleri belki");
}
Sarkisozu();

//Geriye Tamsayı Döndüren Bir metot. Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.
static int TamsayiDondur()
{
    Random rnd = new Random();
    int sayi = rnd.Next(1, 11);

    Console.WriteLine($"Sayi: {sayi}");
    return sayi % 2;
}
Console.WriteLine($"İki ile bölümünden kalan: {TamsayiDondur()}");

//Parametre Alan ve Geriye Değer Döndüren Bir Metot. Parametre olarak aldığı iki sayının çarpımını geriye dönsün.

static int Carpim(int a, int b)
{
    return a * b;
}
Console.WriteLine($"İki sayının çarpımı: {Carpim(2, 6)}");

//Parametre Alan ve Geriye Değer Döndürmeyen bir Metot. Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.

static void Hosgeldiniz(string name, string surname)
{
    Console.WriteLine($"Hoşgeldiniz {name} {surname}");
}
Hosgeldiniz("irem", "yakincan");

Console.ReadKey();


//   EK---Parametre Alan ve Geriye Değer Döndüren Bir Metot. Parametre olarak aldığı sayıların çarpımını geriye dönsün.
static int Carp(int[] sayilar)
{
    int carpim = 1;

    for (int i = 0; i < sayilar.Length; i++)
    {
        carpim *= sayilar[i];
    }
    return carpim;
}
Console.WriteLine($"Çarpım sonucu: {Carp(new int[] { 1, 2, 3 })}");

static int Carp2(params int[] sayilar)
{
    int carpim = 1;

    foreach (var item in sayilar)
    {
        carpim = carpim * item;
    }

    return carpim;
}
Console.WriteLine($"Çarpım sonucu: {Carp2(1, 2, 3, 4, 5, 11)}");
Console.ReadKey();