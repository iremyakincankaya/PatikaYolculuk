//1 - Aşağıdaki çıktıyı yazan bir program.
//Merhaba
//Nasılsın ?
//İyiyim
//Sen nasılsın ?

using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Console.WriteLine("Merhaba");
//Console.WriteLine("Nasılsın?");
//Console.WriteLine("İyiyim?");
//Console.WriteLine("Sen nasılsın?");

Console.WriteLine("Merhaba\r\nİyiyim\r\nSen nasılsın?");

Console.WriteLine(@"Merhaba
Nasılsın ?
İyiyim
Sen nasılsın?");

//2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.

string metin = "irem";
int sayi = 1;
Console.WriteLine($"Metin: {metin} ");
Console.WriteLine($"Sayı: {sayi} ");

//3 - Rastgele bir sayı üretip , ekrana yazdırınız.

Random random = new Random();
int rasgeleSayi = random.Next(1, 101);

Console.WriteLine($"Rastgele Sayı: {rasgeleSayi}");

//4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.

Console.WriteLine($"{rasgeleSayi % 3}");

//5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.

int yas;
Console.WriteLine("Yaşınız?");
yas = Convert.ToInt32(Console.ReadLine());

if (yas > 18)
{
    Console.WriteLine($"+");
}
else if (yas < 18)
{
    Console.WriteLine($"-");
}
else
{
    Console.WriteLine($"18 yaşındasınız.");
}

//6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}

//7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.

void DegerleriDegistir(ref string a, ref string b)
{
    string temp = a;
    a = b;
    b = temp;
}
string isim1 = "Demet Evgar";
string isim2 = "Gülse Birsel";
DegerleriDegistir(ref isim1, ref isim2);
Console.WriteLine($"İsim 1: {isim1}");
Console.WriteLine($"İsim 2: {isim2}");

//8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
static void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}
BenDegerDondurmem();

//9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
static int Toplam(int a, int b)
{
    return a + b;
}
Console.WriteLine($"İki sayının çarpımı: {Toplam(2, 6)}");

//yöntem2
//int Toplam(int a, int b) => Toplam(a, b);


//10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.

// parametre alıp parametre döndürcek

string Cevap(bool c)
{
    return c ? "Evet" : "Hayır";
}
Console.WriteLine("Benimle C# yazar mısın: " + Cevap(true));

Console.ReadKey();

// 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

int YaslarinEnBuyugu(int y1, int y2, int y3)
{
    return Math.Max(Math.Max(y1,y2), y3);
}

Console.WriteLine(YaslarinEnBuyugu(65,55,44));

//12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
int EnBuyukk(params int[] dizi)
{
    return dizi.Max();
}
Console.WriteLine(EnBuyukk(48,8,9,0,4));

//13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
Console.Write("Ad1:");
string ad1 = Console.ReadLine();

Console.Write("Ad2:");
string ad2 = Console.ReadLine();

Console.WriteLine();

//14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.

bool CiftMi(int sayi2)
{
    return sayi2 % 2 == 0;
}

Console.Write("Bir sayı: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CiftMi(sayi) ? "Çift" : "Tek");

Console.ReadKey();


//15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
static double yolHesabi(double hiz, double zaman)
{
    return hiz * zaman;
}
Console.WriteLine("Aracın hızı kaç km/saat?");
double hiz = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Araçla alınan süre kaç saattir?");
double zaman = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Yol : {yolHesabi(100, 3)}");

//16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
static double daireAlani(double yaricap)
{
    return Math.PI * Math.Pow(yaricap, 2);
}
Console.WriteLine($"Dairenin alanı: {daireAlani(3)}");

//17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

string text = "Zaman bir GeRi SayIm";
string upperCaseText = text.ToUpper();
string lowerCaseText = text.ToLower();

Console.WriteLine(upperCaseText);
Console.WriteLine(lowerCaseText);

//18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

string text1 = "    Selamlar   ";
string trimmedText = text1.Trim();

Console.WriteLine(trimmedText);
Console.ReadKey();