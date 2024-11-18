using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop
{
    class Kosik
    {
        private List<IPolozkaKosiku> polozkyKosiku = new List<IPolozkaKosiku>();

        // Přidání položky do košíku
        public void PridejPolozku(IPolozkaKosiku polozka)
        {
            polozkyKosiku.Add(polozka);
            polozka.VlozDoKosiku();
        }

        // Výpočet celkové ceny a zobrazení položek
        public decimal VypoctiCelkovouCenu()
        {
            decimal celkovaCena = 0;
            foreach (var polozka in polozkyKosiku)
            {
                if (polozka is Produkt produkt)
                {
                    produkt.ZobrazInfo();
                    celkovaCena += produkt.Cena;
                }
            }
            return celkovaCena;
        }
    }
}
