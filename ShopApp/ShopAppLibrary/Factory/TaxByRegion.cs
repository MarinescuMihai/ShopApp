namespace ShopAppLibrary.Factory
{
    public class TaxByRegion : ITax
    {
        public decimal CalculateTax(Item item)
        {
            decimal tax;
            if (item.Owner.Region == "LOCAL")
                tax = item.Price * .19m;
            else if (item.Owner.Region == "EU")
                tax = item.Price * .24m;
            else
                tax = item.Price * .35m;
            return tax;
        }
    }
}
