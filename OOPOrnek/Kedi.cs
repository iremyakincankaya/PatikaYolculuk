using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    //object-hayvan-kedi
    public class Kedi : Hayvan
    {
        public override string Tur => "Kedi";

        public override void Beslen()
        {
            Console.WriteLine("ciğer yiyor");
        }

        public override void HareketEt()
        {
            Console.WriteLine("patileriyle yiyor");

        }

        public override void SesCikar()
        {
            Console.WriteLine("Miyav!");
        }
    }
}
