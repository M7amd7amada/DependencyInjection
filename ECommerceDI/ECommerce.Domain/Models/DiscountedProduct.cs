namespace ECommerce.Domain.Models;

public class DiscountedProduct
{
    public DiscountedProduct(string name, decimal unitPrice)
    {
        if (name is null) throw new ArgumentNullException(nameof(name));

        Name = name;
        UnitPrice = unitPrice;
    }

    public string Name { get; }
    public decimal UnitPrice { get; }
}