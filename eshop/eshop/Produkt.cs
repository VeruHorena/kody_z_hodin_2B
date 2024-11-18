using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop
{
    abstract class Produkt
    {
        public string Nazev { get; set; }
        public decimal Cena { get; set; }

        public Produkt(string nazev, decimal cena)
        {
            Nazev = nazev;
            Cena = cena;
        }

        // Abstraktní metoda, kterou budou muset potomci přetížit
        public abstract void ZobrazInfo();
    }

}
