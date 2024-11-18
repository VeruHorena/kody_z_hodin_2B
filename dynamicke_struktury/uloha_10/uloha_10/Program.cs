using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> seznam = new Dictionary<string, string>();

        // Přidání kontaktů
        seznam.Add("Karel", "123456789");
        seznam.Add("Pepa", "987654321");

        // Vyhledání kontaktu
        string name = "Karel";
        if (seznam.TryGetValue(name, out string cislo))
        {
            Console.WriteLine($"{name} - Tel.: {cislo}");
        }

        // Výpis všech kontaktů
        Console.WriteLine("\nSeznam kontaktů:");
        foreach (var k in seznam)
        {
            Console.WriteLine($"{k.Key} - Tel.: {k.Value}");
        }
    }
}
