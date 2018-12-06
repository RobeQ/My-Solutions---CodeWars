namespace Kaczorek.BL
{
    public class Address
    {
        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }

        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
    }
}
