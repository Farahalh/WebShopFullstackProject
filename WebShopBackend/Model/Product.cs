namespace WebShopBackend.Model
{
    public class Product
    {
        public int ID { get; set; }
        public string Title { get; set; } = null!;
        public decimal Price { get; set; }
        public string Description { get; set; } = null!;
        public string Category { get; set; } = null!;
        public string Image { get; set; } = null!;
        public int Quantity { get; set; }
        public List<Customer> Customerss { get; set; } = new();
        public List<Checkout> Checkouts { get; set; } = new();
    }
}
