Console.Write("n: ");
int n = Convert.ToInt32(Console.ReadLine());

int toplam = Topla(n);

int Topla(int sayi)
{
    if (sayi == 0 || sayi == 1)
        return sayi;

    return sayi + Topla(sayi - 1);
}


Console.WriteLine("1den nye kadar sayıların toplamı: " + toplam);
Console.ReadKey();
