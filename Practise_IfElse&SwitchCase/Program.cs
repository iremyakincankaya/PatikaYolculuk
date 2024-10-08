
using System.Security.Claims;

public class Meyveler
{
    static void MeyveSec()
    {
        Console.WriteLine("Welcome to Ruya Greenrocer");
        Console.WriteLine("Apple = 2 TL");
        Console.WriteLine("Pear = 3 TL");
        Console.WriteLine("Strawberry = 5 TL");
        Console.WriteLine("Banana = 4 TL");

        Console.Write("Hangi meyveyi satın almak istersiniz?");
        string fruit = Console.ReadLine().ToLower();

        //ToLower ile girilen harfleri küçülterek sorgulara geçiyorum.

        if (fruit == "apple")
        {
            Console.WriteLine($"Seçtiğiniz meyvenin fiyatı = 2 TL");
        }
        else if (fruit == "pear")
        {
            Console.WriteLine($"Seçtiğiniz meyvenin fiyatı = 3 TL");
        }
        else if (fruit == "strawberry")
        {
            Console.WriteLine($"Seçtiğiniz meyvenin fiyatı = 5 TL");
        }
        else
        {
            Console.WriteLine($"Seçtiğiniz meyvenin fiyatı = 4 TL");
        }
        Console.ReadKey();

        // switch case yapısı ile yapmak daha dogrudur.Daha okunabilirdir. Sadece eşitlik kontrolü yaptıgı için kodu sadeleştirir.

        switch (fruit)
        {
            case "apple":
                Console.WriteLine($"Seçtiğiniz meyvenin fiyatı = 2 TL");
                break;
            case "pear":
                Console.WriteLine($"Seçtiğiniz meyvenin fiyatı = 3 TL");
                break;
            case "strawberry":
                Console.WriteLine($"Seçtiğiniz meyvenin fiyatı = 5 TL");
                break;
            case "banana":
                Console.WriteLine($"Seçtiğiniz meyvenin fiyatı = 4 TL");
                break;
            default:
                Console.WriteLine("Geçersiz bir meyve girdiniz!");
                break;
        }


    }
}






