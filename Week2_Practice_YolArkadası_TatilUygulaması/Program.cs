using System.Collections.Generic;
start:
Console.WriteLine("Tail planınızı yapmaya başlayalım...");
Console.WriteLine("Hangi lokasyona gitmek istersiniz? (Bodrum-Marmaris-Çeşme)");
Console.WriteLine("   Bodrum paket başlangıç fiyatı 4000 TL");
Console.WriteLine("   Marmaris paket başlangıç fiyatı 3000 TL");
Console.WriteLine("   Çeşme paket başlangıç fiyatı 5000 TL");

baslangic:
#region lokasyon secimi
string lokasyon = Console.ReadLine().ToLower();
int paketFiyat;
switch (lokasyon)
{
    case "bodrum":
        Console.WriteLine("Bodrum lokasyonu ile devam ediyoruz.");
        paketFiyat = 4000;
        break;
    case "marmaris":
        Console.WriteLine("Marmaris lokasyonu ile devam ediyoruz.");
        paketFiyat = 3000;
        break;
    case "çeşme":
        Console.WriteLine("Çeşme lokasyonu ile devam ediyoruz.");
        paketFiyat = 5000;
        break;
    default:
        Console.WriteLine("Lütfen geçerli bir lokasyon adını giriniz (Bodrum-Marmaris-Çeşme)");
        goto baslangic;
        break;
}
#endregion

#region kisisayisibelirleme
kisisayisi:
string kisiSayisi;
Console.WriteLine("Kaç kişilik tatil planı yapmak istiyorsunuz?");
kisiSayisi = Console.ReadLine();

if (int.TryParse(kisiSayisi, out int sayi))
{
    Console.WriteLine($"{sayi} kişilik {lokasyon} tatil planı ile devam ediyoruz.");
}
else
{
    Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen tekrar kişi sayısı giriniz.");
    goto kisisayisi;
}
#endregion

#region ulasim
ulasim:
Console.WriteLine("Tatilinizi hangi ulaşım yöntemi ile yapmak istersiniz? (Karayolu için 1 - Havayolu için 2 yazabilirsiniz)");
Console.WriteLine("   Karayolu kişi başı ulaşım tutarı gidiş-dönüş 1500 TL");
Console.WriteLine("   Havayolu kişi başı ulaşım tutarı gidiş-dönüş 4000 TL");

string ulasimYontemi = Console.ReadLine();
int ulasimFiyat;

switch (ulasimYontemi)
{
    case "1":
        Console.WriteLine("Karayolu ile ulaşım yapmayı tercih ettiniz.");
        ulasimFiyat = 1500;
        break;
    case "2":
        Console.WriteLine("Havayolu ile ulaşım yapmayı tercih ettiniz.");
        ulasimFiyat = 4000;
        break;
    default:
        Console.WriteLine("Lütfen geçerli bir sayı giriniz(1-2)");
        goto ulasim;
        break;
}


#endregion

#region fiyat
int totalPrice = sayi * paketFiyat + sayi * ulasimFiyat;
Console.WriteLine($" Tatil planınızı neredeyse tamamladık. {lokasyon} için {sayi} kişilik tatil planınız hazır.");
Console.WriteLine($" Toplam tatil ücretiniz: {totalPrice} TL' dir.");
#endregion

Console.WriteLine($" Başka bir tatil planı yapmak ister misiniz? (Evet/Hayır)");
string cevap = Console.ReadLine().ToLower();

switch (cevap)
{
    case "evet":
        Console.WriteLine("Karayolu ile ulaşım yapmayı tercih ettiniz.");
        goto start;
        break;
    default:
        Console.WriteLine("Başka tatil planlarında görüşmek üzere.");
        break;
}
 Console.ReadKey();
