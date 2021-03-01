using NUnit.Framework.Internal;
using System;
using Xunit;

namespace ACM.BL.Test
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            Customer customer = new Customer
            {
                FirstName = "Elijah",
                LastName = "Mwangi"
            };
            string expected = "Elijah, Mwangi";
            string actual = customer.FullName;
            Assert.Equal(actual, expected);

        }
        [Fact]
        public void FullNameLastNameEmpty()
        {
            Customer customer = new Customer
            {
                FirstName = "Elijah",
            };
            string expected = "Elijah";
            string actual = customer.FullName;
            Assert.Equal(actual, expected);

        }
        /*
        [Fact]
        public void StaticTest()
        {
           var c1 = new Customer();
            c1.FirstName = "Elijah";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Mike";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Joshua";
            Customer.InstanceCount += 1;

            Assert.Equal(3, Customer.InstanceCount);

        }
        */

        [Fact]
        public void ValidateValid()
        {
            var customer = new Customer
            {
                LastName = "Mwangi",
                EmailAddress = "elijahmacharia54@gmail.com"
            };
            var expected = true;
            var actual = customer.Validate();
            Assert.Equal(expected, actual);
        }
    }
}
