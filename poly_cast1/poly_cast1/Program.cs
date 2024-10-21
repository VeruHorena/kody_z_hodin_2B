using System.Diagnostics.CodeAnalysis;

namespace poly_cast1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zvire zvire = new Zvire();
            Pes alik = new Pes();
            Kocka mica = new Kocka();

            zvire.nakrmit("granule");
            alik.nakrmit("maso");
            mica.nakrmit("ryba");
        }
    }
}
