namespace ECommerce.Domain.Services;

public interface IProductService 
{
    public IEnumerable<DiscountedProduct> GetFeaturedProducts();
}
