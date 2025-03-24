using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshopList
{
    public class Kosik
    {
        public List<Produkt> Produkty { get; set; } = new List<Produkt>();

        public void PridatDoKosiku(Produkt produkt)
        {
            Produkty.Add(produkt);
        }

        public string ZobrazKosik()
        {
            if (Produkty.Count == 0)
                return "Košík je prázdný.";

            var obsahKosiku = new StringBuilder();
            foreach (var produkt in Produkty)
            {
                obsahKosiku.AppendLine($"{produkt.Nazev} - {produkt.Cena} Kč");
            }
            return obsahKosiku.ToString();
        }
    }
}
