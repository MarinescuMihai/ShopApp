namespace ShopAppLibrary.Factory
{
    public class ItemBasedTaxFactory : ITaxFactory
    {
        Item _item;

        public ItemBasedTaxFactory(Item item)
        {
            _item = item;
        }
        public ITax GetTaxObject()
        {
            ITax tax;
            if (!string.IsNullOrEmpty(_item.Owner.Name))
                tax = new TaxByRegion();
            else
            {
                tax = new NoTax();
            }
            return tax;
        }
    }
}
