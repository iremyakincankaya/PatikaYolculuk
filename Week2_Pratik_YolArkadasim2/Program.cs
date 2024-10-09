using System;

class Program
{
    static void Main()
    {
        bool yeniPlan = true;

        while (yeniPlan)
        {
            Console.WriteLine("Tail planınızı yapmaya başlayalım...");
            Console.WriteLine("Hangi lokasyona gitmek istersiniz? (Bodrum-Marmaris-Çeşme)");
            Console.WriteLine("   Bodrum paket başlangıç fiyatı 4000 TL");
            Console.WriteLine("   Marmaris paket başlangıç fiyatı 3000 TL");
            Console.WriteLine("   Çeşme paket başlangıç fiyatı 5000 TL");

            string lokasyon;
            int paketFiyat = 0;
            bool lokasyonGeçerli = false;

            // Lokasyon seçimi
            while (!lokasyonGeçerli)
            {
                lokasyon = Console.ReadLine().ToLower();
                switch (lokasyon)
                {
                    case "bodrum":
                        Console.WriteLine("Bodrum lokasyonu ile devam ediyoruz.");
                        paketFiyat = 4000;
                        lokasyonGeçerli = true;
                        break;
                    case "marmaris":
                        Console.WriteLine("Marmaris lokasyonu ile devam ediyoruz.");
                        paketFiyat = 3000;
                        lokasyonGeçerli = true;
                        break;
                    case "çeşme":
                        Console.WriteLine("Çeşme lokasyonu ile devam ediyoruz.");
                        paketFiyat = 5000;
                        lokasyonGeçerli = true;
                        break;
                    default:
                        Console.WriteLine("Lütfen geçerli bir lokasyon adını giriniz (Bodrum-Marmaris-Çeşme)");
                        break;
                }
            }

            // Kişi sayısı alma
            int sayi = 0;
            bool kisiSayisiGeçerli = false;

            while (!kisiSayisiGeçerli)
            {
                Console.WriteLine("Kaç kişilik tatil planı yapmak istiyorsunuz?");
                string kisiSayisi = Console.ReadLine();

                if (int.TryParse(kisiSayisi, out sayi) && sayi > 0)
                {
                    Console.WriteLine($"{sayi} kişilik tatil planı ile devam ediyoruz.");
                    kisiSayisiGeçerli = true;
                }
                else
                {
                    Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen pozitif bir sayı giriniz.");
                }
            }

            // Ulaşım yöntemi belirleme
            int ulasimFiyat = 0;
            bool ulasimGeçerli = false;

            while (!ulasimGeçerli)
            {
                Console.WriteLine("Tatilinizi hangi ulaşım yöntemi ile yapmak istersiniz? (Karayolu için 1 - Havayolu için 2 yazabilirsiniz)");
                Console.WriteLine("   Karayolu kişi başı ulaşım tutarı gidiş-dönüş 1500 TL");
                Console.WriteLine("   Havayolu kişi başı ulaşım tutarı gidiş-dönüş 4000 TL");

                string ulasimYontemi = Console.ReadLine();

                switch (ulasimYontemi)
                {
                    case "1":
                        Console.WriteLine("Karayolu ile ulaşım yapmayı tercih ettiniz.");
                        ulasimFiyat = 1500;
                        ulasimGeçerli = true;
                        break;
                    case "2":
                        Console.WriteLine("Havayolu ile ulaşım yapmayı tercih ettiniz.");
                        ulasimFiyat = 4000;
                        ulasimGeçerli = true;
                        break;
                    default:
                        Console.WriteLine("Lütfen geçerli bir sayı giriniz (1-2)");
                        break;
                }
            }

            // Tatil ücreti belirleme
            int totalPrice = sayi * paketFiyat + sayi * ulasimFiyat;
            Console.WriteLine($"Tatil planınızı neredeyse tamamladık.  için {sayi} kişilik tatil planınız hazır.");
            Console.WriteLine($"Toplam tatil ücretiniz: {totalPrice} TL' dir.");

            // Yeni tatil planı yapma
            Console.WriteLine("Başka bir tatil planı yapmak ister misiniz? (Evet/Hayır)");
            string cevap = Console.ReadLine().ToLower();
            yeniPlan = cevap == "evet";
        }

        Console.WriteLine("Başka tatil planlarında görüşmek üzere.");
        Console.ReadKey();
    }
}
