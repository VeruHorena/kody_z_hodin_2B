using System;
using System.Collections.Generic;

class Program
{
    static LinkedList<string> ukoly = new LinkedList<string>();

    static void PridatUkolZacatek(string ukol)
    {
        ukoly.AddFirst(ukol);
        Console.WriteLine("Přidán úkol na začátek");
    }
    static void PridatUkolKonec(string ukol)
    {
        ukoly.AddLast(ukol);
       Console.WriteLine("Přidán úkol na konec");

    }
    static void OdebratPrvniUkol()
    {
        ukoly.RemoveFirst();
        Console.WriteLine("Odebrán úkol na začátku");

    }
    static void OdebratPosledniUkol()
    {
        ukoly.RemoveLast();
        Console.WriteLine("Odebrán úkol na konci");

    }

    static void Main()
    {
        PridatUkolZacatek("Úkol1");
        PridatUkolKonec("Úkol2");
        PridatUkolKonec("Úkol3");
        OdebratPrvniUkol();
    }
}
