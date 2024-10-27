// Kullanıcıdan bir sayı girmesini isteyen bir program yazın. Kullanıcı geçerli bir sayı girdiğinde bu sayının karesini ekrana yazdırınız. 

//Kullanıcı geçersiz bir giriş yaparsa (sayı yerine harf veya sembol girmesi gibi), "Geçersiz giriş! Lütfen bir sayı giriniz." şeklinde bir hata mesajı gösteriniz.

while (true)
{
    try
    {
        Console.WriteLine("Lütfen bir sayı giriniz:");
        double sayi = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Girilen sayi: {sayi}, Karesi: {sayi * sayi}");
        Console.WriteLine("Başka bir sayı girmek ister misiniz?(E/H)");
        if (Console.ReadLine().ToLower() != "e")
        {
            return;
        }
    }
    catch
    {
        Console.WriteLine("Geçerli bir sayı giriniz");
    }

}