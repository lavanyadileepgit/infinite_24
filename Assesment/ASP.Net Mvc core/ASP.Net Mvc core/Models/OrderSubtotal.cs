using System;
using System.Collections.Generic;

namespace ASP.Net_Mvc_core.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
