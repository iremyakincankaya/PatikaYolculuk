using Patikaflix;
using System.ComponentModel;
using System.Threading.Channels;
using System;
using System.Collections.Generic;

List<Diziler> diziler = new List<Diziler>()
{
    new Diziler("Avrupa Yakası", 2004 , "Komedi", 2004, "Yücel Aksu", "Kanal D"),
    new Diziler("Yalan Dünya", 2012 , "Komedi", 2012, "Gülseren", "Fox TV"),
    new Diziler("Jet Sosyete", 2018, "Komedi", 2018, "Gülseren", "TV 8"),
    new Diziler("Arka Sokaklar", 2004, "Polisiye", 2004, "Orhan Oguz", "Kanal D")


};

Console.WriteLine("Listeye yeni dizi eklemek ister misiniz? E/H");
string cevap = Console.ReadLine().ToLower();

while (cevap == "e")
{
    Console.WriteLine("Dizini adı: ");
    string diziAd = Console.ReadLine();
    Console.WriteLine("Dizini yapım yılı: ");
    int diziYapimYili = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Dizini türü: ");
    string diziTur = Console.ReadLine();
    Console.WriteLine("Dizini başlama yılı: ");
    int diziBaslamaYili = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Dizi yönetmeni: ");
    string diziYonetmen = Console.ReadLine();
    Console.WriteLine("Dizini platformu : ");
    string diziPlatform = Console.ReadLine();

    // Dizi nesnesi oluştur
    Diziler yeniDizi = new Diziler(diziAd, diziYapimYili, diziTur, diziBaslamaYili, diziYonetmen, diziPlatform);

    // Diziyi listeye ekle
    diziler.Add(yeniDizi);

    Console.WriteLine("Listeye yeni dizi eklemek ister misiniz? E/H");
    cevap = Console.ReadLine().ToLower();

    if (cevap != "e")
        return;
}
foreach (var dizi in diziler)
{
    Console.WriteLine(dizi);
}

//Sadece komedi türündekiler 
List<KomediDizileri> komediDizileri = new List<KomediDizileri>()
{
    new KomediDizileri("Avrupa Yakası","Yücel Aksu", "Komedi"),
    new KomediDizileri("Yalan Dünya","Gülseren", "Komedi"),
    new KomediDizileri("Jet Sosyete","Gülseren", "Komedi")

};

foreach (var dizi in komediDizileri)
{
    Console.WriteLine(dizi);
}


Console.ReadKey();
