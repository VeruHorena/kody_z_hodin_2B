using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obchod
{
   
        public class Produkt
        {
            public string Nazev { get; set; }
            public double Cena { get; set; }
            public string Popis { get; set; }

            public Produkt(string nazev, double cena, string popis)
            {
                Nazev = nazev;
                Cena = cena;
                Popis = popis;
            }
        }
    }

