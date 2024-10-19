string Tersi(string metin)
{
    if (string.IsNullOrEmpty(metin) || metin.Length==1)
        return metin;

    return Tersi(metin.Substring(1)) + metin[0];
}
string gonulluler = "berkan";
string tersi = Tersi(gonulluler);

Console.WriteLine($"{gonulluler} tersi : {tersi}");

Console.ReadKey();

/*
 * kabak
 * abakk
 * bakka
 * akkab
 * kkaba
 * kabak
 * 
 * 
 * 
 */