namespace ShopAppLibrary
{
    public class Item
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public bool Sold { get; set; }
        public bool PaymentDistributed { get; set; }
        public Vendor Owner { get; set; }
        public string Type { get; set; }

        public string Display 
        { 
            get 
            {
                return string.Format($"{Title} - {Price} LEI");
            } 
        }
    }

}
