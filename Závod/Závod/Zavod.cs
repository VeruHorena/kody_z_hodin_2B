using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Závod
{
    internal class Zavod
    {
        private string nazev;
        public string getNazev()
        {
            return this.nazev;
        }
        public void setNazev(string nazev)
        {
            this.nazev = nazev;
        }

        private string adresa;
        public string getAdresa()
        {
            return this.adresa;
        }
        public void setAdresa(string adresa)
        {
            this.adresa = adresa;
        }
        private int max_pocet;
        public int getmax_pocet()
        {
            return this.max_pocet;
        }
        public void setmax_pocet(int max)
        {
            this.max_pocet = max;
        }
        private int delka;
        public int getDelka()
        {
            return this.delka;
        }
        public void setDelka(int delka)
        {
            this.delka = delka;
        }
        private List<Zavodnik> seznamZavodniku;

        public Zavod(string nazev, string adresa, int max_pocet, int delka)
        {
            this.nazev = nazev;
            this.adresa = adresa;
            this.max_pocet = max_pocet;
            this.delka = delka;
            this.seznamZavodniku = new List<Zavodnik>();
        }
        public void PredstavZavod()
        {
            Console.WriteLine("Nazev zavodu je: " + nazev + ", maximalni pocet ucastniku: " + max_pocet + ", aktualni pocet zavodniku " + seznamZavodniku.Count);
        }

        public void pridejZavodnika(Zavodnik torpedo)
        {
            seznamZavodniku.Add(torpedo);
        }

        public void odeberZavodnika(string jmeno)
        {
            foreach (Zavodnik z in seznamZavodniku)
            {
                if (z.getJmeno() == jmeno)
                {
                    Console.WriteLine("zavodnik byl odebran");
                    z.odstraneniZavodnika();
                    seznamZavodniku.Remove(z);

                    break;
                }

            }
        }

        public void ukonciZavod()
        {
            Console.WriteLine("Zavod byl ukoncen, tady je poradi: ");

            Random generator = new Random();
            int vybrany = generator.Next(1, seznamZavodniku.Count);
            Console.WriteLine("Zlato ziskava: " + seznamZavodniku[vybrany].getJmeno());




        }
    }
}
