using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }
        /*Constructor*/
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        /*Retrieve Customer*/
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "elijahmacharia54@gmail.com";
                customer.FirstName = "Elijah";
                customer.LastName = "Mwangi";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }
        /* Save the current customer*/
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
