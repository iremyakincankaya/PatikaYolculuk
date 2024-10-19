#region Yöntem 1 (for ile)
int Fakt1(int n)
{
    int sonuc = 1;

    for (int i = 2; i < n; i++)
        sonuc *= i;
    return sonuc;
}
#endregion

#region Yöntem 2 (Recursion ile)

int FaktRec(int n)
{
    //base case
    if (n == 0 || n==1) 
        return 1;
    return n* FaktRec(n-1);
}

Console.WriteLine($"5! = {FaktRec(5)}");

#endregion

Console.ReadKey();