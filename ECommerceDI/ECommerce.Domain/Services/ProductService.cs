namespace ECommerce.Domain.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IUserContext _userContext;

    public ProductService(IProductRepository productRepository,
        IUserContext userContext)
    {
        if (productRepository is null) throw new ArgumentNullException(nameof(productRepository));
        if (userContext is null) throw new ArgumentNullException(nameof(userContext));

        _productRepository = productRepository;
        _userContext = userContext;
    }

    public IEnumerable<DiscountedProduct> GetFeaturedProducts()
    {
        return _productRepository.GetFeaturedProducts()
            .Select(product => product.ApplyDiscountFor(_userContext));
    }
}