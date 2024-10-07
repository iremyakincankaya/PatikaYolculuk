using System;
using System.ComponentModel;

namespace Pratik_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
        START:
        HERE:
            Console.Write($"Lütfen bir sayı giriniz :");
            string girilenSayi = Console.ReadLine();

            try
            {

                int sayi = int.Parse(girilenSayi);

                #region 10'danBuyukKucuk
                if (sayi > 10)
                {
                    Console.WriteLine("Girilen sayı 10'dan büyüktür.");
                }
                else if (sayi < 10)
                {
                    Console.WriteLine("Girilen sayı 10'dan küçüktür.");
                }
                else
                {
                    Console.WriteLine("Girilen sayı 10'a eşittir.");
                }
                #endregion

                #region TekCiftKontrol

                if (sayi % 2 == 0)
                {
                    Console.WriteLine("Girilen sayı çift sayıdır.");
                }
                else
                {
                    Console.WriteLine("Girilen sayı tek sayıdır.");
                }

                #endregion
            }
            //try catch yapısı ile hatayı handle ettim
            catch (Exception)
            {
                Console.WriteLine("Lütfen sayısal değer giriniz!");
                Console.WriteLine("---------------");
                goto HERE;
            }

            Console.WriteLine("---------------");
            //Console.ReadKey();
            goto START;
        }


    }
}
