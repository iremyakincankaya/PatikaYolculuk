using System;

class Program
{
    static void Main()
    {
       Rectangle dikdortgen = new Rectangle() { Height=12, Width=12 };

        AreaCalculator areaCalculator = new AreaCalculator();
        Console.WriteLine(areaCalculator.CalculateArea(dikdortgen));
        Console.ReadKey();
    }
}
