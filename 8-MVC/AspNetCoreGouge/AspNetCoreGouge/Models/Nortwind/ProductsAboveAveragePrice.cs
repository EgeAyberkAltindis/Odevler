using System;
using System.Collections.Generic;

namespace AspNetCoreGouge.Models.Nortwind;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
