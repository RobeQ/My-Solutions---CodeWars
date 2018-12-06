using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kaczorek.BL.Unit.Test
{
    [TestClass]
    public class ProductRepositoryUnitTest
    {
        [TestMethod]
        public void DownloadProductTest()
        {
            var productRepository = new ProductRepository();
            var expected = new Product(5)
            {
                ProductName = "Miska",
                ActualPrice = 14.99M,
                Description = "Miska do zupy"
            };
            var actual = productRepository.Download(5);

            // Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.ActualPrice, actual.ActualPrice);
        }
    }
}
