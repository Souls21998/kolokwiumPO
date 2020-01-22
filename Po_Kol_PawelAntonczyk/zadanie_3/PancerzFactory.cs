using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie_3.ROBOTY;

namespace zadanie_3
{
    public interface IPancerzFactory
    {
        IPancerz MakePancerz(string name);
    }
    class PancerzFactory : IPancerzFactory
    {
        private readonly Dictionary<string, IPancerz> pancerze = new Dictionary<string, IPancerz>()
    {
        { "Kewlarowy", new Kewlarowy() },
        { "Tytanowy", new Tytanowy() },
        { "Reaktywny", new Reaktywny() }
    };

        public IPancerz MakePancerz(string name)
        {
            IPancerz pancerz;
            this.pancerze.TryGetValue(name, out pancerz);
            return pancerz;
        }
    }
}
