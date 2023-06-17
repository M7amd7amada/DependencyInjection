using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data;

public class AppDbContext : DbContext
{
    private readonly string _connectionString;

    public AppDbContext(string connectionString)
    {
        if (String.IsNullOrWhiteSpace(connectionString))
            throw new ArgumentNullException($"{nameof(connectionString)} shouldn't be empty",
                nameof(connectionString));

        _connectionString = connectionString;
    }

    public DbSet<Product>? Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
    }
}