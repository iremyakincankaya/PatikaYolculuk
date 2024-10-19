using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno
{
    public class Phone:BaseMachine
    {
        public string TRLicense;

        public override void DisplayInfo()
        {
            string licence;

            if (TRLicense=="E")
            {
                licence = "TR Lisanslı ürün";
            }
            else
            {
                licence = "Yurt dışı ürün";

            }
            Console.WriteLine($"Bilgiler:\r\n İsim:{Name}\r\nÜretim Tarihi:{ProductionDate}\r\nSeri No:{SerialNo}\r\nAçıklama:{Description}\r\nİşletim Sistemi:{OperationSystem} \r\nLisans:{licence}");
        }

        public override void GetProductName()
        {
            Console.WriteLine($"Telefonunuzun adı {Name}");

        }
    }
}
