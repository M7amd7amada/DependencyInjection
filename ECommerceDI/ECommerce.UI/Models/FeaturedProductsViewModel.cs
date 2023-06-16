namespace ECommerce.UI.Models;

public class FeaturedProductsViewModel
{
    public FeaturedProductsViewModel(IEnumerable<ProductsViewModel> products)
    {
        this.Products = products;
    }

    public IEnumerable<ProductsViewModel> Products { get; }
}