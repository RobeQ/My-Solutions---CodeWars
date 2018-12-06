using System.Collections.Generic;
using System.Linq;

namespace Kaczorek.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        /// <summary>
        /// download a customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Download(int customerId)
        {
            // create instance of customer class
            Customer customer = new Customer(customerId);
            customer.AddressesList = addressRepository.DownloadForCustomerId(customerId).ToList();

            // code downloading a customer

            // temporairrly coded values, to get customer
            if(customerId == 1)
            {
                customer.Email = "robsonlanser@gmail.com";
                customer.Name = "Robert";
                customer.Surname = "Sokolski";
            }

            return customer;
        }

        /// <summary>
        /// download all customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> Download()
        {
            // downloading all customers
            return new List<Customer>();
        }

        /// <summary>
        /// Saves a Customer
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            // code savesaving a product
            var success = true;
            if (customer.HaveChanges && customer.DataValid)
            {
                if (customer.IsNew)
                {
                    // call out insert procedure
                }
                else
                {
                    // call out update procedure
                }
            }

            return success;
        }
    }
}
