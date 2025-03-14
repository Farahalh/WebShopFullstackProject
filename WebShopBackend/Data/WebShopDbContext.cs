using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebShopBackend.Model;

namespace WebShopBackend.Data
{
    public class WebShopDbContext : DbContext
    {
        public DbSet<Checkout> Checkouts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
    
    public WebShopDbContext(DbContextOptions<WebShopDbContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.LogTo(message => Debug.WriteLine(message))
                .EnableSensitiveDataLogging();
        }
    }
}
