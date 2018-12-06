using Common;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class Customer : BaseClass, ILog
    {
        #region Constructors
        public Customer() : this(0)
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressesList = new List<Address>();
        }
        #endregion

        #region Properties
        public static int Counter { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int CustomerId { get; private set; }
        public List<Address> AddressesList { get; set; }
        public string NameSurname
        {
            get
            {
                string nameSurname = Name;
                if (!string.IsNullOrWhiteSpace(Surname))
                {
                    if (!string.IsNullOrWhiteSpace(nameSurname))
                    {
                        nameSurname += ", ";
                    }
                    nameSurname += Surname;
                }
                return nameSurname;
            }
        }
        public int CustomerType { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// check customer data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var valid = true;

            if (string.IsNullOrWhiteSpace(Surname) || string.IsNullOrWhiteSpace(Email))
                valid = false;

            return valid;
        }

        /// <summary>
        /// Saves a Customer
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // code savesaving a customer
            return true;
        }

        /// <summary>
        /// download a customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Download(int customerId)
        {
            // code downloading a customer
            return new Customer();
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

        public override string ToString()
        {
            return NameSurname;
        }

        public string Log()
        {
            var log = CustomerId + ": " + NameSurname 
                + " Email: " + Email
                + " Status: " + ObjectState.ToString();
            return log;
        }

        #endregion
    }
}
