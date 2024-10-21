using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly_cast1
{
    internal class Kocka:Zvire
    {
        public override void nakrmit(string nazev)
        {
            base.nakrmit(nazev);
            Console.WriteLine("Kocka papa");
        }
        public Kocka() { }
    }
}
