namespace Week4_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.AreaCalculatin(2, 4);

            Rectangle rectangle = new Rectangle();
            rectangle.AreaCalculatin(3.5, 2);

            Rectangular rectangular = new Rectangular();
            rectangular.AreaCalculatin(6.5, 4);

            Console.ReadKey();
        }
    }
}
