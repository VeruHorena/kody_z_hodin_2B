using System;
using System.Collections.Generic;

class Program
{
    static Queue<string> fronta = new Queue<string>();

    static void PridatStudenta(string jmeno)
    {
        fronta.Enqueue(jmeno);
    }
    static void VyvolatStudenta()
    {
        string jmeno = fronta.Dequeue();
        Console.WriteLine("Vyvolán: " + jmeno);
    }
        static int PocetStudentu()
        {
            return fronta.Count;
        }

    static void Main()
    {
        PridatStudenta("Albert");
        PridatStudenta("Betka");
        VyvolatStudenta();
        VyvolatStudenta();
        Console.WriteLine("Počet studentů ve frontě: " + PocetStudentu());
    }
}
