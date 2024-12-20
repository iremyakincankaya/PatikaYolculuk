﻿using System;
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
        public string _kitapAd { get; set; }
        public string _yazarAd { get; set; }
        public string _yazarSoyad { get; set; }
        public string _yayinevi { get; set; }
        public int _sayfaSayisi { get; set; }
        public DateTime _kayitTarihi { get; set; }

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
