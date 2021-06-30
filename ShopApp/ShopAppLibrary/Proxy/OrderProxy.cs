using ShopAppLibrary.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopAppLibrary.Proxy
{
    public class OrderProxy
    {
        public decimal CalculatePriceWithTaxes(Item item)
        {
            var order = new Order(item);

            return order.CalculatePriceWithTaxes(item);
        }
    }
}
