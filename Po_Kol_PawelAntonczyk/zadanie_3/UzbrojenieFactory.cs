using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    public interface IUzbrojenieFactory
    {
        IUzbrojenie MakeUzbrojenie(string name);
    }
    class UzbrojenieFactory : IUzbrojenieFactory
    {
        private readonly Dictionary<string, IUzbrojenie> uzbrojenie = new Dictionary<string, IUzbrojenie>()
    {
        { "Karabin13mm", new Karabin13mm() },
        { "Karabin20mm", new Karabin20mm() },
        { "WyrzutniaZiemiaPowietrze", new WyrzutniaZiemiaPowietrze() },
        { "WyrzutniaZiemiaZiemia", new WyrzutniaZiemiaZiemia() }
    };

        public IUzbrojenie MakeUzbrojenie(string name)
        {
            IUzbrojenie bron;
            this.uzbrojenie.TryGetValue(name, out bron);
            return bron;
        }
    }
}
