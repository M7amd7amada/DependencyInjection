using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models;

public record Product
{
    [Key]
    public int ProductId { get; set; }

    [DisplayName("Product Name")]
    public string Name { get; set; } = string.Empty;

    public string? Discription { get; set; }

    [Display(TypeName="decimal(8, 2)")]
    public decimal UnitPrice { get; set; }

    public bool IsFeatured { get; set; }
}