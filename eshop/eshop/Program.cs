using System;
using System.Collections.Generic;
namespace eshop
{

    class Program
    {
        static void Main(string[] args)
        {
            // Vytvoření produktů
            Elektronika telefon = new Elektronika("Mobilní telefon", 12499, 2);
            Obleceni tricko = new Obleceni("Tričko", 499, "M", "Bavlna");

            // Vytvoření košíku
            Kosik kosik = new Kosik();

            // Přidání produktů do košíku
            kosik.PridejPolozku(telefon);
            kosik.PridejPolozku(tricko);

            // Zobrazení celkové ceny
            decimal celkovaCena = kosik.VypoctiCelkovouCenu();
            Console.WriteLine($"Celková cena nákupu: {celkovaCena} Kč");
        }
    }
}
