using System;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonUnitTest
{
    [TestClass]
    public class StringOperationTest
    {
        [TestMethod]
        public void InsertSpaceTest()
        {
            var source = "StółOgrodowy";
            var expected = "Stół Ogrodowy";
            var actual = source.InsertSpace();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WithSpaceTest()
        {
            var source = "Stół Ogrodowy";
            var expected = "Stół Ogrodowy";
            var actual = source.InsertSpace();

            Assert.AreEqual(expected, actual);
        }
    }
}
