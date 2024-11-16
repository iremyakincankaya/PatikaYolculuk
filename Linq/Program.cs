using System;
using System.Linq;
class Program
{
    static void Main()
    {
        // Rastgele 10 sayıdan oluşan bir liste 
        Random rand = new Random();
        List<int> sayilar = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            sayilar.Add(rand.Next(-50, 101));
        }

        // LINQ sorgusu ile çift sayılar seçiliyor
        var ciftSayilar = sayilar.Where(sayi => sayi % 2 == 0).ToList();
        // Çift sayıları ekrana yazdıralım
        Console.WriteLine("Çift sayılar: ");
        foreach (var sayi in ciftSayilar)
        {
            Console.WriteLine(sayi);
        }

        // LINQ sorgusu ile tek sayılar seçiliyor
        var tekSayilar = sayilar.Where(sayi => sayi % 2 != 0).ToList();

        // Tek sayıları ekrana yazdıralım
        Console.WriteLine("Tek sayılar: ");
        foreach (var sayi in tekSayilar)
        {
            Console.WriteLine(sayi);
        }

        // LINQ sorgusu ile negatif sayılar seçiliyor
        var negatifSayilar = sayilar.Where(sayi => sayi < 0).ToList();

        // Negatif sayıları ekrana yazdıralım
        Console.WriteLine("Negatif sayılar: ");
        foreach (var sayi in negatifSayilar)
        {
            Console.WriteLine(sayi);
        }

        // LINQ sorgusu ile pozitif sayılar seçiliyor
        var pozitifSayilar = sayilar.Where(sayi => sayi > 0).ToList();

        // Pozitif sayıları ekrana yazdıralım
        Console.WriteLine("Pozitif sayılar: ");
        foreach (var sayi in pozitifSayilar)
        {
            Console.WriteLine(sayi);
        }

        // 15-22 arası sayılar seçiliyor
        var seciliSayilar = sayilar.Where(sayi => sayi > 15 && sayi < 22).ToList();

        // 15-22 arası sayılar ekrana yazdıralım
        Console.WriteLine("15-22 arasındaki sayılar: ");
        foreach (var sayi in seciliSayilar)
        {
            Console.WriteLine(sayi);
        }
        if (!seciliSayilar.Any())
        { 
            Console.WriteLine("Listede 15-22 arasında sayı yoktur"); 
        }


        //Listedeki her bir sayının karesi
        var sayininKaresi = sayilar.Select(sayi => sayi * sayi).ToList();

        //Sayıların karelerini yazdıralım
        Console.WriteLine("Sayıların karesi: ");
        foreach (var sayi in sayininKaresi)
        {
            Console.WriteLine(sayi);
        }

        Console.ReadKey();
    }
}

