using System;
using System.Collections.Generic;

namespace ASP.Net_Mvc_core.Models;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
