using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tablet tab1 = new Tablet();
            Laptop lap1 = new Laptop();

            UsbC usbC = new UsbC(12, 24);
            UsbA usbA = new UsbA(5, 10);

            tab1.DodajUsb(usbA);
            tab1.DodajUsb(usbC);
            lap1.DodajUsb(usbA);
            lap1.DodajUsb(usbC);


            tab1.PobierzPrzezUsb(usbA);
            tab1.WyslijPrzezUsb(usbC);
            lap1.PobierzPrzezUsb(usbA);
            lap1.WyslijPrzezUsb(usbC);


            Console.ReadKey();
        }
    }
}
