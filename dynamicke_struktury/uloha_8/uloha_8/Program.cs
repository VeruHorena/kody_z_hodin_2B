using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> studenti = new Queue<string>();

        // Přidání studentů
        studenti.Enqueue("Student A");
        studenti.Enqueue("Student B");
        studenti.Enqueue("Student C");

        // Vyvolání studenta
        Console.WriteLine($"Vyvolán: {studenti.Dequeue()}");

        // Výpis zbývajících studentů
        Console.WriteLine("\nZbývající studenti:");
        foreach (var student in studenti)
        {
            Console.WriteLine(student);
        }
    }
}
