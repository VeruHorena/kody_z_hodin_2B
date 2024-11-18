using System;
using System.Collections.Generic;

class Program
{
    static Queue<string> fronta = new Queue<string>();

    static void PridatZakaznika(string jmeno)
    { fronta.Enqueue(jmeno);
    }

    static void ObslouzitZakaznika()
    {
       string obslouzen = fronta.Dequeue();
        Console.WriteLine("Obsloužen: " + obslouzen);
    }
    static int PocetZakazniku()
    {
        return fronta.Count;
    }

    static void Main()
    {
        PridatZakaznika("Petr");
        PridatZakaznika("Marie");
        ObslouzitZakaznika();
        Console.WriteLine($"Počet zákazníků: {PocetZakazniku()}");
    }
}
