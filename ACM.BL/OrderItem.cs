using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = OrderItemId;
        }
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        /*Retrieve one order*/
        public OrderItem Retrieve(int OrderItemId)
        {
            return new OrderItem();
        }
        /*Save the current order item*/
        public bool Save()
        {
            return true;
        }

        /*Validate the order item */
        public bool Validate()
        {
            var isValid = true;
            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
