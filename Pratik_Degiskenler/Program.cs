namespace Pratik_Degiskenler
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input=null;
            Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz:");

            Console.Write($"TC Kimlik No:"); 
            input=Console.ReadLine();
            string TCKN = input;

            Console.Write($"Adınız:");
            input = Console.ReadLine();
            string ad = input;

            Console.Write($"Soyadınız:");
            input = Console.ReadLine();
            string soyad = input;

            Console.Write($"Telefon Numaranız:");
            input = Console.ReadLine();
            string telNo = input;

            Console.Write($"Yaşınız:");
            input = Console.ReadLine();
            string yas = input;

            Console.Write($"İlk aldığınız ürünün fiyatı:");
            string ilkUrunFiyat = Console.ReadLine();

            Console.Write($"İkinci aldığınız ürünün fiyatı:");
            string ikinciUurunFiyat = Console.ReadLine();

            int totalPrice = Int32.Parse(ilkUrunFiyat) + Int32.Parse(ikinciUurunFiyat);
            double oran = 0.10;
            double patikaPuan = totalPrice * oran;

            // Ürünlerin fiyatını integer olarak olarak tutmalıyız ya da double de olabilir çünkü sayı olmaları gereklidir. 
            // Tel no string olarak tutulmalıdır

            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine($"{TCKN} TC Kimlik numaralı {ad} {soyad} kişisi için kayıt oluşturulmuştur." );

            Console.WriteLine($"{telNo} Telefon numarasına mesaj gönderilmiştir.");

            Console.WriteLine($"{totalPrice} TL toplam harcama karşılığı kazanılan %10 Patika Puan > {patikaPuan} TL'dir.");

            Console.ReadKey();
            





            }
        }
}
