using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, string> telefonniSeznam = new Dictionary<string, string>();

    static void PridatKontakt(string jmeno, string cislo)
    {
        telefonniSeznam[jmeno] = cislo;
       // telefonniSeznam.Add(jmeno, cislo);
        Console.WriteLine("Kontakt pridan");

    }
    static void NajitKontakt(string jmeno)
    {
        string kontakt = telefonniSeznam.GetValueOrDefault(jmeno, "Nenalezeno");
        Console.WriteLine("Nalezeno: " + kontakt);
    }
    static void OdebratKontakt(string jmeno)
    {
        telefonniSeznam.Remove(jmeno);
        Console.WriteLine("Kontakt odebran");

    }
    static void VypisKontakty()
    {
        foreach (var k in telefonniSeznam)
        {
            Console.WriteLine("Jmeno: " + k.Key + " Cislo: " + k.Value);

        }
     }

    static void Main()
    {
        PridatKontakt("Jan", "123456789");
        PridatKontakt("Eva", "987654321");
        NajitKontakt("Jan");
        VypisKontakty();
    }
}
