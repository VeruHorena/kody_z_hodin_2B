using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop
{
    class Obleceni : Produkt, IPolozkaKosiku
    {
        public string Velikost { get; set; }
        public string Material { get; set; }

        public Obleceni(string nazev, decimal cena, string velikost, string material) : base(nazev, cena)
        {
            Velikost = velikost;
            Material = material;
        }

        public override void ZobrazInfo()
        {
            Console.WriteLine($"Produkt: {Nazev}\nCena: {Cena} Kč\nVelikost: {Velikost}\nMateriál: {Material}\n");
        }

        public void VlozDoKosiku()
        {
            Console.WriteLine($"{Nazev} byl přidán do košíku.");
        }
    }
}
