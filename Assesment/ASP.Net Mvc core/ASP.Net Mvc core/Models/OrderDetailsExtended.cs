using System;
using System.Collections.Generic;

namespace ASP.Net_Mvc_core.Models;

public partial class OrderDetailsExtended
{
    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal UnitPrice { get; set; }

    public short Quantity { get; set; }

    public float Discount { get; set; }

    public decimal? ExtendedPrice { get; set; }
}
