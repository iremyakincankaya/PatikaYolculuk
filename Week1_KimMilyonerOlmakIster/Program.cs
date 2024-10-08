//Yarısmanın baslangıcı
Console.WriteLine("Kim Milyoner Olmak İster?");
Console.WriteLine("3 sorudan en az 2'sine doğru cevap vererek milyoner olabilirsiniz!");
Console.WriteLine("Yarışma Başlıyor!");
Console.WriteLine("İşte Sorular!");
Console.WriteLine("");
Console.WriteLine("1.Soru: Kızınca tüküren hayvan hangisidir?");
Console.WriteLine("A) Lama     B) Deve");
Console.WriteLine("");
Console.Write("1. Soru için cevabınız(A/B) :");

// sayac ile dogru yanıt sayısı kontrol edilir. Eger soruyu dogru yanıtlar ise sayac 1 arttırılır.
int sayac = 0;

string hayvan = Console.ReadLine().ToLower();

//1.soru kontrolü
if (hayvan == "a")
{
    Console.WriteLine("Doğru bildiniz. Bir sonraki soruya geçelim.");
    sayac++;
}
else
{
    Console.WriteLine("Yanlış cevap. Milyoner olma şansınız hala devam ediyor. Sıradaki soruya geçelim.");
}

Console.WriteLine(" ");
Console.WriteLine("2.Soru: Dünyaya en yakın gezegen hangisidir?");
Console.WriteLine("A) Venüs     B) Merkür");
Console.WriteLine("");
Console.Write("2. Soru için cevabınız(A/B) :");

string gezegen = Console.ReadLine().ToLower();

//2.soru kontrolü
if (gezegen == "b")
{
    sayac++;

    if (sayac > 1)
    {
        Console.WriteLine("Doğru bildiniz.");
    }
    else
    {
        Console.WriteLine("Doğru bildiniz. Bir sonraki soruya geçelim. Şansınız devam ediyor.");
    }
}
else
{
    if (sayac > 0)
    {
        Console.WriteLine("Yanlış cevap. Bir sonraki soruya geçelim. Şansınız devam ediyor.");
    }
    else
    {
        Console.WriteLine("Yanlış cevap.");
    }
}

//3. soru kontrolü
if (sayac > 1)
{
    Console.WriteLine("Kazandınız!");
    Console.ReadKey();
}
else if (sayac == 1)
{
    Console.WriteLine("");
    Console.WriteLine("3.Soru: 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ? ");
    Console.WriteLine("A) 7     B) 12");
    Console.WriteLine("");
    Console.Write("3. Soru için cevabınız(A/B) :");

    string islemSonuc = Console.ReadLine();

    if (islemSonuc == "b")
    {
        Console.Write("Doğru bildiniz. Kazandınız!");
    }
    else
    {
        Console.Write("Yanlış cevap. Kazanamadınız :(");
    }
}
else
{
    Console.Write("Kazanamadınız :(");
}
Console.ReadKey();



