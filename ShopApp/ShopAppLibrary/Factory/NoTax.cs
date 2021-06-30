namespace ShopAppLibrary.Factory
{
    public class NoTax : ITax
    {
        public decimal CalculateTax(Item item)
        {
            return 0.0m;
        }
    }
}
