using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CakeExample.Tests
{
    [TestClass]
    public class MathToolsTest
    {
        [TestMethod]
        public void TestFactorielle()
        {
            MathTools mtools = new MathTools();
            int value = 4;
            int res;
            res = mtools.Factorielle(value);
            Assert.AreEqual(24, res); 
        }
    }
}
