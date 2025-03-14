namespace WebShopBackend.Model
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string City { get; set; } = null!;
        public int ZipCode { get; set; }
        public List<Product> Products { get; set; } = new();
        public List<Checkout> Checkouts { get; set; } = new();
    }
}
