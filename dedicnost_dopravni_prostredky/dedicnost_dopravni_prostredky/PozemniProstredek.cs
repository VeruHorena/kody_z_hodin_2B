using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dedicnost_dopravni_prostredky
{
    internal class PozemniProstredek : DopravniProstredek
    {
        private string typPaliva;
        private string tvrzeni = "Silnice jsou na prd.";
        private int pocetKol;

        public void setTypPaliva(string nazev)
        {
            this.typPaliva = nazev;
        }

        public string getTypPaliva()
        {
            return typPaliva;
        }

        public void setPocetKol(int pocet)
        {
            this.pocetKol = pocet;
        }

        public int getPocetKol()
        {
            return pocetKol;
        }
        public void jedePoZemi()
        {
            Console.WriteLine("Prostredek je pozemni.");
        }

        public PozemniProstredek(string typPaliva, int pocet, string nazev, int rychlost) : base(nazev, rychlost)
        {
            this.typPaliva= typPaliva;
            this.pocetKol = pocet;
            Console.WriteLine("Vola se konstruktor tridy PozemniProstredek pro " + nazev);
        } }
}
