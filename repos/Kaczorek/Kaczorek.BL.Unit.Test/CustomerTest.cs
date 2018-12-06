using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kaczorek.BL.Unit.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void NameSurnameTest()
        {
            Customer customer = new Customer();
            customer.Name = "Robert";
            customer.Surname = "Sokolski";
            string actualNameSurname = customer.NameSurname;
            string nameSurname = "Robert, Sokolski";

            Assert.AreEqual(actualNameSurname, nameSurname);
        }

        [TestMethod]
        public void EmailTest()
        {
            Customer customer = new Customer();
            customer.Email = "robsonlanser@gmail.com";
            string actualEmail = customer.Email;
            string email = "robsonlanser@gmail.com";

            Assert.AreEqual(actualEmail, email);
        }

        [TestMethod]
        public void EmptyNameTest()
        {
            Customer customer = new Customer();
            customer.Surname = "Sokolski";
            string actualNameSurname = customer.NameSurname;
            string nameSurname = "Sokolski";

            Assert.AreEqual(actualNameSurname, nameSurname);
        }

        [TestMethod]
        public void EmptySurnameTest()
        {
            Customer customer = new Customer();
            customer.Name = "Robert";
            string actualNameSurname = customer.NameSurname;
            string nameSurname = "Robert";

            Assert.AreEqual(actualNameSurname, nameSurname);
        }

        [TestMethod]
        public void StaticCounterTest()
        {
            var customer1 = new Customer();
            customer1.Name = "Robert";
            Customer.Counter += 1;

            var customer2 = new Customer();
            customer1.Name = "Franek";
            Customer.Counter += 1;

            var customer3 = new Customer();
            customer1.Name = "Maciek";
            Customer.Counter += 1;

            int counter = Customer.Counter;
            int actualCounter = 3;

            Assert.AreEqual(counter, actualCounter);
        }

        [TestMethod]
        public void ValidateCorrectTest()
        {
            Customer customer = new Customer();
            customer.Surname = "Sokolski";
            customer.Email = "robsonlanser@gmail.com";

            Assert.AreEqual(customer.Validate(), true);
        }

        [TestMethod]
        public void ValidateWrongSurnameTest()
        {
            Customer customer = new Customer();
            customer.Email = "robsonlanser@gmail.com";

            Assert.AreEqual(customer.Validate(), false);
        }

        [TestMethod]
        public void ValidateWrongEmailTest()
        {
            Customer customer = new Customer();
            customer.Surname = "Sokolski";

            Assert.AreEqual(customer.Validate(), false);
        }

        [TestMethod]
        public void CustomerIdTest()
        {
            Customer customer = new Customer(4);
            int customerid = customer.CustomerId;

            Assert.AreEqual(customerid, 4);
        }
    }
}
