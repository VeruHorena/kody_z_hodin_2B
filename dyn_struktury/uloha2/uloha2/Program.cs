using System;
using System.Collections.Generic;

class Program
{
    static List<string> studenti = new List<string>();

    static void PridatStudenta(string jmeno)
    {
        studenti.Add(jmeno);
    }
    static void OdebratStudenta(string jmeno)
    {
        studenti.Remove(jmeno);
    }
    static void VypisStudenty()
    {
        foreach (string jmeno in studenti)
        {
            Console.WriteLine(jmeno);
        }
    }
    static int PocetStudentu()
    {
        return studenti.Count;
    }

    static void Main()
    {
        PridatStudenta("Jan");
        PridatStudenta("Eva");
        VypisStudenty();
        Console.WriteLine($"Počet studentů: {PocetStudentu()}");
        OdebratStudenta("Eva");
        VypisStudenty();
    }
}
