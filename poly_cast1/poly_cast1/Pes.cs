using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly_cast1
{
    internal class Pes:Zvire
    {
        public override void nakrmit(string nazev)
        {
            Console.WriteLine("Pejsek nama" + nazev);
        }
        public Pes() { }
    }
}
