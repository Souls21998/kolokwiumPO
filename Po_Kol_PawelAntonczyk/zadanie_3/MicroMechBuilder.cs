using System;

namespace zadanie_3.ROBOTY
{
    class MicroMechBuilder : IBuilder
    {
        private Robot robot;
        public void AddDodatkoweWyposarzenie()
        {
            throw new NotImplementedException();
        }

        public void AddPancerz()
        {
            robot.Pancerz = robot.FabrykaPancerzy.MakePancerz("Tytanowy").GetDescription();
            robot.waga += robot.FabrykaPancerzy.MakePancerz("Tytanowy").WagaElem();
        }

        public void AddUzbrojenie()
        {
            throw new NotImplementedException();
        }

        public Robot GetRobot()
        {
            return robot;
        }
    }
}
