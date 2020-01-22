using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    public interface IDodatkoweWyposazenie
    {
        string GetDescription();
    }

    public class Radar : IDodatkoweWyposazenie
    {
        public double waga = 301;
        public string GetDescription()
        {
            return "Radar";
        }
    }
    public class Maskowanie : IDodatkoweWyposazenie
    {
        public double waga = 302;
        public string GetDescription()
        {
            return "Maskowanie";
        }
    }
    public class DodatkowaBateria: IDodatkoweWyposazenie
    {
        public double waga = 303;
        public string GetDescription()
        {
            return "Dodatkowa Bateria";
        }
    }
    public class EMP : IDodatkoweWyposazenie
    {
        public double waga = 304;
        public string GetDescription()
        {
            return "EMP";
        }
    }
}
