using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Patikafy
{
    public class MusicPlatform
    {
        public string AdSoyad { get; set; }
        public string MuzikTuru { get; set; }
        public int CikisYili { get; set; }
        public int SatisAdeti { get; set; }


        public MusicPlatform(string adSoyad, string muzikTuru, int cikisYili, int satisAdeti)
        {
            AdSoyad = adSoyad;
            MuzikTuru = muzikTuru;
            CikisYili = cikisYili;
            SatisAdeti = satisAdeti;

        }

        public override string ToString()
        {
            return ($"Ad Soyad: {AdSoyad}, Müzik Türü: {MuzikTuru}, Çıkış Yılı: {CikisYili}, Satış Adeti: {SatisAdeti}");

        }

    }
}


