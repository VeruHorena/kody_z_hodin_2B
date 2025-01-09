using Microsoft.VisualStudio.TestTools.UnitTesting;
using testy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace testy.Tests
{
    [TestClass()]
    public class SudaLichaTests
    {
        [TestMethod()]
        public void jeSudeTest()
        {
            SudaLicha objekt = new SudaLicha();
            Assert.IsTrue(objekt.jeSude(2));
        }

        [TestMethod()]
        public void jeLicheTest()
        {
            SudaLicha objekt = new SudaLicha();
            Assert.IsFalse(objekt.jeSude(3));
        }

     
    }
}