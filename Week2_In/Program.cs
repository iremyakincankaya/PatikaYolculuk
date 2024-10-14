using Week2_In;

void PrintPoint(in Point point)
{
    Console.WriteLine($"X: {point.X}, Y: {point.Y}");
}
Point point = new Point(10,78);

PrintPoint(in point);

Console.ReadKey();