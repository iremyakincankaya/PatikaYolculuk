using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    public class Serce : Kus
    {
        public override string Tur => "Serce Kusu";

        public override void SesCikar()
        {
            Console.WriteLine("cik cik cik");
        }
    }
}
