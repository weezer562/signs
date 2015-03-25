using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Signs;

namespace MoonSign.Test
{
    [TestClass]
    public class MoonSignTests
    {
        [TestMethod]
        public void CheckMoonSign()
        {
            
            
            var moonSigns = new MoonSigns();

            String expected = "Capricorn";
            String result = moonSigns.moonSignReturn(1, 1);

            Assert.AreEqual(expected, result);
        }
    }
}
