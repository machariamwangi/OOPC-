using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        /*Retrieve one product*/
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);
            if (productId == 2)
            {
                product.ProductName = "Sunflower";
                product.ProductDescription = "Assorted size set of 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }
        /*Saves the current Product*/
        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
