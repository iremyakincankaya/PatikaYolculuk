//using Practice_Constructor;

//Bebek sınıfı için 2 adet constructor tanımlayınız.

//1.si Default Constructor tarzında parametre almayan bir metot.

//2.si Ad ve Soyad parametrelerini alarak newleme işlemi sırasında değerleri propertylere atayan alternatif constructor.

//2 Constructor içinde ortak olarak bebek nesnesi oluşturulduğunda konsol ekranında bir " Ingaaaa " yazısı görülsün ve Doğum Tarihi o an olarak atansın.

//Tanımlama sonrasında her iki constructor ile de birer bebek nesnesi tanımlayarak özelliklerini konsol ekranına yazdırınız.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Constructor
{
    public class Bebek
    {
        public string _ad;
        public string _soyad;
        public DateTime _dogumTarihi;

        public Bebek() 
        {
            Console.WriteLine("Ingaaaa");
            _dogumTarihi = DateTime.Now.;
        }

        public Bebek( string ad, string soyad) 
        {
            _ad = ad;
            _soyad = soyad;
            Console.WriteLine("Ingaaaa");
            _dogumTarihi = DateTime.Now;
        }

    }
}
