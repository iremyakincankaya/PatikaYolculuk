using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Practise_Patika_Kutuphane
{
    //class
    public class PatikaKutuphane
    {
        //property
        public string _kitapAd;
        public string _yazarAd;
        public string _yazarSoyad;
        public string _yayinevi;
        public int _sayfaSayisi;
        public DateTime _kayitTarihi;

        //default constructor
        public PatikaKutuphane()
        {
            _kayitTarihi = DateTime.Now;
        }
        //parametreli constructor
        public PatikaKutuphane(string kitapAd, string yazarAd, int sayfaSayisi, string yayinevi)
        {
            _kitapAd = kitapAd;
            _yazarAd = yazarAd;
            _sayfaSayisi = sayfaSayisi;
            _yayinevi = yayinevi;
            _kayitTarihi = DateTime.Now;
        }
    }
}
