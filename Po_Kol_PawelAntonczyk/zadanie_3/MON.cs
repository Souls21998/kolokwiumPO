using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    class MON
    {
        readonly IBuilder Builder;

        public Robot BuildRobot(IBuilder builder)
        {

            builder.AddPancerz();
            builder.AddUzbrojenie();
            builder.AddDodatkoweWyposarzenie();

            return builder.GetRobot();
        }

    }
}
