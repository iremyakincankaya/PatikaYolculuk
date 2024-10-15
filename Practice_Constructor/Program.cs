namespace Practice_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Default Constructor ile bebek nesnesi oluşturma
            Bebek bebek1 = new Bebek();
            bebek1._ad = "İrem";
            bebek1._soyad = "Yakıncan";
            Console.WriteLine($"Ad: {bebek1._ad}, Soyad: {bebek1._soyad}, Doğum Tarihi: {bebek1._dogumTarihi}");

            // Parametreli Constructor ile bebek nesnesi oluşturma
            Bebek bebek2 = new Bebek("Alaattin", "Kaya");
            Console.WriteLine($"Ad: {bebek2._ad}, Soyad: {bebek2._soyad}, Doğum Tarihi: {bebek2._dogumTarihi}");

            Console.ReadKey();

        }
    }
}
