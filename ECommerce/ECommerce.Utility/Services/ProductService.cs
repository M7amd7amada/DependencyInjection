using ECommerce.Data;
using ECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Utility.Services;

public class ProductService
{
    private readonly AppDbContext _dbContext;

    public ProductService()
    {
        _dbContext = new AppDbContext();
    }
    public ProductService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IEnumerable<Product> GetFeaturedProducts(bool isCustomerPreferred)
    {
        var discount = isCustomerPreferred ? .95m : 1;
        var products = _dbContext.Products?.Where(p => p.IsFeatured);

        return from p in products
            select new Product
            {
                ProductId = p.ProductId,
                Name = p.Name,
                Discription = p.Discription,
                IsFeatured = p.IsFeatured,
                UnitPrice = p.UnitPrice * discount
            };
    }
}