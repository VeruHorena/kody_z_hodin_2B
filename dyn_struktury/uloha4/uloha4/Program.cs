using System;
using System.Collections.Generic;

class Program
{
    static Stack<string> historie = new Stack<string>();

    static void NovaAdresa(string url)
    {
        historie.Push(url);
    }
    static void PredchoziAdresa()
    {
        historie.Pop();
    }
    static void AktualniAdresa()
    {
        string aktualni = historie.Peek();
        Console.WriteLine($"Aktuální stránka: " + aktualni);
    }

    static void Main()
    {
        NovaAdresa("google.com");
        NovaAdresa("seznam.cz");
        AktualniAdresa();
        PredchoziAdresa();
        AktualniAdresa();
    }
}
