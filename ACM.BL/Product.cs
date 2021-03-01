using Acme.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        /* ? denotes a nullable type int or decimal  */
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();
            }
            set { _productName = value; }
        }


        /*Validate the product Data*/
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }
    }

}
