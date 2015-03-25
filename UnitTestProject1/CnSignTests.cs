using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Signs;

namespace CnSign.Tests
{
    [TestClass]
    public class CnSignTests
    {
        [TestMethod]
        public void CheckCNSign()
        {
            var cnSign = new CNSigns();

            String expected = "Goat";
            String result = cnSign.cnSignReturn(1979);

            Assert.AreEqual(expected, result);
        }
    }
}
