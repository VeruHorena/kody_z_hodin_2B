using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testy
{
    public class SudaLicha
    {
        public bool jeSude(int cislo)
        {
            if (cislo % 2 == 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
