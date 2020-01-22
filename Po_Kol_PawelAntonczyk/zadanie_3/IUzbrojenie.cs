using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    public interface IUzbrojenie
    {
        string GetDescription();
    }


    public class Karabin13mm : IUzbrojenie
    {
        public double waga = 101;
        public string GetDescription()
        {
            return "Karabin 13 mm";
        }
    }

    public class Karabin20mm : IUzbrojenie
    {
        public double waga = 102;
        public string GetDescription()
        {
            return "Karabin 20 mm";
        }
    }

    public class WyrzutniaZiemiaPowietrze : IUzbrojenie
    {
        public double waga = 103;
        public string GetDescription()
        {
            return "Wyrzutnia ziemia powietrze";
        }
    }
    public class WyrzutniaZiemiaZiemia : IUzbrojenie
    {
        public double waga = 104;
        public string GetDescription()
        {
            return "Wyrzutnia ziemia ziemia";
        }
    }

}
