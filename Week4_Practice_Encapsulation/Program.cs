namespace Week4_Practice_Encapsulation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Araba araba1 = new Araba("Audi", "A5", "Kırmızı");
            araba1.KapiSayisi = 3;
            araba1.DisplayCar();

            Console.ReadKey();
        }
    }
}
