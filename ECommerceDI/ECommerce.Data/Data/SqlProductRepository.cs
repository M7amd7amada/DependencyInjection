using ECommerce.Domain.Services;

namespace ECommerce.Data;

public class SqlProductRepository : IProductRepository
{
    private readonly AppDbContext _dbContext;

    public SqlProductRepository(AppDbContext dbContext)
    {
        if (dbContext is null) throw new ArgumentNullException(nameof(dbContext));
        _dbContext = dbContext;
    }

    public IEnumerable<Product> GetFeaturedProducts()
    {
        return (_dbContext.Products ?? Enumerable.Empty<Product>())
            .Where(product => product.IsFeatured);
    }
}