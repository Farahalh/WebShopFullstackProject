using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Text.Json.Serialization;
using WebShopBackend.Data;
using WebShopShared;

namespace WebShopBackend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
        

            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            });

            if (builder.Environment.IsDevelopment())
            {
                builder.Configuration.AddUserSecrets<Program>();
            }

            var connectionString = builder.Configuration.GetConnectionString("WebShopDb");

            builder.Services.AddDbContext<WebShopDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
                options.LogTo(message => Debug.WriteLine(message));
                options.EnableSensitiveDataLogging();
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

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
            return [];
        }

        public static ProductDTO? GetProduct(int id)
        {
            return GetProducts()?.FirstOrDefault(p => p.ID == id);
        }
    }
}
