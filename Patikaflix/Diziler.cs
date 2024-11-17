using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikaflix
{
    public class Diziler
    {
        public string Ad { get; set; }
        public int YapimYili { get; set; }
        public string Turu { get; set; }
        public int BaslangicYili { get; set; }
        public string Yonetmenler { get; set; }
        public string Platform { get; set; }

        public Diziler(string ad, int yapimYili, string turu, int baslangicYili, string yonetmenler, string platform)
        {
            Ad = ad;
            YapimYili = yapimYili;
            Turu = turu;
            BaslangicYili = baslangicYili;
            Yonetmenler = yonetmenler;
            Platform = platform;
        }
        public override string ToString()
        {
            return ($"Dizi ad: {Ad}, Yapım Yılı: {YapimYili}, Türü: {Turu}, Başlangıç yılı: {BaslangicYili}, Yönetmenler: {Yonetmenler},Platform: {Platform}");
        }





    }
}
