
using OOP_Encapsulation;

public class Program
{
    public static void Main()
    {
        Person ogrenci1 = new Person();
        Person ogrenci2 = new Person();
        Person ogretmen = new Person();

        ogrenci1.Ad = "İrem";
        ogrenci1.Soyad = "Kaya";
        ogrenci1.DogumTarihi = new DateTime(1995, 11, 25);
        
        ogrenci2.Ad = "Alaattin";
        ogrenci2.Soyad = "Kaya";
        ogrenci2.DogumTarihi = new DateTime(1996, 05, 06);
       
        ogretmen.Ad = "Nilgün";
        ogretmen.Soyad = "Yakıncan";
        ogretmen.DogumTarihi = new DateTime(1972, 05, 08);

        ogrenci1.Bilgiler();
        ogrenci2.Bilgiler();
        ogretmen.Bilgiler();

        Console.ReadKey();
    }

}