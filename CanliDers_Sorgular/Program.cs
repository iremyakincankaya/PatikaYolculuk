//ülkeleri listeler soruglar projesine dependencide add project refrans dedik datalibi

using CanliDers_Sorgular;
using DataLib;

Console.WriteLine("-----------------------Ülkeler----------------------\r\n");

foreach (Ulke item in Veri.Ulkeler())
{
    Console.WriteLine(item.Ad);
}


Console.WriteLine("\r\n---------------------Ünlüler--------------------\r\n");

foreach (Unlu item in Veri.Unluler())
{
    Console.WriteLine(item.Ad);
}

Console.WriteLine("-------------------------------------------------------------\r\n-------------------WHERE KULLANIMI-----------------------\r\n----------------------------------------------------------");

//Where sorgusu

Console.WriteLine("\r\n--------------1970 öncesi doğan ünlüler---------------\r\n");

IEnumerable<Unlu> sonuc1 = Veri.Unluler().Where(unlu => unlu.DogumYili < 1970); //içerideki aslında bir fonksiyone bool döndüren bir fonksiyon aslında

IEnumerable<Unlu> sonuc2 = Veri.Unluler().Where(Olcut); //içerideki aslında bir fonksiyone bool döndüren bir fonksiyon aslında
//unlu => unlu.DogumYili < 1970 methdo olarakta yazılabilr
bool Olcut(Unlu unlu)
{
    return unlu.DogumYili < 1970;
}


foreach (Unlu item in sonuc1)
{
    Console.WriteLine($"{item.Ad} ({item.DogumYili})");
}

Console.WriteLine("\r\n--------------Adi a ile başlayan ünlüler---------------\r\n");

//IEnumerable<Unlu> sonuc3 = Veri.Unluler().Where(AdiAIleBaslarMi);
IEnumerable<Unlu> sonuc3 = Veri.Unluler().Where(unlu => unlu.Ad.StartsWith("A"));


foreach (Unlu item in sonuc3)
{
    Console.WriteLine($"{item.Ad}");
}

bool AdiAIleBaslarMi(Unlu unlu)  //unlu=>unlu.Ad.StartsWith("A")
{
    return unlu.Ad.StartsWith("A");
}


Console.WriteLine("\r\n--------------1970 den sonra doğan oyuncular---------------\r\n");

IEnumerable<Unlu> sonuc4 = Veri.Unluler().Where(x => x.DogumYili >= 1970 && x.Meslek.Contains("Oyuncu"));
IEnumerable<Unlu> sonuc5 = Veri.Unluler().Where(x => x.DogumYili >= 1970).Where(x => x.Meslek.Contains("Oyuncu")); //peş peşede yazılabilr

foreach (Unlu item in sonuc4)
{
    Console.WriteLine($"{item.Ad}-({item.DogumYili})-({item.Meslek})");
}



Console.WriteLine("\r\n--------------1970 den sonra doğan oyuncular Doğum Yıla Göre Sıralı---------------\r\n");

IEnumerable<Unlu> sonuc6 = Veri.Unluler()
                              .Where(x => x.DogumYili >= 1970)
                              .Where(x => x.Meslek
                              .Contains("Oyuncu"))
                              .OrderBy(x => x.DogumYili)
                              .ThenBy(x => x.Ad); //aynı yılda doğanlarıda ada göre sıralar

foreach (Unlu item in sonuc6)
{
    Console.WriteLine($"{item.Ad}-({item.DogumYili})-({item.Meslek})");
}


Console.WriteLine("\r\n-----------------------------------------------------------------\r\n----------------------------JOİN KULLANIMI--------------------------\r\n---------------------------------------------------------------");

Console.WriteLine("\r\n--------------Ülkeleriyle ünlüler---------------\r\n");

//ÜLkeler ve unluler tablosunun birlikte gösterme
//ünlüde ki ulke ıd ülkedeki Id ye karşılık gelsin

var birlestirilmisListe = Veri.Unluler()
                         .Join(Veri.Ulkeler(), unlu => unlu.UlkeId, ulke => ulke.Id, (unlu, ulke) => new { UnluAd = unlu.Ad, UlkeAd = ulke.Ad });

foreach (var item in birlestirilmisListe)
{
    Console.WriteLine($"{item.UnluAd}-{item.UlkeAd}");
}



Console.WriteLine("\r\n--------------Ünlüler ve Ülkeler---------------\r\n");


var unluler = Veri.Unluler();
var ulkeler = Veri.Ulkeler();

var unluUlkeListe = unluler.Join(ulkeler, un => un.UlkeId, ul => ul.Id, (unlu, ulke) => new UnluUlke()
{
    UnluAd = unlu.Ad,
    UnluId = unlu.Id,
    UnluDogumYili = unlu.DogumYili,
    UlkeKod = ulke.Id,
    UlkeAd = ulke.Ad,

}).ToList();

foreach (var item in unluUlkeListe)
{
    Console.WriteLine("{0,2} {1,-20} {2,5} {3,5} {4}", item.UnluId, item.UnluAd, item.UnluDogumYili, item.UlkeKod, item.UlkeAd);
}


Console.WriteLine("\r\n-----------------------------------------------------------------\r\n----------------------------GROUP BY KULLANIMI--------------------------\r\n---------------------------------------------------------------\r\n");

Console.WriteLine("--------------Ülkelere göre gruplama---------------\r\n");

var gruplanmısUlkeler = Veri.Unluler().GroupBy(u => u.UlkeId); //ünlüleri grupluycaZ ONLA BAŞLIYORUZ foreach ile kullanacaksak tolist yapmayabiliriiz

Console.WriteLine("Toplam Grup adedi: " + gruplanmısUlkeler.Count());
Console.WriteLine()
    ;
foreach (var grup in gruplanmısUlkeler)
{
    Console.WriteLine($"{grup.Key} Grubu");
    Console.WriteLine($"{grup.Count()} Gruptaki öğe adedi");

    foreach (Unlu unlu in grup)  //gruptaki kişi adları
    {
        Console.WriteLine(unlu.Ad);
    }
    Console.WriteLine();

}



Console.WriteLine("\r\n-----------------------------------------------------------------\r\n-----------------------------GROUPJOIN KULLANIMI------------------------\r\n---------------------------------------------------------------\r\n");

Console.WriteLine("--------------ÜLke ÜLke Ünlüler ÜLke Adlarıyla---------------\r\n");
//TR- türkye US-amerika FR-Fransa gibi anlaşılır yapıcaz

var unluler1 = Veri.Unluler();
var ulkeler1 = Veri.Ulkeler();

var sonuc = ulkeler1.GroupJoin(
    unluler1,
    ulke => ulke.Id,
    unlu => unlu.UlkeId,
    (ulke, unluler1) => new
    {
        UlkeId = ulke.Id,
        UlkeAd = ulke.Ad,
        Unluler = unluler1.ToList()
    }
    );

foreach (var ulke in sonuc)
{
    Console.WriteLine($"{ulke.UlkeAd} ({ulke.UlkeId})");

    foreach (Unlu unlu in ulke.Unluler)
    {
        Console.WriteLine($"{unlu.Ad} ({unlu.DogumYili})");

    }
    Console.WriteLine();
}


Console.WriteLine("\r\n-----------------------------------------------------------------\r\n---------------------------------DISCTINCT KULLANIMI------------------------\r\n---------------------------------------------------------------\r\n");

Console.WriteLine("--------------Meslekler---------------\r\n");

foreach (var item in Veri.Unluler().Select(x=>x.Meslek).Distinct())
{
    Console.WriteLine(item);
}

Console.ReadKey();