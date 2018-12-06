using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class AddressRepository
    {
        /// <summary>
        /// download an address
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public Address Download(int addressId)
        {
            // create instance of address class
            Address address = new Address(addressId);

            // code downloading an address

            // temporairrly coded values, to get address
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.Country = "Poland";
                address.Street = "Letnia";
                address.Town = "Zlotoryja";
                address.ZipCode = "59-500";              
            }

            return address;
        }

        /// <summary>
        /// downloading all customers addresses
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public IEnumerable<Address> DownloadForCustomerId(int customerId)
        {

            // code downloading the addresses

            // temporarily coded values, to get addresses
            var addressesList = new List<Address>();

            Address address = new Address(1)
            {
                AddressType = 1,
                Country = "Poland",
                Town = "Legnica",
                Street = "Jesienna",
                ZipCode = "14-421"
            };
            addressesList.Add(address);

            Address address2 = new Address(2)
            {
                AddressType = 2,
                Country = "Poland",
                Town = "Wroclaw",
                Street = "Wiosenna",
                ZipCode = "50-233"
            };
            addressesList.Add(address2);

            return addressesList;
        }

        /// <summary>
        /// Saves a Address
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // code savesaving an address
            return true;
        }
    }
}
