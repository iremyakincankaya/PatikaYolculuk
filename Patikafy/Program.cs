
using Patikafy;

List<MusicPlatform> list = new List<MusicPlatform>()
{
    new MusicPlatform("Ajda Pekkan", "Pop", 1968, 20),
    new MusicPlatform("Sezen Aksu", "Türk Halk Müziği / Pop", 1971, 10),
    new MusicPlatform("Funda Arar", "Pop", 1999, 3),
    new MusicPlatform("Sertab Erener", "Pop", 1994, 5),
    new MusicPlatform("Sıla", "Pop", 2009, 3),
    new MusicPlatform("Serdar Ortaç", "Pop", 1994, 10),
    new MusicPlatform("Tarkan", "Pop", 1992, 40),
    new MusicPlatform("Hande Yener", "Pop", 1999, 7),
    new MusicPlatform("Hadise", "Pop", 2005, 5),
    new MusicPlatform("Gülben Ergen", "Pop / Türk Halk Müziği", 1997, 10),
    new MusicPlatform("Neşet Ertaş", "Türk Halk Müziği / Türk Sanat Müziği", 1960, 2),
};

//Adı 'S' ile başlayan şarkıcılar
var sBaslayanlar = list.Where(x => x.AdSoyad.StartsWith("S")).ToList();
foreach (MusicPlatform sarkici in sBaslayanlar)
{
    Console.WriteLine(sarkici.AdSoyad);
}
Console.WriteLine("--------------------------");

//Albüm satışları 10 milyon'un üzerinde olan şarkıcılar
var satisUzeri = list.Where(x => x.SatisAdeti > 10).ToList();
foreach (MusicPlatform satis in satisUzeri)
{
    Console.WriteLine(satis);
}
Console.WriteLine("--------------------------");

//En çok albüm satan şarkıcı
var maxSatis = list.OrderByDescending(x => x.SatisAdeti).First();
Console.Write("En çok satan>>>> ");
Console.WriteLine(maxSatis);
Console.WriteLine("--------------------------");

//En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı
var enYeni = list.OrderByDescending(x => x.CikisYili).First();
var enEski = list.OrderBy(x => x.CikisYili).First();
Console.Write("En yeni çıkış yapan>>>> ");
Console.WriteLine(enYeni);
Console.Write("En eski çıkış yapan>>>> ");
Console.WriteLine(enEski);

Console.ReadKey();





