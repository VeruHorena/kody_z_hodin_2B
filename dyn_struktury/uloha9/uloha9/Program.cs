using System;
using System.Collections.Generic;

class Program
{
    static Stack<string> zpet = new Stack<string>();
    static Stack<string> vpred = new Stack<string>();

    static void NovaStranka(string url)
    {
        if (zpet.Count > 0) 
            vpred.Clear();
        zpet.Push(url);
    }

    static void Zpet()
    {
        if (zpet.Count > 1)
        {
            vpred.Push(zpet.Pop());
            string webzpet = zpet.Peek();
            Console.WriteLine("Zpět na: " + webzpet);
        }
    }

    static void Vpred()
    {
        if (vpred.Count > 0)
        {
            zpet.Push(vpred.Pop());
            string webvpred = zpet.Peek();
            Console.WriteLine("Vpřed na: " + webvpred);
        }
    }

    static void AktualniStranka()
    {
        string akt = zpet.Peek();
        Console.WriteLine("Aktuální stránka: " + akt);
    }

    static void Main()
    {
        NovaStranka("stranka1");
        NovaStranka("stranka2");
        Zpet();
        Vpred();
    }
}
