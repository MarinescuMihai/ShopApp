namespace ShopAppLibrary
{
    public interface IOrder
    {
        decimal CalculatePriceWithTaxes(Item item);
    }
}
