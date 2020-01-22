using System;

namespace zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    abstract class Osoba
    {
        readonly string Nazwa;

        protected Osoba(string nazwa)
        {
            Nazwa = nazwa;
        }
    }
    class Klient : Osoba
    {
        public Klient(string nazwa) : base(nazwa)
        {
        }
    }
    class PracownikMiesiaca : Osoba, IKasjer, IBok

    {
        public PracownikMiesiaca(string nazwa) : base(nazwa)
        {
        }

        void IKasjer.Obsluz(Klient k)
        {
            Console.WriteLine("IKasjer.Obsluz");
        }
        void IBok.Obsluz(Klient k)
        {
            Console.WriteLine("IBok.Obsluz");
        }
    }

    interface IKasjer
    {
        void Obsluz(Klient k);
    }
    interface IBok
    {
        void Obsluz(Klient k);
    }
}
