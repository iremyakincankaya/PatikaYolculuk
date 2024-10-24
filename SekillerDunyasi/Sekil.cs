using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDunyasi
{
    //abstract sınıflardan bir örnek instance alınamaz(gövdesini dolduramadıgımız methodlar abstracttır)
    public abstract class Sekil
    {
        public virtual string Ad { get { return "Şekil"; } }
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }

        //gövdersşini koyamadık 
        public abstract double Alan();
        public abstract double Cevre();


        public override string ToString()
        {
            return $"{Ad} ({Genislik}*{Yukseklik})";
        }
    }
}
