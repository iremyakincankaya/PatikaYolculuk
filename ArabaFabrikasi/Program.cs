using System;
using System.Reflection;

namespace ArabaFabrikasi
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Araba> arabaListesi = new List<Araba>();
            string marka;
            string model;
            string seriNo;
            string renk;
            int kapiSayisi;

            string cevap = ArabaUretilecekMi("Araba üretmek ister misiniz?[E/H]");

            while (cevap == "Evet")
            {
                marka = ArabaOzelligiGir("Arabanın Markası: ");
                model = ArabaOzelligiGir("Arabanın Modeli: ");
                seriNo = ArabaOzelligiGir("Arabanın SeriNosu: ");
                renk = ArabaOzelligiGir("Arabanın Rengi: ");
                kapiSayisi = ArabaKapiSayisiGir();

                Araba araba1 = new Araba(seriNo, marka, model, renk, kapiSayisi);

                arabaListesi.Add(araba1);

                cevap = ArabaUretilecekMi("Başka araba üretmek ister misiniz?(E/H)");

                if (cevap == "Hayır")
                {
                    foreach (var araba in arabaListesi)
                    {
                        Console.WriteLine(araba);
                    }
                    Console.ReadKey();
                }

            }
        }
        public static string ArabaUretilecekMi(string baslik)
        {
            while (true)
            {
                Console.WriteLine(baslik);

                string cevap = Console.ReadLine().ToLower();

                if (cevap == "e")
                {
                    return "Evet";
                }
                else if (cevap == "h")
                {
                    return "Hayır";
                }
                else
                {
                    Console.WriteLine("Geçersiz değer girdiniz");
                }
            }


        }
        public static string ArabaOzelligiGir(string baslik)
        {
            Console.Write(baslik);
            return Console.ReadLine();
        }
        public static int ArabaKapiSayisiGir()
        {
            int kapiSayisi;
        START:
            Console.Write("Arabanın Kapı Sayısı: ");
            try
            {
                kapiSayisi = Convert.ToInt32(Console.ReadLine());
                if (kapiSayisi < 1)
                {
                    Console.WriteLine("Kapı sayısı 1'den küçük olamaz.");
                    goto START;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Geçersiz kapı sayısı girdiniz");
                goto START;
            }
            return kapiSayisi;
        }

    }
}
