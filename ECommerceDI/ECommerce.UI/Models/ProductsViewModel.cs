using System.Globalization;

namespace ECommerce.UI.Models;

public class ProductsViewModel
{
    private static CultureInfo _priceCulture = new("en-US");

    public ProductsViewModel(string name, decimal unitPrice) 
    {
        SummaryText = string.Format(_priceCulture, $"{name} {unitPrice:C}");
    }

    public string SummaryText { get; } 
}