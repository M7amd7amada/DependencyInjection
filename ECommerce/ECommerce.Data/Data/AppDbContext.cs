using ECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options)
        : base(options) { }

    public DbSet<Product>? Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ProductId = 1,
                Name = "Product 1",
                Discription = "Description for Product 1",
                UnitPrice = 10.99m,
                IsFeatured = true
            },
            new Product
            {
                ProductId = 2,
                Name = "Product 2",
                Discription = "Description for Product 2",
                UnitPrice = 19.99m,
                IsFeatured = false
            }
        );
    }

}
