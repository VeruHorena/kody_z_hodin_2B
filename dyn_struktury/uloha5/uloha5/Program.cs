using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<int, string> produkty = new Dictionary<int, string>();

    static void PridatProdukt(int id, string nazev)
    {
        produkty.Add(id, nazev);
    }
    static void NajitProdukt(int id)
    {
        string vysledek = produkty.GetValueOrDefault(id, "Nenalezeno");
        Console.WriteLine("Produkt: " + vysledek);
    }
    static void OdebratProdukt(int id)
    {
        produkty.Remove(id);
    }
    static void VypisProdukty()
    {
        foreach (var prod in produkty)
        {
            Console.WriteLine(prod.Key + " " + prod.Value);
        }
       
    }
    static void Main()
    {
        PridatProdukt(1, "Notebook");
        PridatProdukt(2, "Mobil");
        NajitProdukt(1);
        VypisProdukty();
        NajitProdukt(7);
    }
}
