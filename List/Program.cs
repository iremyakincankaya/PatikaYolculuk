
using System.ComponentModel;

//ziyaretci adında liste olusturuldu
List<string> ziyaretci = new List<string>();

//listeye kişiler eklendi
ziyaretci.Add("Hadise");
ziyaretci.Add("Tarkan");
ziyaretci.Add("Hande Yener");
ziyaretci.Add("Ajda Pekkan");

//listedeki kişiler ekrana yazdırıldı
foreach (var item in ziyaretci)
{
    Console.WriteLine(item);
}

Console.ReadKey();