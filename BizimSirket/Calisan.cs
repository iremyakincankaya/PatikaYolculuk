using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BizimSirket
{
    public class Calisan
    {
        //bir sınıfın örnekleri üzerinden o sınıfa ait satic üyelere erişilemez. çünkü statik üyeler örnekten örneğe değişmeyn sınıf sweviyesşbde herkes için ortak olan degerlerdir.
        private static decimal _vergiOrani = 0.15m;

        public Calisan()
        {

        }
        public Calisan(string ad, string pozisyon, decimal netMaas)
        {
            Ad = ad;
            Pozisyon = pozisyon;
            NetMaas = netMaas;
        }
        public static void VergiOraniGuncelle(decimal YeniOran)
        {
            _vergiOrani = YeniOran;
        }
        public string Ad { get; set; }
        public string Pozisyon { get; set; }
        public decimal NetMaas { get; set; }

        //public decimal BrutMaas
        //{
        //    get
        //    {
        //        return NetMaas + NetMaas * _vergiOrani;
        //    }
        //}
        //kısa gösterimi altta (sadece get i varsa)
        public decimal BrutMaas => NetMaas + NetMaas * _vergiOrani;

        public override string ToString()
        {
            return $"{Ad} {Pozisyon} {NetMaas:c2} {BrutMaas:c2}";
        }

    }
}
