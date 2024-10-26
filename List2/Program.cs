//kullanıcının konsoldan gireceği 5 kahve ismiyle bir liste oluşturup, bu listeyi foreach döngüsüyle yazdıralım.

List<string> kahveler = new List<string>();

Console.WriteLine("Lütfen 5 kahve ismi giriniz");

for (int i = 1; i < 6; i++)
{
    Console.Write($"Kahve {i}: ");
    kahveler.Add(Console.ReadLine());
}

Console.WriteLine("---------------------------");

Console.WriteLine("Girilen Kahve İsimleri:");

foreach (var item in kahveler)
{

    Console.WriteLine(item);
}

Console.ReadKey();




