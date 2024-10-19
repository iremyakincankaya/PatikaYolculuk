//En Çok Tekrar Eden Karakteri Bul. Girilen bir string’de en çok tekrar eden karakteri bulan bir metot yazın.

//Console.WriteLine("Lütfen bir metin giriniz:");
//string kelime=Console.ReadLine();
////alaattin
//char enCokTekrarEdenHarf ;

//HarfiBul("alla");
//void HarfiBul(string kelime)
//{
//    for (int i = 0; i < kelime.Length; i++)
//    {
//        int sayac = 1;
//        char denemeHarf = kelime[i];
//        int y = i;
//        while (y < kelime.Length - 1)
//        {

//            char denemeHarf2 = kelime[y + 1];
//            if (denemeHarf == denemeHarf2)
//            {
//                sayac++;
//            }
//            y++;
//        }
//        Console.WriteLine($"En çok tekrar eden harf: ");
//    }


//    Console.ReadKey();

//}



////--------------------
//Console.WriteLine("---------------------------------------");
//string kelime=Console.ReadLine();
//int max = 0;
//char enCokTekrarEdenHarf = ' ';

//for (int i = 0; i < kelime.Length; i++)
//{
//    char harf = kelime[i];
//    int sayac = 0;

//    for (int j = 0; j<kelime.Length; j++)
//    {
//        if (kelime[j]==harf)
//        {
//            sayac++;
//        }

//    }
//    if (sayac>max)
//    {
//        max = sayac;
//        enCokTekrarEdenHarf=harf;
//    }
//}

//Console.WriteLine(enCokTekrarEdenHarf);
//Console.ReadKey();
//kabak

using System.Threading.Channels;

while (true)
{
    Fibonacci();
    Console.ReadKey();
}


static void Polindrom()
{
    Console.WriteLine("-------------------------------");

    string kelime = Console.ReadLine();

    if (kelime[0] != kelime[kelime.Length - 1])
    {
        Console.WriteLine($"{kelime} palindrome değildir.");
    }
    else
    {
        int sayac = 0;

        for (int i = 0; i < kelime.Length; i++)
        {
            if (kelime[i] == kelime[kelime.Length - 1 - sayac])
            {
                sayac++;
            }
            else
            {
                Console.WriteLine($"{kelime} palindrome değildir.");
                break;
            }
        }
        if (sayac == kelime.Length)
        {
            Console.WriteLine($"{kelime} palindrome dur");

        }


    }
    Console.ReadKey();

}

static void Fibonacci()
{
    Console.Clear();
    int sayi = int.Parse(Console.ReadLine());
    string sayilar = "1 2 ";
    int start = 0;
    int sonSayi = 2;
    int ilkSayi = 1;

    int sonuc;

    if (sayi <= 0)
    {
        Console.WriteLine("0 dan büyük sayı giriniz");
        return;
    }
    if (sayi == 1)
    {
        Console.WriteLine("1");
        return;
    }
    if (sayi == 2)
    {
        Console.WriteLine("1 1");
        return;
    }
    else
    {
        while (sonSayi < sayi)
        {
            sonSayi = ilkSayi + sonSayi;

            if (sonSayi > sayi)
            {
                Console.WriteLine(sayilar);

                return;
            }

            ilkSayi = sonSayi - ilkSayi;

            sayilar = sayilar + sonSayi.ToString() + " ";
        }

        Console.WriteLine(sayilar);
        return;
    }

}




/*ss
 8-> ilk son=1+0=1, ilk=1, son=1+1=2,ilk=2, son=
 
1 1 2 3 5 8

ilk 1
son 2

ilk 2
son 3

ilk 3
son 5


1 1
1 2

1 1 2 
  1 2

1 1 2 3
    1 2 
*/