using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace Techno
{
    public class Program
    {
        static void Main(string[] args)
        {


            /*
             1- Konsol ekranından kullanıcıya telefon üretmek için 1 bilgisayar üretmek için 2'ye basması gerektiğini söyleyiniz.
             
             2- Kullanıcının seçimine göre ilgili classtan nesne üreterek özelliklerini konsol ekranından yani     kullanıcıdan         alınız.
             
             3- Bütün bilgiler girildiğinde ürünün başarıyla üretildiğini bir mesaj ile bildirip başka bir ürün üretmek         isteyip      istemediğini sorunuz.
             
             4- Kullanıcı evet cevabını verirse 1. aşamaya geri dönünüz, hayır cevabını verirse iyi günler dileyerek         uygulamayı      sonlandırınız.
                          */

            while (true)
            {
                Console.WriteLine("Telefon üretmek için 1, Bilgisayar üretmek için 2 ye basınız.");
                string name;
                int serialNumber;
                string describtion;
                string operationSystem;
                string licence;
                string USBPort;
                string bluetooth;


                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    if (result == 1)
                    {
                        Phone phone = new Phone();

                        Console.WriteLine("Telefon ismi giriniz");
                        name = Console.ReadLine();
                        phone.Name = name;

                        phone._ProductionDate = DateTime.Now;

                        Console.WriteLine("Açıklama giriniz");
                        describtion = Console.ReadLine();
                        phone.Description = describtion;

                        Console.WriteLine("İşletim sistemini giriniz");
                        operationSystem = Console.ReadLine();
                        phone.OperationSystem = operationSystem;

                        Console.WriteLine("Seri no giriniz");
                        serialNumber = int.Parse(Console.ReadLine());
                        phone.SerialNo = serialNumber;

                        Console.WriteLine("TR Lisansı varsa 'E' giriniz. Yoksa 'H'");
                        licence = Console.ReadLine().ToUpper();
                        phone.TRLicense = licence;

                        phone.GetProductName();
                        phone.DisplayInfo();

                    }
                    else
                    {
                        Computer computer = new Computer();

                        Console.WriteLine("Bilgisayar ismi giriniz");
                        name = Console.ReadLine();
                        computer.Name = name;

                        computer._ProductionDate = DateTime.Now;

                        Console.WriteLine("Açıklama giriniz");
                        describtion = Console.ReadLine();
                        computer.Description = describtion;

                        Console.WriteLine("İşletim sistemini giriniz");
                        operationSystem = Console.ReadLine();
                        computer.OperationSystem = operationSystem;

                        Console.WriteLine("Seri no giriniz");
                        serialNumber = int.Parse(Console.ReadLine());
                        computer.SerialNo = serialNumber;

                        Console.WriteLine("USB port sayısı giriniz 2 ya da 4 olabilir");
                        USBPort = Console.ReadLine();
                        computer.USBPort = int.Parse(USBPort);

                        Console.WriteLine("Bluetooth varsa 'E' giriniz. Yoksa 'H'");
                        bluetooth = Console.ReadLine().ToUpper();
                        computer.Bluetooth = bluetooth;

                        computer.GetProductName();
                        computer.DisplayInfo();
                    }


                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir değer giriniz");
                    Console.Clear();
                }

                Console.WriteLine("Başka bir ürün üretmek istiyor musunz? (E/H)");
                string cevap = Console.ReadLine().ToLower();

                if (cevap == "e")
                {
                    Console.Clear();
                }
                else
                {
                    return;
                }
            }
        }
    }
}
