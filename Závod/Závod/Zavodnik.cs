using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Závod
{
    internal class Zavodnik
    {
        private Random generator = new Random();
        private string jmeno;  
            public string getJmeno()
        {
            return this.jmeno;
        }
        public void setJmeno(string nazev)
        {
            this.jmeno = nazev;
        }
        private string prijmeni;
        public string getPrijmeni()
        {
            return this.prijmeni;
        }
        public void setPrijmeni(string nazev)
        {
            this.prijmeni = nazev;
        }
        private int vek;
        public int getVek()
        {
            return this.vek;
        }
        public void setVek(int vek)
        {
            this.vek = vek;
        }
        private int startovni_cislo;
        public int getCislo()
        {
            return this.startovni_cislo;
        }
        public void setCislo(int cislo)
        {
            this.startovni_cislo = cislo;
        }
        private List<int> pouzite = new List<int>();

        public void PredstavSe()
        {
            Console.WriteLine("Jsem " + jmeno + " " + prijmeni + " a mam startovni cislo " + startovni_cislo);
        }
        public Zavodnik(string jmeno, string prijmeni, int vek, int maxZavodnici) { 
        this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.vek = vek;
            int pomocne_cislo = generator.Next(1,maxZavodnici+1);

            while(pouzite.Contains(pomocne_cislo) == true)
            {
         pomocne_cislo = generator.Next(1,maxZavodnici+1);               
            }
            pouzite.Add(pomocne_cislo);
            this.startovni_cislo = pomocne_cislo;
            
        }

        public void zmenUdaje(string jmeno, string prijmeni, string vek)
        {
            if (jmeno != "")
                this.jmeno = jmeno;
            if (prijmeni != "")
                this.prijmeni = prijmeni;
            if (vek != "")
                this.vek = int.Parse(vek);
        }

        public void odstraneniZavodnika()
        {
            pouzite.Remove(this.startovni_cislo);
        }
        
    }
}
