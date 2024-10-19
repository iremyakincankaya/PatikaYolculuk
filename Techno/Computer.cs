using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno
{
    public class Computer:BaseMachine
    {
        public int _USBPort;
        public string Bluetooth;

        public int USBPort
        {
            get
            {
                return _USBPort;
            }
            set
            {
                if (value == 2 || value == 4)
                    _USBPort = value;
                else
                {
                    Console.WriteLine("USB port sayısı 2 veya 4 olabilir");
                    value = -1;
                    _USBPort = value;
                }
            }
        }

        public override void DisplayInfo()
        {
            string bluetooth;

            if (Bluetooth=="E")
            {
                bluetooth = "Bluetooth var";
            }
            else
            {
                bluetooth = "Bluetooth yok";

            }
            Console.WriteLine($"Bilgiler:\r\n İsim:{Name}\r\nÜretim Tarihi:{ProductionDate}\r\nSeri No:{SerialNo}\r\nAçıklama:{Description}\r\nİşletim Sistemi:{OperationSystem}\r\nPortSayıyı:{_USBPort}\r\nBluetooth:{bluetooth}");
        }

        public override void GetProductName()
        {
            Console.WriteLine($"Bilgisayarınızız adı {Name}");
        }
    }
}
