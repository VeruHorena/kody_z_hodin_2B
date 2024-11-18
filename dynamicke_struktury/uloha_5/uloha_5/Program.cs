using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> seznamProduktu = new Dictionary<int, string>();

        // Přidání produktů
        seznamProduktu.Add(1, "Produkt A");
        seznamProduktu.Add(2, "Produkt B");
        seznamProduktu.Add(3, "Produkt C");

        // Vyhledání produktu podle ID
        int produktID = 2;
        if (seznamProduktu.TryGetValue(produktID, out string nazev))
        {
            Console.WriteLine($"Produkt ID {produktID}: {nazev}");
        }

        // Odstranění produktu
        seznamProduktu.Remove(1);

        // Výpis všech produktů
        Console.WriteLine("\nSeznam produktů:");
        foreach (var produkt in seznamProduktu)
        {
            Console.WriteLine($"ID: {produkt.Key}, Název: {produkt.Value}");
        }
    }
}
