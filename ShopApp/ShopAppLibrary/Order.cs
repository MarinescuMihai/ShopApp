using ShopAppLibrary.Factory;

namespace ShopAppLibrary
{

    public class Order : IOrder
    {
        ITaxFactory _taxFactory;

        public Order(Item item)
            : this(new ItemBasedTaxFactory(item))
        {
        }
        public Order(ITaxFactory taxFactory)
        {
            _taxFactory = taxFactory;
        }

        public decimal CalculatePriceWithTaxes(Item item)
        {
            decimal priceWithTaxes = item.Price;

            priceWithTaxes += _taxFactory.GetTaxObject().CalculateTax(item);
            return priceWithTaxes;
        }
    }
}