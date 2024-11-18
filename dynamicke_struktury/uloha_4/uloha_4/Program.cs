using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> historie = new Stack<string>();

        // Navštívení nových stránek
        historie.Push("Stránka A");
        historie.Push("Stránka B");
        historie.Push("Stránka C");

        // Zobrazení aktuální stránky
        Console.WriteLine($"Aktuální stránka: {historie.Peek()}");

        // Vrácení na předchozí stránku
        Console.WriteLine($"Vrácení na: {historie.Pop()}");

        // Výpis historie
        Console.WriteLine("\nHistorie prohlížeče:");
        foreach (var stranka in historie)
        {
            Console.WriteLine(stranka);
        }
    }
}
