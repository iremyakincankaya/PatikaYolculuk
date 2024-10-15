using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Practice_Encapsulation
{
    public class Araba
    {
        //Araba sınıfının özellikleri -> Marka, Model, Renk, Kapı Sayısı
        public string _marka;
        public string _model;
        public string _renk;
        public int _kapiSayisi;

        public Araba(string marka, string model, string renk)
        {
            _marka = marka;
            _model = model;
            _renk = renk;
            
        }

        public string Marka
        {
            get
            {
                return _marka;
            }
            set
            {
                _marka = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public string Renk
        {
            get
            {
                return _renk;
            }
            set
            {
                _renk = value;
            }
        }
        public int KapiSayisi
        {
            get
            {
                return _kapiSayisi;
            }
            set
            {
                if (value == 2 || value == 4)
                    _kapiSayisi = value;
                else
                {
                    Console.WriteLine("Arabanın kapı sayısı 2 veya 4 olabilir");
                    value = -1;
                    _kapiSayisi = value;
                }
            }
        }
        //Özelliklerimizden(Property) Kapı sayısı için kapsülleme işlemi yapmak istiyoruz.Eğer bir Araba nesnesi oluşturulduğunda Kapı Sayısı için 2 veya 4 dışında bir değer atanmak isterse konsol ekranında bir uyarı mesajı yayınlayalım ve Kapı Sayısı değerini -1 olarak atayalım.

        public void DisplayCar()
        {
            Console.WriteLine($"Marka: {_marka}");
            Console.WriteLine($"Model: {_model}");
            Console.WriteLine($"Renk: {_renk}");
            Console.WriteLine($"Kapı Sayısı: {_kapiSayisi}");
        }
 
    }
}
