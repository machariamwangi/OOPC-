using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using Xunit;

namespace ACM.BL.Test
{
    public class CustomeRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            //---Arrage
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "elijahmacharia54@gmail.com",
                FirstName = "Elijah",
                LastName = "Mwangi",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Nairobi",
                        StreetLine2 = "Thika",
                        City = "Nairobi",
                        State = "Nairobi",
                        Country = "Kenya",
                        PostalCode = "745"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Kisumu",
                        StreetLine2 = "Eldoret",
                        City = "Kisumu",
                        State = "Kisumu",
                        Country = "Kenya",
                        PostalCode = "748"
                    }
                }
            };
            //---Act
            var actual = customerRepository.Retrieve(1);
            //--Assert
            Assert.Equal(expected.CustomerId, actual.CustomerId);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
            for (int i = 0; i < 1; i++)
            {
                Assert.Equal(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.Equal(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.Equal(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.Equal(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.Equal(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.Equal(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.Equal(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }

        }
    }
}
