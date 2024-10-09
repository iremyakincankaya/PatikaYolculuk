//Kullanıcının girdiği bir limit değerine kadar 0'dan bir sayaç çalıştırıp artırarak, ekrana " Ben bir Patika'lıyım " yazdırınız.
//( Sayacınız 0'dan başlayarak 1'er 1'er artacak, koşulunuz ( Sayac <= Limit ) )

int sayac = 0;
int limit;
Console.Write("Lütfen bir sayı girin: ");
limit = Convert.ToInt32(Console.ReadLine());

while (sayac <= limit)
{
    Console.WriteLine("Ben bir patikalıyım");
    sayac++;
};

sayac = 0;
Console.WriteLine("Lütfen bir sayı girin: ");

do
{
    Console.WriteLine("Ben bir patikalıyım");
    sayac++;
}
while (sayac <= limit);

Console.ReadKey();

//While döngüsü koşulu baştan kontrol ederken, do-while döngüsü koşulu en son kontrol eder ve bu, do-while döngüsünün en az bir kez çalışmasını garanti eder