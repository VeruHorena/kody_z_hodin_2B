using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinkedList<string> ukoly = new LinkedList<string>();

        // Přidání úkolů
        ukoly.AddFirst("Úkol 1");
        ukoly.AddLast("Úkol 2");
        ukoly.AddLast("Úkol 3");

        // Odebrání prvního úkolu
        ukoly.RemoveFirst();

        // Výpis všech úkolů
        Console.WriteLine("Seznam úkolů:");
        foreach (var uk in ukoly)
        {
            Console.WriteLine(uk);
        }
    }
}
