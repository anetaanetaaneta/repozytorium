using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figury;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        public int figuraProstokat(int x, int y, int bok1, int bok2)
        {
            x = 0;
            y = 0;
            bok1 = 3;
            bok2 = 4;
            return 
        }
        [TestMethod()]
        public void prostokatTest()
        {
            Program.prostokat(0, 0,4,5);
            Assert.AreEqual(0,0);
            Assert.AreEqual(4, 0);
            Assert.AreEqual(4, 4);
            Assert.AreEqual(0, 4);
        }
    }
}