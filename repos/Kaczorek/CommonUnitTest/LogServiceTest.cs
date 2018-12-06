using System;
using System.Collections.Generic;
using Common;
using Kaczorek.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonUnitTest
{
    [TestClass]
    public class LogServiceTest
    {
        [TestMethod]
        public void SaveToFileTest()
        {
            var changedElements = new List<ILog>();
            var customer = new Customer(1)
            {
                Name = "Robert",
                Surname = "Sokolski",
                Email = "robsonlanser@gmail.com",
                AddressesList = null
            };
            changedElements.Add(customer as ILog);

            var product = new Product(2)
            {
                ProductName = "Miska",
                Description = "Miska do zupy",
                ActualPrice = 100M
            };
            changedElements.Add(product as ILog);

            var order = new Order(5)
            {
                DateOfOrder = new DateTime(2018, 12, 02, 22, 00, 00)
            };
            changedElements.Add(order as ILog);

            LogService.SaveToFile(changedElements);
        }
    }
}
