using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    interface IBuilder
    {

            void AddPancerz();
            void AddUzbrojenie();
            void AddDodatkoweWyposarzenie();
            Robot GetRobot();

    }
}
