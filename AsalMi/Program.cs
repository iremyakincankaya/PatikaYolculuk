bool AsalMi(int sayi)
{
    for (int i = 0; i <=Math.Sqrt(sayi); i++)
    {
        if (sayi % i == 0)
            return false;
    }
    return true;
}
for (int i = 1; i<=100; i++)
{
    if (AsalMi(i))
        Console.Write(i + " ");
}
Console.ReadKey();