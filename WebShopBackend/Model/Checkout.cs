namespace WebShopBackend.Model
{
    public class Checkout
    {
        public int ID { get; set; }
        public DateTime TimePurchased { get; set;}
        public required Customer Customer { get; set; } = new();
        public List<Product> Products { get; set; } = new();
    }
}
