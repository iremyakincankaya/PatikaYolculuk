namespace ZarAt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zar atmak için bir tusa bas");
            Console.ReadKey(true);

            Random rnd = new Random();  
            int zar= rnd.Next(1,7);

            Console.WriteLine($"Gelen zar: {zar}");
            
            Console.WriteLine("\r\nTekrar için e, çıkmak için başka tusa basınız");
            ConsoleKey tus = Console.ReadKey(true).Key;

            if(tus==ConsoleKey.E)
                goto 

        }
    }
}
