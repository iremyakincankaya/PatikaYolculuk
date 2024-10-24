using SekillerDunyasi;

//abstrack sınıflardan nesne olusturulamaz 

Sekil s1 = new Dikdortgen() { Genislik = 100, Yukseklik = 50};
Console.WriteLine(s1);

//Console.WriteLine(s1.KoseAdedi);

//s1 içinde tam bir dikörtgen gibi davranabilmesi için onu tekrar kendi trüne cast etmemiz gerekiyor.

//Dikdortgen d1 = (Dikdortgen)s1; //cast etme

Console.WriteLine("Köşe Adedi: " + ((Dikdortgen)s1).KoseAdedi);  //cast etme

Console.WriteLine("Alan:" + s1.Alan());
Console.WriteLine("Cevre:" + s1.Cevre());

Sekil s2 = new Elips() { Genislik = 10, Yukseklik = 10 };
Console.WriteLine(s2);

Console.WriteLine("Alan:" + s2.Alan());
Console.WriteLine("Cevre:" + s2.Cevre());



Console.ReadKey();




    
