using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class AddressRepository
    {
        /* retrive address*/
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Nairobi";
                address.StreetLine2 = "Thika";
                address.City = "Nairobi";
                address.State = "Nairobi";
                address.Country = "Kenya";
                address.PostalCode = "745";
            }
            return address;
        }
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Nairobi",
                StreetLine2 = "Thika",
                City = "Nairobi",
                State = "Nairobi",
                Country = "Kenya",
                PostalCode = "745"
            };
            addressList.Add(address);
            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Kisumu",
                StreetLine2 = "Eldoret",
                City = "Kisumu",
                State = "Kisumu",
                Country = "Kenya",
                PostalCode = "748"
            };
            addressList.Add(address);
            return addressList;
        }

        /*Save current address method*/
        public bool Save(Address address)
        {
            return true;
        }
    }
}
