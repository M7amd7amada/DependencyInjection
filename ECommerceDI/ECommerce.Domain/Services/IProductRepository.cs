namespace ECommerce.Domain.Services;

public interface IProductRepository
{
    public IEnumerable<Product> GetFeaturedProducts();
}