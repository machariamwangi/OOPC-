using NUnit.Framework.Internal;
using System;
using Xunit;

namespace ACM.BL.Test
{
    public class OrderRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            //---Arrage
            var OrderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                    new TimeSpan(7, 0, 0)),
            };
            //---Act
            var actual = OrderRepository.Retrieve(10);
            //--Assert
            Assert.Equal(expected.OrderDate, actual.OrderDate);

        }
    }
}
