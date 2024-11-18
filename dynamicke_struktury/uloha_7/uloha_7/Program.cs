using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> znamky = new List<int> { 1, 2, 3, 4, 5 };

        // Přidání nové známky
        znamky.Add(3);

        // Výpočet průměru
        double prumer = (double)znamky.Sum() / znamky.Count;
        Console.WriteLine($"Průměrná známka: {prumer}");

        // Nejvyšší a nejnižší známka
        Console.WriteLine($"Nejvyšší známka: {znamky.Max()}");
        Console.WriteLine($"Nejnižší známka: {znamky.Min()}");
    }
}
