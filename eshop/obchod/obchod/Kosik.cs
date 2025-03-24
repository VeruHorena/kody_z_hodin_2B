using Microsoft.Maui.Controls.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obchod
{
    public class Kosik
    {
        public List<Produkt> Produkty = new List<Produkt>();

        public void PridatProdukt(Produkt produkt)
        {
            Produkty.Add(produkt);


        }

        public double CelkovaCena()
        {
            return Produkty.Sum(p => p.Cena);
        }
    }
}
