using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kaczorek.BL.Unit.Test
{
    [TestClass]
    public class OrderRepositoryUnitTest
    {
        [TestMethod]
        public void DownloadOrderTest()
        {
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                DateOfOrder = new DateTimeOffset(2018, 4, 20, 11, 00, 00, new TimeSpan(7, 0, 0))
            };
            var actual = orderRepository.Download(10);

            // Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.DateOfOrder, actual.DateOfOrder);
            Assert.AreEqual(expected.OrderId, actual.OrderId);
        }

        [TestMethod]
        public void DownloadOrderDisplayTest()
        {
            var orderRepository = new OrderRepository();
            var expected = new OrderDisplay()
            {
                Name = "Ralph",
                Surname = "Nowak",
                DateOfOrder = new DateTimeOffset(2018, 05, 21, 12, 00, 00, new TimeSpan(5, 0, 0)),
                AddressOrder = new Address() { AddressType = 2, Country = "Poland", Street = "Jasna", ZipCode = "44-432", Town = "Wroclaw" },               
                OrderPositionDisplayList = new List<OrderPositionDisplay>()
                { new OrderPositionDisplay() { ProductName = "Krzeslo", ActualPrice = 45.66M, Amount = 5 },
                    new OrderPositionDisplay() { ProductName = "Stolik", ActualPrice = 100.34M, Amount = 2} }
            };

            var actual = orderRepository.DownloadOrderToDisplay(10);

            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.OrderId, actual.OrderId);
            Assert.AreEqual(expected.Surname, actual.Surname);
            Assert.AreEqual(expected.DateOfOrder, actual.DateOfOrder);

            Assert.AreEqual(expected.AddressOrder.AddressType, actual.AddressOrder.AddressType);
            Assert.AreEqual(expected.AddressOrder.Country, actual.AddressOrder.Country);
            Assert.AreEqual(expected.AddressOrder.Street, actual.AddressOrder.Street);
            Assert.AreEqual(expected.AddressOrder.Town, actual.AddressOrder.Town);
            Assert.AreEqual(expected.AddressOrder.ZipCode, actual.AddressOrder.ZipCode);

            for (int i = 0; i < expected.OrderPositionDisplayList.Count; i++)
            {
                Assert.AreEqual(expected.OrderPositionDisplayList[i].ActualPrice, actual.OrderPositionDisplayList[i].ActualPrice);
                Assert.AreEqual(expected.OrderPositionDisplayList[i].Amount, actual.OrderPositionDisplayList[i].Amount);
                Assert.AreEqual(expected.OrderPositionDisplayList[i].ProductName, actual.OrderPositionDisplayList[i].ProductName);
            }
        }
    }
}