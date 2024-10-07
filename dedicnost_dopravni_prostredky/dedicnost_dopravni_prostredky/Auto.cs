using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dedicnost_dopravni_prostredky
{
    internal class Auto : PozemniProstredek
    {
        private string barva;
        public void setBarva(string nazev)
        {
            this.barva = nazev;
        }

        public string getBarva()
        {
            return barva;
        }
        public void Zrychluje() { 
            Console.WriteLine("Auto zrychluje.");
        }

        public Auto(string nazev, int rychlost, string barva, int pocetKol, string palivo) : base(palivo, pocetKol, nazev, rychlost)
        {
            this.barva = barva;
            Console.WriteLine("Vola se konstruktor tridy Auto pro " + nazev);
        }
    }
}
