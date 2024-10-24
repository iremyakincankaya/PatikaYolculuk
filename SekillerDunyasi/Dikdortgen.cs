using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDunyasi
{
    public class Dikdortgen : Sekil
    {
        public override string Ad => "Dikdortgen";

        public int KoseAdedi { get; }
        public override double Alan()
        {
            return Genislik * Yukseklik;
        }

        public override double Cevre()
        {
            return (Genislik * Yukseklik)*2;
        }
    }
}
