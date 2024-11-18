using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> studenti = new List<string>();

        // Přidání studentů
        studenti.Add("Karel");
        studenti.Add("Beáta");
        studenti.Add("Josef");

        // Výpis všech studentů
        Console.WriteLine("Seznam studentů:");
        foreach (var student in studenti)
        {
            Console.WriteLine(student);
        }

        // Odebrání studenta
        studenti.Remove("Beáta");
        Console.WriteLine("\nPo odebrání Beáty:");
        foreach (var student in studenti)
        {
            Console.WriteLine(student);
        }

        // Počet studentů
        Console.WriteLine($"\nPočet studentů: {studenti.Count}");

        // Vyhledání jména
        string nameToFind = "Karel";
        if (studenti.Contains(nameToFind))
        {
            Console.WriteLine($"\nStudent {nameToFind} je v seznamu.");
        }
        else
        {
            Console.WriteLine($"\nStudent {nameToFind} není v seznamu.");
        }
    }
}
