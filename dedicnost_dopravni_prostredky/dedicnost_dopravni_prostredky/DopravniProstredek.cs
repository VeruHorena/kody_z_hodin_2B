using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dedicnost_dopravni_prostredky
{
    internal class DopravniProstredek
    {
        private string nazev;
        private int rychlost;
        private static int pocet = 0;

        public string getNazev()
        {
            return nazev;
        }

        public void setNazev (string nazev)
        {
            this.nazev = nazev;
        }

        public int getRychlos()
        {
            return rychlost;
        }

        public void setRychlost(int rychlost)
        {
            this.rychlost = rychlost;
        }
        public void Pohybujse()
        {
            Console.WriteLine("Prostredek se pohybuje.");
        }

        public DopravniProstredek(string nazev, int rychlost) { 
        this.nazev = nazev;
        this.rychlost = rychlost;
            pocet++;
            Console.WriteLine("Vola se konstruktor tridy DopravniProstredek pro " + nazev);
        }

        public static void vypisPocet()
        {
            Console.WriteLine("Pocet vytvorenych prostredku je: " + pocet);
        }
    }
}
