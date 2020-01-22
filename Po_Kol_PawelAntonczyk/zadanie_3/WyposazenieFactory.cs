using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    public interface IWyposazenieFactory
    {
        IDodatkoweWyposazenie MakeWyposazenie(string name);
    }
    class WyposazenieFactory : IWyposazenieFactory
    {
        private readonly Dictionary<string, IDodatkoweWyposazenie> ekwipunek = new Dictionary<string, IDodatkoweWyposazenie>()
    {
        { "Radar", new Radar() },
        { "Maskowanie", new Maskowanie() },
        { "DodatkowaBateria", new DodatkowaBateria() },
        { "EMP", new EMP() }
    };

        public IDodatkoweWyposazenie MakeWyposazenie(string name)
        {
            IDodatkoweWyposazenie wyposazenie;
            this.ekwipunek.TryGetValue(name, out wyposazenie);
            return wyposazenie;
        }
    }
}
