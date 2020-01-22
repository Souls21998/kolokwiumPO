using System;

namespace zadanie_1
{
    internal abstract class Usb : IUsb
    {
        public double maxPredkoscPobierania;
        public double maxPredkoscWysylania;

        protected Usb(double _maxPredkoscPobierania, double _maxPredkoscWysylania)
        {
            this.maxPredkoscPobierania = _maxPredkoscPobierania;
            this.maxPredkoscWysylania = _maxPredkoscWysylania;
        }

        public void PobierzDane()
        {
            Console.WriteLine($"Odbieram dane z prędkością: {this.maxPredkoscPobierania} ");
        }

        public void WyslijDane()
        {
            Console.WriteLine($"Wysłam dane z prędkością: {this.maxPredkoscWysylania}");

        }
    }
    internal class UsbC : Usb
    {
        public UsbC(double maxPredkoscPobierania, double maxPredkoscWysylania) : base (maxPredkoscPobierania, maxPredkoscWysylania)
        {
        }
    }
    internal class UsbA : Usb
    {
        public UsbA(double maxPredkoscPobierania, double maxPredkoscWysylania) : base (maxPredkoscPobierania, maxPredkoscWysylania)
        {
        }
    }


    interface IUsb
    {
        void PobierzDane();
        void WyslijDane();
    }
}
