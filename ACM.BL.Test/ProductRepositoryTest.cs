using NUnit.Framework.Internal;
using System;
using Xunit;

namespace ACM.BL.Test
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            //---Arrage
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "Assorted Size of 4 Bright Yellow Mini Sunflowers",
                ProductName = "Sunflowers"
            };
            //---Act
            var actual = productRepository.Retrieve(2);
            //--Assert
            Assert.Equal(expected.CurrentPrice, actual.CurrentPrice);
            Assert.Equal(expected.ProductDescription, actual.ProductDescription);
            Assert.Equal(expected.ProductName, actual.ProductName);

        }
    }
}
