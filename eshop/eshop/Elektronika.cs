using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop
{
    class Elektronika : Produkt, IPolozkaKosiku
    {
        public int Zaruka { get; set; } // Záruka v letech

        public Elektronika(string nazev, decimal cena, int zaruka) : base(nazev, cena)
        {
            Zaruka = zaruka;
        }

        public override void ZobrazInfo()
        {
            Console.WriteLine($"Produkt: {Nazev}\nCena: {Cena} Kč\nZáruka: {Zaruka} roky\n");
        }

        public void VlozDoKosiku()
        {
            Console.WriteLine($"{Nazev} byl přidán do košíku.");
        }
    }
}
