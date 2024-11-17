using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikaflix
{
    internal class KomediDizileri
    {
        public string Ad { get; set; }
        public string Turu { get; set; }
        public string Yonetmenler { get; set; }

        public KomediDizileri(string ad, string yonetmenler, string turu)
        {
            Ad = ad;
            Turu = turu;
            Yonetmenler = yonetmenler;
        }

        public override string ToString()
        {
            return ($"Dizi ad: {Ad},Yönetmenler: {Yonetmenler}, Türü: {Turu}");
        }
    }
}
