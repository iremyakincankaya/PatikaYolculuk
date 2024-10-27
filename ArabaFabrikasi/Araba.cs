using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaFabrikasi
{
    public class Araba
    {
        //Araba -> Üretim Tarihi, Seri Numarası, Marka, Model, Renk, Kapı Sayısı
        public DateTime UretimTarihi { get; set; }
        public string SeriNo { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int KapiSayisi { get; set; }

        public Araba( string seriNo, string marka, string model, string renk, int kapiSayisi)
        {
            SeriNo = seriNo;
            Marka = marka;
            Model = model;
            Renk = renk;
            KapiSayisi = kapiSayisi;
            UretimTarihi = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Araba Markas: {Marka} Model: {Model} Renk: {Renk} Kapı Sayısı: {KapiSayisi} SeriNo: {SeriNo} Uretim Tarihi: {UretimTarihi.ToString("yyyy-MM-dd")}";
        }





    }
}
