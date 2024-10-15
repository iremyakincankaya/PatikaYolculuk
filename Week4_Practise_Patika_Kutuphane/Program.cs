namespace Week4_Practise_Patika_Kutuphane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Default Constructor ile kitap nesnesi oluşturma
            PatikaKutuphane kitap1 = new PatikaKutuphane();
            kitap1._kitapAd = "Adı Aylin";
            kitap1._yazarAd = "Ayşe";
            kitap1._yazarSoyad = "Kulin";
            kitap1._sayfaSayisi = 398;
            kitap1._yayinevi = "Remzi Kitabevi";

            Console.WriteLine($"Kitap Ad: {kitap1._kitapAd} Yazar: {kitap1._yazarAd} {kitap1._yazarSoyad} Sayfa Sayısı: {kitap1._sayfaSayisi} Yayınevi: {kitap1._yayinevi} Kayıt Tarihi: {kitap1._kayitTarihi}");


            // Parametreli Constructor ile kitap nesnesi oluşturma
            PatikaKutuphane kitap2 = new PatikaKutuphane("Adı Aylin", "Ayşe", 398, "Remzi Kitabevi");
            kitap2._yazarSoyad = "Kulin";
            Console.WriteLine($"Kitap Ad: {kitap2._kitapAd} Yazar: {kitap2._yazarAd} {kitap2._yazarSoyad} Sayfa Sayısı: {kitap2._sayfaSayisi} Yayınevi: {kitap2._yayinevi} Kayıt Tarihi: {kitap2._kayitTarihi}");

            Console.ReadKey();
        }
    }
}
