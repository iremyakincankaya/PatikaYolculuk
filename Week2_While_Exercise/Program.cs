Random rand = new Random();
int hedef = rand.Next(1, 3);
int tahmin = 0;


while (tahmin != hedef)
{
    try
    {
        Console.WriteLine("Bir tahmin yapın:");
        tahmin = int.Parse(Console.ReadLine());

        if (tahmin < hedef)
        {
            Console.WriteLine("Daha büyük sayı giriniz");
        }
        else if (tahmin > hedef)
        {
            Console.WriteLine("Daha küçük sayı giriniz");
        }
        else
        {
            Console.WriteLine("Doğru tahmin!");
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Lütfen sayısal deger giriniz!");
    }
}
;
Console.ReadKey();
