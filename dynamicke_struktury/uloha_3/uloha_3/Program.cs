using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> zakaznici = new Queue<string>();

        // Přidání zákazníků
        zakaznici.Enqueue("Zákazník 1");
        zakaznici.Enqueue("Zákazník 2");
        zakaznici.Enqueue("Zákazník 3");

        // Obsluha zákazníka
        Console.WriteLine($"Obsloužen: {zakaznici.Dequeue()}");

        // Výpis fronty zákazníků
        Console.WriteLine("\nAktuální fronta:");
        foreach (var zak in zakaznici)
        {
            Console.WriteLine(zak);
        }

        // Počet zákazníků ve frontě
        Console.WriteLine($"\nPočet zákazníků ve frontě: {zakaznici.Count}");
    }
}
