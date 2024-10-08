using System;

namespace Week2_Practice_While
{
    public class Program
    {
        static void Main()
        {
            //Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

            int i = 0; 
            while (i <= 10)
            {
                Console.WriteLine("Kendime inanıyorum!");
                i++;
            }
            Console.WriteLine(" ");

            //1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
            i = 1;
            while (i < 20)
            {
                Console.WriteLine($"{i}");
                i++;
            }
            Console.WriteLine(" ");

            //1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
            i = 2;
            while (i < 20)
            {
                Console.WriteLine($"{i}");
                i+=2;
            }
            Console.WriteLine(" ");

            //50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
            i = 50;
            int toplam = 0;
            while (i < 150)
            {
                toplam = toplam + i;
                i++;
            };
            Console.WriteLine($"{toplam}");
            Console.WriteLine(" ");

            // 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
            i = 1;
            int toplamCiftSayilar = 0;
            int toplamTekSayilar = 0;

            while (i < 120) 
            {
                if (i %2 ==0)
                {
                    toplamCiftSayilar = toplamCiftSayilar + i;
                    
                }
                else
                {
                    toplamTekSayilar = toplamTekSayilar + i;
                }
                i++;
            };
            Console.WriteLine($"{toplamTekSayilar}");
            Console.WriteLine($"{toplamCiftSayilar}");
            Console.WriteLine(" ");

            Console.ReadKey();
        }


    }
}
