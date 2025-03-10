using WebShopShared;

namespace WebShopBackend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapEndpoints();

            app.Run();
        }
    }

    public static class EndpointsMapper
    {
        public static void MapEndpoints(this WebApplication app)
        {
            app.MapGet("/", () => "Hello World!");
            app.MapGet("/products", () => TypedResults.Ok(ProductData.GetProducts()));
            app.MapGet("/products/{id}", (int id) =>
            {
                var product = ProductData.GetProduct(id);
                return TypedResults.Ok(product);
            });
        }
    }

    public static class ProductData
    {
        public static List<ProductDTO> GetProducts()
        {
            return new List<ProductDTO>()
            {
                new ProductDTO() { ID = 1, Name = "Bike", Description = "Super cool", ImageUrl = "img1", Price = 3000, Currency = "SEK"},
                new ProductDTO() { ID = 2, Name = "Car", Description = "Super fast", ImageUrl = "img2", Price = 50000, Currency = "SEK"},
            };
        }

        public static ProductDTO? GetProduct(int id)
        {
            return GetProducts()?.FirstOrDefault(p => p.ID == id);
        }
    }
}
