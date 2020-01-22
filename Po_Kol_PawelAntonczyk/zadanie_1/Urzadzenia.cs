using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1
{
    internal abstract class Urzadzenia
    {
        public Dictionary<int, Usb> UsbPort = new Dictionary<int, Usb>();

        public void PobierzPrzezUsb(Usb usb)
        {
            usb.PobierzDane();
        }
        public void WyslijPrzezUsb(Usb usb)
        {
            usb.WyslijDane();
        }

        int i = 0;
        public void DodajUsb(Usb usb)
        {
            this.UsbPort.Add(i, usb);
            i++;
        }
    }

    internal class Laptop : Urzadzenia
    {
        public Laptop()
        {
        }
    }
    internal class Smartfon : Urzadzenia
    {
        public Smartfon()
        {
        }
    }
    internal class Tablet : Urzadzenia
    {
        public Tablet()
        {
        }
    }
    internal class KomputerStacjonarny : Urzadzenia
    {
        public KomputerStacjonarny()
        {
        }
    }

}
