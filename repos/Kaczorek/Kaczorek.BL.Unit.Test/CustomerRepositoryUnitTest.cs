using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kaczorek.BL.Unit.Test
{
    [TestClass]
    public class CustomerRepositoryUnitTest
    {
        [TestMethod]
        public void DownloadCustomerTest()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                Email = "robsonlanser@gmail.com",
                Name = "Robert",
                Surname = "Sokolski"
            };
            var actual = customerRepository.Download(1);

            // Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Surname, actual.Surname);
        }

        [TestMethod]
        public void DownloadCustomerWithAddressesTest()
        {
            var customerRepositoryWithAddresses = new CustomerRepository();
            var expected = new Customer(1)
            {
                Email = "robsonlanser@gmail.com",
                Name = "Robert",
                Surname = "Sokolski",
                AddressesList = {new Address(1) {AddressType = 1, Country = "Poland", Town = "Legnica", Street = "Jesienna", ZipCode = "14-421" },
                new Address(2) {AddressType = 2, Country = "Poland", Town = "Wroclaw", Street = "Wiosenna", ZipCode = "50-233"} }
            };
            var actual = customerRepositoryWithAddresses.Download(1);
                    
            
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Surname, actual.Surname);
            for (int i = 0; i < expected.AddressesList.Count; i++)
            {
                Assert.AreEqual(expected.AddressesList[i].AddressId, actual.AddressesList[i].AddressId);
                Assert.AreEqual(expected.AddressesList[i].AddressType, actual.AddressesList[i].AddressType);
                Assert.AreEqual(expected.AddressesList[i].Country, actual.AddressesList[i].Country);
                Assert.AreEqual(expected.AddressesList[i].Street, actual.AddressesList[i].Street);
                Assert.AreEqual(expected.AddressesList[i].Town, actual.AddressesList[i].Town);
                Assert.AreEqual(expected.AddressesList[i].ZipCode, actual.AddressesList[i].ZipCode);
            }
        }
    }
}
