using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    

    public abstract class Robot
    {
        public string Name;
        public double maxUdzwig;
        public double waga = 0;
        public string Pancerz;
        public string Uzbrojenie;
        public string DodatkoweWyposazenie;

        internal PancerzFactory FabrykaPancerzy = new PancerzFactory();
        internal UzbrojenieFactory FabrykaBroni = new UzbrojenieFactory();
        internal WyposazenieFactory FabrykaWyposazenia = new WyposazenieFactory();

        public void PokazDaneRobota()
        {
            Console.WriteLine($"{this.Name}  MaxUdzwig = {this.maxUdzwig} Aktualna waga = {this.waga} ");
        }
    }
}
