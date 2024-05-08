using System;
using System.Collections.Generic;

namespace ASP.Net_Mvc_core.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
