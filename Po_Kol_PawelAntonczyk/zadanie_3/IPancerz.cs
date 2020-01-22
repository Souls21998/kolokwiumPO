using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3.ROBOTY
{
    public interface IPancerz
    {
        string GetDescription();
        double WagaElem();
    }
    public class Kewlarowy : IPancerz
    {
        public double waga = 201;
        public string GetDescription()
        {
            return "Pancerz kewlarowy";
        }
        public double WagaElem()
        {
            return this.waga;
        }
    }
    public class Tytanowy : IPancerz
    {
        public double waga = 202;
        public string GetDescription()
        {
            return "Pancerz tytanowy";
        }
        public double WagaElem()
        {
            return this.waga;
        }
    }
    public class Reaktywny : IPancerz
    {
        public double waga = 203;
        public string GetDescription()
        {
            return "Pancerz reaktywny";
        }
        public double WagaElem()
        {
            return this.waga;
        }
    }
}
