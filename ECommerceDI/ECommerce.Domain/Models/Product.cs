using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Models;

public class Product
{
    [Key]
    public int ProductId { get; set; }

    public string Name { get; set; } = string.Empty;
    [Column(TypeName = "decimal(8, 2)")]
    public decimal UnitPrice { get; set; }
    public bool IsFeatured { get; set; } = false;

    public DiscountedProduct ApplyDiscountFor(IUserContext user)
    {
        bool isPreffered = 
            user.IsInRole(Role.PreferredCustomer);

        decimal discount = isPreffered ? 0.95m : 1.00m;

        return new DiscountedProduct(
            name: Name,
            unitPrice: UnitPrice * discount
        );
    }
}