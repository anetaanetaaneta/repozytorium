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
        [TestMethod()]
        public void prostokatTest()
        {
            Program.prostokat(2, 3, 4, 5);
            Assert.Fail();
        }
    }
}