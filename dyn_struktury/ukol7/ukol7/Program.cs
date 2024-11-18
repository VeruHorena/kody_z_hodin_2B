using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<int> znamky = new List<int>();

    static void PridatZnamku(int znamka)
    {
        znamky.Add(znamka);
    }
    static double PrumerZnamek()
    {
       return znamky.Average();
    }
    static int MaxZnamka()
    {
        return znamky.Max();
    }
    static int MinZnamka()
    {
        return znamky.Min();
    }
    static void VypisZnamky()
    {
        foreach (var znamka in znamky)
            Console.WriteLine(znamka);
    }

    static void Main()
    {
        PridatZnamku(1);
        PridatZnamku(2);
        PridatZnamku(3);
        VypisZnamky();
        Console.WriteLine($"Průměr: {PrumerZnamek()}");
    }
}
