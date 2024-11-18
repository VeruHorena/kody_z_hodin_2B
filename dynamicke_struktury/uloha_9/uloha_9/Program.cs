using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> zpetne = new Stack<string>();
        Stack<string> dopredu = new Stack<string>();
        string aktualni = "Homepage";

        // Navštívení nové stránky
        zpetne.Push(aktualni);
        aktualni = "Page 1";
        dopredu.Clear();

        // Pohyb zpět
        if (zpetne.Count > 0)
        {
            dopredu.Push(aktualni);
            aktualni = zpetne.Pop();
        }

        // Pohyb vpřed
        if (dopredu.Count > 0)
        {
            zpetne.Push(aktualni);
            aktualni = dopredu.Pop();
        }

        Console.WriteLine($"Aktuální stránka: {aktualni}");
    }
}
